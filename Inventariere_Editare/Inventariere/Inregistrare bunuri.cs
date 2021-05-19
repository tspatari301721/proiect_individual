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
    public partial class Inregistrare_bunuri : Form
    {
        SQL sqlComenzi = new SQL();
        public Inregistrare_bunuri()
        {
            InitializeComponent();

            List<string> a = sqlComenzi.SQL_loadData("select distinct([CONT]) from conturi ");
            cb_cont1.Items.Clear();

           
            foreach (var item in a)
                cb_cont1.Items.Add(item);

            cb_cont1.Items.Add("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlComenzi.SQLinsert("insert into documente ([Data intrarii in stoc],cont,[Numar inventar],[Denumire],Pret,Cantitate,Factura,Gestionar,[categorie bunuri])" +
                "values(" +
                "'"+data_intrarii_in_stocDateTimePicker.Text+"'"+
                 ",'"+cb_cont1.Text+"'" +
                  ",'"+numar_inventarTextBox.Text+"'" +
                   ",'"+denumireTextBox.Text+"'" +
                    ",'"+pretTextBox.Text+"'" +
                     ",'"+cantitateNumericUpDown.Text+"'" +
                      ",'"+facturaTextBox.Text+"'" +
                      ",'" + gestionarTextBox.Text +
                       "',(select distinct([categorie bunuri]) from conturi where cont ='"+cb_cont1.Text+"'))");
                       
            label1.Text = "Ati adaugat inregistrarea cu succes; ";

            cb_cont1.SelectedIndex = 10;
            numar_inventarTextBox.Text = "";
            denumireTextBox.Text = "";
            pretTextBox.Text = "";
            cantitateNumericUpDown.Text = "";
            facturaTextBox.Text = "";
            gestionarTextBox.Text = "";

           
        }

        private void Inregistrare_bunuri_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
