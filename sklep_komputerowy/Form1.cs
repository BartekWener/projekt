using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sklep_komputerowy
{
    public partial class Form1 : Form
    {
        private readonly object polaczenie;

        public Form1()
        {
            InitializeComponent();
            połączenieBaza.Text = "Połączono z Bazą";
        }
       
        

        private void połączenieBaza_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Close();
        }
    }
}
