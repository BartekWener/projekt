using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sklep_komputerowy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            SqlConnection polaczenie = new SqlConnection();
          polaczenie.ConnectionString = "Data Source=PC\\SQLEXPRESS;Initial Catalog=sklep;Integrated Security=True;"; //ciąg połączeniowy
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            try
            {
                polaczenie.Open();
           
               

            }
            catch (System.Data.SqlClient.SqlException se)
            {
                MessageBox.Show("BŁĄD: " + se.StackTrace);
            }
            finally
            {
                if (polaczenie.State == System.Data.ConnectionState.Open)
                {
                    polaczenie.Close();
                    
                }
            }
        }
    }
}
