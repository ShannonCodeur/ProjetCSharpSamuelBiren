using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace aplisantewelcome
{
    public partial class FORMULAIRE_MALADE : Form
    {
        public FORMULAIRE_MALADE()
        {
            InitializeComponent();
            chargementdatagrid();
        }

        public OleDbCommand Cmd;
        public OleDbConnection con;
        public BindingSource b = new BindingSource();

        private void chargementdatagrid()
        {
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from malade", con);
            b = new BindingSource();
            DataTable data = new DataTable();
            adp.Fill(data);
            adp.FillSchema(data, SchemaType.Source);
            b.DataSource = data;
            table.DataSource = b;
            txtment.DataBindings.Add("Text", b, "MENTION");
            txttel.DataBindings.Add("Text", b, "TELEPHONE");
            txtad.DataBindings.Add("Text", b, "ADRESSMAIL");





        }

        public void insertBDaccess()
        {

            string bobo = "insert into malade values(@nom_mal,@age,@group_sang,@quartier,@mention,@adresseMail,@tel);";

            try
            {
                Cmd = con.CreateCommand();
                Cmd.CommandText = "";
                Cmd.Connection= Program.con;
                Cmd.Parameters.AddWithValue("@nom_mal", txtnom.Text);
                Cmd.Parameters.AddWithValue("@age", dp.Value);
                Cmd.Parameters.AddWithValue("@group_sang", txtgr.Text);
                Cmd.Parameters.AddWithValue("@quartier", txtqr.Text);
                Cmd.Parameters.AddWithValue("@mention", txtment.Text);
                Cmd.Parameters.AddWithValue("@quartier", txtqr.Text);
                Cmd.Parameters.AddWithValue("@adresseMail", int.Parse(txtad.Text));
                Cmd.Parameters.AddWithValue("@tel", int.Parse(txttel.Text));
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Bonne insertion ");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void chargementdatagrid(string code)
        {
            Cmd = con.CreateCommand();
            Cmd.CommandText = "select from * malade where txtnom like '" + code + "%'";
            OleDbDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                txtment.Text = dr.GetString(1);
                txttel.Text = Convert.ToString(dr.GetInt32(2));
                txtad.Text = dr.GetString(3);

            }
            dr.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FORMULAIRE_MALADE_Load(object sender, EventArgs e)
        {
            string bobo = "";
            OleDbCommand Cmd;
            //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\SAMY\Documents\santewelcome1.mdb
            string sams = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/toro/santewelcome1.mdb";
            con = new OleDbConnection(sams);
           // con.Open();
            MessageBox.Show("bonne connexion");
       

           
            //chargementdatagrid();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnom.ResetText();
            txtad.ResetText();
            txtgr.ResetText();
            txtment.ResetText();
            txtqr.ResetText();
            dp.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insertBDaccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b.AddNew();
        }
    }
}
