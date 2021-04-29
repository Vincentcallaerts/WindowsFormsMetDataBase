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
    public partial class Form3 : Form
    {
        public int Id { get; set; }
        public int Leeftijd { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public Form3()
        {
            InitializeComponent();
            using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
            {
                var collection = data.Customers.Select(c => new { Id = c.id, Name = c.first_name + " " + c.last_name}).ToArray();

                cbPersonen.DataSource = collection;
                cbPersonen.DisplayMember = "Name";
                cbPersonen.ValueMember = "Id";
            }
        }

        private void btnBewerkUser_Click(object sender, EventArgs e)
        {
            Leeftijd = Convert.ToInt32(leeftijdAdd.Value);
            Voornaam = voornaamAdd.Text;
            Achternaam = achternaamAdd.Text;
            Id = Convert.ToInt32(cbPersonen.SelectedValue);

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(cbPersonen.SelectedValue);
        }
    }
}
