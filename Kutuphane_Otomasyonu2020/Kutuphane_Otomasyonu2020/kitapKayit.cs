﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane_Otomasyonu2020
{
    public partial class kitapKayit : Form
    {
        SqlConnection baglanti;
        Connect con = new Connect();
        public kitapKayit()
        {
            baglanti = new SqlConnection(con.adres);
            InitializeComponent();
        }

        private void kitapKayit_Load(object sender, EventArgs e)
        {

        }
    }
}