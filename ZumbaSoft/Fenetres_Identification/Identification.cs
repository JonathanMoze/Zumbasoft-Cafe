using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Extensions;

namespace ZumbaSoft.Fenetres_Identification
{
    public partial class Identification : Form
    {
        SQLiteConnection database;
        public Identification(SQLiteConnection db)
        {
            InitializeComponent();
            database = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
