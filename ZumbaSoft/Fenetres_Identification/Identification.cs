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
    }
}
