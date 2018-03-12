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
    public partial class FORMULAIRE_SERVICE_RENSEIGNEMENT : Form
    {
        public FORMULAIRE_SERVICE_RENSEIGNEMENT()
        {
            InitializeComponent();
        }

        public OleDbCommand Cmd;
        public OleDbConnection con;



        private void chargementdatagrid()
        {

            OleDbDataAdapter adp = new OleDbDataAdapter("select * from service renseignement", con);
            BindingSource b = new BindingSource();
            DataTable data = new DataTable();
            adp.Fill(data);
            adp.FillSchema(data, SchemaType.Source);
            b.DataSource = data;
            table.DataSource = b;
            numserv.DataBindings.Add("Text", b, "NumeroServ");
            heur.DataBindings.Add("Text", b, "HeureRens");
           
        }
        private void chargementdatagrid(string code)
        {
            Cmd = con.CreateCommand();
            Cmd.CommandText = "select * from service renseignement where numserv like '" + code + "%'";
            OleDbDataReader dr = Cmd.ExecuteReader();

            while (dr.Read())
            {
                numserv.Text = dr.GetString(1);
                heur.Text = Convert.ToString(dr.GetInt32(2));
            }
            dr.Close();
        }

       /* private void insertBD() {
            string samy = "insert into servicerenseignement values(@num_serv,@date_rens,@heure_rens,@nom_mal);";

            try
            {
                Cmd = con.CreateCommand();
                Cmd.CommandText = samy;
                Cmd.Parameters.AddWithValue("@num_serv", numserv.Text);
                Cmd.Parameters.AddWithValue("@date_rens", dp1.Value);
                Cmd.Parameters.AddWithValue("@heure_rens", int.Parse(heur.Text));
                Cmd.Parameters.AddWithValue("@nom_mal", nomma.Text);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Bonne insertion ");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
}
*/
        private void FORMULAIRE_SERVICE_RENSEIGNEMENT_Load(object sender, EventArgs e)
        {

           /* string bobo = "";
            OleDbCommand Cmd;
            string sams = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:/SAMY/Documents/santewelcome.mdb";
            con = new OleDbConnection(sams);
            con.Open();
        chargementdatagrid();
        */
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numserv.ResetText();
            nomma.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chargementdatagrid();
        }
    }
}

