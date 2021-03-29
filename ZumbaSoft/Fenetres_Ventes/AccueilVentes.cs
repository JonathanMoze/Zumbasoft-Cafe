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
        SQLiteConnection DB;
        public Client client;
        List<Produit> panier;
        
        public AccueilVente(SQLiteConnection db)
        {
            InitializeComponent();
            DB = db;
            panier = new List<Produit>();
            initListClients();
        }


        public void initListClients()
        {
            listBox1RechercheClient.Items.Clear();
            foreach(Client c in DB.GetAllWithChildren<Client>())
            {
                listBox1RechercheClient.Items.Add(c);
            }
        }


        private void AccueilVentes_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Code Barre", 90);
            listView1.Columns.Add("Nom du produit", 150);
            listView1.Columns.Add("Prix HT", 70);
            listView1.Columns.Add("Prix TTC", 70);
            listView1.Columns.Add("Quantité", 70);

            /*
            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);


            string[] arr2 = new string[4];
            ListViewItem itm2;

            //Add first item
            arr2[0] = "product_2";
            arr2[1] = "1500";
            arr2[2] = "1210";
            arr2[3] = "10";
            itm2 = new ListViewItem(arr2);
            listView1.Items.Add(itm2);
            */
        }


        public void refreshPanier()
        {
            foreach(Produit p in panier)
            {
                string[] arr = new string[5];
                ListViewItem lst;

                arr[0] = p.code_barre.ToString();
                arr[1] = p.nom;
                arr[2] = p.prix_vente_HT.ToString();
                arr[3] = p.prix_vente_TTC.ToString();
                arr[4] = "1";

                lst = new ListViewItem(arr);
                listView1.Items.Add(lst);
            }
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
            client = (Client)listBox1RechercheClient.SelectedItem;
            labelNomClient.Text = client.ToString();
        }

        private void buttonCatalogueProd_Click(object sender, EventArgs e)
        {
            RechercheProduit rp = new RechercheProduit(DB);
            if(rp.ShowDialog() == DialogResult.OK)
            {
                Produit selectedProduit = rp.selectedPRoduit;
                panier.Add(selectedProduit);
                refreshPanier();
            }
        }
    }
}
