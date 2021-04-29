using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMetDataBase
{
    public partial class Form2 : Form
    {

        public int Leeftijd { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }


        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Leeftijd = Convert.ToInt32(leeftijdAdd.Value);
            Voornaam = voornaamAdd.Text;
            Achternaam = achternaamAdd.Text;
        }
    }
}
