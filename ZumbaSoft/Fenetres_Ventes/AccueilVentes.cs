using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;
using ZumbaSoft.Model;
using ZumbaSoft.Fenetres_Produit;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class AccueilVente : Form
    {
        Magasin magasin;
        Utilisateur user;
        SQLiteConnection DB;
        public Client client;
        public Panier panierClient;
        
        public AccueilVente(SQLiteConnection db, Magasin m, Utilisateur uConnected)
        {
            InitializeComponent();
            DB = db;
            user = uConnected;
            magasin = m;
            initListClients();
            initPanier();
            initItemsColors();
        }


        public void initListClients()
        {
            listBox1RechercheClient.Items.Clear();
            foreach(Client c in DB.GetAllWithChildren<Client>())
            {
                listBox1RechercheClient.Items.Add(c);
            }
        }

        public void initPanier()
        {
            panierClient = new Panier();
            panierClient.date = DateTime.Now;
            panierClient.magasin = magasin;
            panierClient.produits = new List<ProduitCommande>();
        }

        public void initItemsColors()
        {
            panel1.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel2.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel3.BackColor = Color.FromArgb(95, 12, 12, 12);
            panel4.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel5.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel6.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel7.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel8.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel9.BackColor = Color.FromArgb(80, 12, 12, 12);
            panel10.BackColor = Color.FromArgb(80, 12, 12, 12);

            buttonCatalogueProd.BackColor = Color.FromArgb(80, 12, 12, 12);
            buttonNvClient.BackColor = Color.FromArgb(80, 12, 12, 12);

        }


        private void AccueilVentes_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            /*
            //Add column header
            listView1.Columns.Add("Code Barre", 90);
            listView1.Columns.Add("Nom du produit", 150);
            listView1.Columns.Add("Prix HT", 70);
            listView1.Columns.Add("Prix TTC", 70);
            listView1.Columns.Add("Quantité", 70);*/
        }


        public void refreshListPanier()
        {
            listView1.Items.Clear();
            foreach(ProduitCommande p in panierClient.produits)
            {
                string[] arr = new string[5];
                ListViewItem lst;

                arr[0] = p.produit.code_barre.ToString();
                arr[1] = p.produit.nom;
                arr[2] = p.produit.prix_vente_HT.ToString();
                arr[3] = p.produit.prix_vente_TTC.ToString();
                arr[4] = p.quantite.ToString();

                lst = new ListViewItem(arr);
                listView1.Items.Add(lst);
            }

            refreshPrixTotal();
        }

        public void refreshPrixTotal()
        {
            decimal somme = 0;
            foreach (ProduitCommande p in panierClient.produits)
            {
                somme += (p.produit.prix_vente_TTC * p.quantite);
            }
            labelPrixTotal.Text = "Montant Total : " + somme + "€";
        }


        private void buttonNvClient_Click(object sender, EventArgs e)
        {
            NouveauClient nvc = new NouveauClient(DB);
            if (nvc.ShowDialog() == DialogResult.OK)
            {
                initListClients();
            }
            
        }

        private void textBoxRechercheClient_TextChanged(object sender, EventArgs e)
        {
            listBox1RechercheClient.Items.Clear();
            string searche = textBoxRechercheClient.Text.ToUpper();
            List<Client> clientsSearched = DB.GetAllWithChildren<Client>().FindAll(p => p.nom.ToUpper().Contains(searche));
            foreach (Client p in clientsSearched)
            {
                listBox1RechercheClient.Items.Add(p);
            }
        }

        private void listBox1RechercheClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client c = (Client)listBox1RechercheClient.SelectedItem;
            panierClient.client = (Client)listBox1RechercheClient.SelectedItem;
            labelNomClient.Text = c.ToString();
        }

        private void buttonCatalogueProd_Click(object sender, EventArgs e)
        {
            RechercheProduit rp = new RechercheProduit(DB);
            if(rp.ShowDialog() == DialogResult.OK)
            {
                Produit selectedProduit = rp.selectedPRoduit;
                ProduitCommande pTest = panierClient.produits.Find(p => p.produit.id_produit == selectedProduit.id_produit);

                if(pTest == null)
                {
                    ProduitCommande p = new ProduitCommande();
                    p.produit = selectedProduit;
                    p.quantite = 1;
                    p.panier = panierClient;
                    panierClient.produits.Add(p);
                    DB.InsertWithChildren(p);
                }
                else
                {
                    pTest = DB.GetWithChildren<ProduitCommande>(pTest.id_produitCommande);
                    pTest.quantite += 1;
                }
                refreshListPanier();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRuptureStock.Visible = false;
            try
            {
                int index = listView1.SelectedItems[0].Index;
                ProduitCommande produit = panierClient.produits[index];
                labelQuantite.Visible = true;
                labelQuantite.Text = "Quantité : " + produit.quantite;
                buttonPlus.Visible = true;
                buttonMoins.Visible = true;
            }
            catch(Exception ex) {
                labelQuantite.Visible = false;
                buttonPlus.Visible = false;
                buttonMoins.Visible = false;
            }  
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int index = listView1.SelectedItems[0].Index;
            ProduitCommande produit = panierClient.produits[index];
            ProduitEnStock pStock = DB.Table<ProduitEnStock>().Where(p => p.id_produit == produit.id_produit).ToList()[0];
            if(pStock.quantite>produit.quantite)
            {
                produit.quantite += 1;
                listView1.SelectedItems[0].SubItems[4].Text = produit.quantite.ToString();
                labelQuantite.Text = "Quantité : " + produit.quantite;
                refreshPrixTotal();
            }
            else
            {
                labelRuptureStock.Visible = true;
            }
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            labelRuptureStock.Visible = false;
            int index = listView1.SelectedItems[0].Index;
            if(panierClient.produits[index].quantite > 1)
            {
                panierClient.produits[index].quantite -= 1;
                listView1.SelectedItems[0].SubItems[4].Text = panierClient.produits[index].quantite.ToString();
                labelQuantite.Text = "Quantité : " + panierClient.produits[index].quantite;
            }
            else
            {
                ConfirmationSupressionProduit sp = new ConfirmationSupressionProduit();
                if(sp.ShowDialog() == DialogResult.OK)
                {
                    panierClient.produits.Remove(panierClient.produits[index]);
                    refreshListPanier();
                    labelQuantite.Visible = false;
                    buttonPlus.Visible = false;
                    buttonMoins.Visible = false;
                }
            }

            refreshPrixTotal();
        }

        private void buttonAnnulerCommand_Click(object sender, EventArgs e)
        {
            ConfirmationAnnulerPanier cp = new ConfirmationAnnulerPanier();
            if(cp.ShowDialog() == DialogResult.OK)
            {
                this.Close();
                AccueilVente av = new AccueilVente(DB, magasin, user);
                av.Show();
            }
            
        }

        private void buttonFacture_Click(object sender, EventArgs e)
        {
            if(panierClient.client != null && panierClient.produits.Count > 0)
            {
                foreach(ProduitCommande produit in panierClient.produits)
                {
                    ProduitEnStock pStock = DB.GetAllWithChildren<ProduitEnStock>().Find(p => p.id_produit == produit.id_produit);
                    pStock.quantite -= produit.quantite;
                    Produit p = DB.GetWithChildren<Produit>(pStock.id_produit);
                    if(pStock.quantite == 0)
                    {
                        p.etat = EtatEnum.Rupture;
                    }
                    DB.UpdateWithChildren(p);
                    DB.UpdateWithChildren(pStock);
                    DB.UpdateWithChildren(produit);
                }

                labelErreur.Visible = false;
                DB.InsertWithChildren(panierClient);
                PopUpConfirmation pop = new PopUpConfirmation();
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                    AccueilVente av = new AccueilVente(DB, magasin, user);
                    av.Show();
                }
            }
            else
            {
                labelErreur.Visible = true;
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
