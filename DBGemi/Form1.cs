using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBGemi.Models;

namespace DBGemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                      

        }
        
        DBGemiContext c = new DBGemiContext();
        Ship s = new Ship();
        
        public void DBGemiList()
        {
            dataGridView1.DataSource = c.Ships.ToList();
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            DBGemiList();
            
        }

        Ek ek = new Ek();

       
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            
            int GemiId = Convert.ToInt32(textBoxGemiID.Text);
            string name = textBoxGemiAdi.Text;
            string country = textBoxÜlke.Text;
            string contact = textBoxİletisim.Text;
            string tel = textBoxTel.Text;
            ek.InsertGemi(name, country, contact, tel);
            DBGemiList();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            
            int GemiId = Convert.ToInt32(textBoxGemiID.Text);
            string name = textBoxGemiAdi.Text;
            string country = textBoxÜlke.Text;
            string contact = textBoxİletisim.Text;
            string tel = textBoxTel.Text;
            ek.DeleteGemi(GemiId);
            DBGemiList();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            int GemiId = Convert.ToInt32(textBoxGemiID.Text);
            string name = textBoxGemiAdi.Text;
            string country = textBoxÜlke.Text;
            string contact = textBoxİletisim.Text;
            string tel = textBoxTel.Text;
            ek.UpdateGemi(GemiId, name, country, contact, tel);
            DBGemiList();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxGemiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxGemiAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxÜlke.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxİletisim.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
