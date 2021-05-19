using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventariere
{
    public partial class Form1 : Form
    {
        SQL sqlComenzi = new SQL();       
        string[] criteria = { "is not null", "is not null", "is not null", "is not null" };

        public Form1()
        {
            InitializeComponent();
            loadCB();
        }
        private void cb_CatBun_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> a = sqlComenzi.SQL_loadData("select distinct([CONT]) from conturi WHERE [Categorie bunuri] " + criteria[0] );
            ts_cb_cont.Items.Clear();
            ts_cb_cont.Items.Add("Toate");
            foreach (var item in a)
                ts_cb_cont.Items.Add(item);
        }

        void loadCB()
        {
            List<string> a =sqlComenzi.SQL_loadData("select distinct([Categorie bunuri]) from conturi");
            ts_cb_CatBun.Items.Clear();
            ts_cb_CatBun.Items.Add("Toate");
            foreach (var item in a)
                ts_cb_CatBun.Items.Add(item);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new Inregistrare_bunuri().Show();
        }

        private void ts_tb_NI_TextChanged_1(object sender, EventArgs e)
        {
            if (ts_cb_CatBun.Text != "Toate" && ts_cb_CatBun.Text != "")
                criteria[0] = " = '" + ts_cb_CatBun.Text + "'";
            else
                criteria[0] = " is not null ";

            if (ts_cb_cont.Text != "Toate" && ts_cb_cont.Text != "")
                criteria[1] = " = '" + ts_cb_cont.Text + "'";
            else
                criteria[1] = " is not null ";

            if (ts_tb_NI.Text != "")
                criteria[2] = " like '%" + ts_tb_NI.Text + "%'";
            else
                criteria[2] = " is not null ";

            if (ts_tb_Den.Text != "")
                criteria[3] = " like '%" + ts_tb_Den.Text + "%'";
            else
                criteria[3] = " is not null ";

            dataGridView1.DataSource = sqlComenzi.getData("select * from Documente " +
               " where  [categorie bunuri] " + criteria[0] +
               " and [cont] " + criteria[1] +
               " and [Numar inventar] " + criteria[2] +
               " and [Denumire] " + criteria[3]);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ts_cb_CatBun.Text = "";
            ts_cb_cont.Text = "";
            ts_tb_NI.Text = "";
            ts_tb_Den.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
