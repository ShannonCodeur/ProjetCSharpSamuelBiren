using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
    namespace aplisantewelcome
{
    static class Program
    {
        //Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/toro/santewelcome1.mdb
        public static string sams = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/toro/santewelcome1.mdb";
        public static OleDbConnection con=new OleDbConnection(sams);
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                con.Open();

                //Application.Run(new FORMULAIRE_MALADE());
                Application.Run(new FORMULAIRE_SERVICE_RENSEIGNEMENT());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
