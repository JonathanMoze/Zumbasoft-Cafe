using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZumbaSoft.Fenetres_Ventes
{
    public partial class buttonAnnulerCommande : Form
    {
        public buttonAnnulerCommande()
        {
            InitializeComponent();
            initChamps();
        }

        public void initChamps()
        {
            
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

            /**
            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
            */
        }
    }
}
