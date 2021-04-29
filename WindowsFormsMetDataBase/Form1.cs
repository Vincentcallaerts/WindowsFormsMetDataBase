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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
            {

                listBox1.Items.AddRange(data.Customers.Select(c => c.first_name).ToArray());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2())
            {

                switch (form2.ShowDialog())
                {
                    case DialogResult.OK:

                        using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
                        {
                            data.Customers.Add(new Customer() { first_name = form2.Voornaam, last_name = form2.Achternaam, age = form2.Leeftijd });
                            data.SaveChanges();

                            listBox1.Items.Clear();
                            listBox1.Items.AddRange(data.Customers.Select(c => c.first_name).ToArray());
                        }

                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {

                switch (form3.ShowDialog())
                {
                    case DialogResult.Yes:

                        using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
                        {
                            data.Customers.Remove(data.Customers.FirstOrDefault(c => c.id == form3.Id));
                            data.SaveChanges();


                            listBox1.Items.Clear();
                            listBox1.Items.AddRange(data.Customers.Select(c => c.first_name).ToArray());
                        }

                        break;
                    case DialogResult.OK:

                        using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
                        {
                            data.Customers.FirstOrDefault(c => c.id == form3.Id).first_name = form3.Voornaam;
                            data.Customers.FirstOrDefault(c => c.id == form3.Id).last_name = form3.Achternaam;
                            data.Customers.FirstOrDefault(c => c.id == form3.Id).age = form3.Leeftijd;


                            data.SaveChanges();


                            listBox1.Items.Clear();
                            listBox1.Items.AddRange(data.Customers.Select(c => c.first_name).ToArray());
                        }

                        break;
                }
            }
        }

        private void btnAddBadge_Click(object sender, EventArgs e)
        {
            using (Form4 form4 = new Form4())
            {

                switch (form4.ShowDialog())
                {
                    case DialogResult.OK:

                        using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
                        {
                            data.CustomerBadges.Add(new CustomerBadge { BadgeId = form4.BadgeId, CustomerId = form4.PersoonId });

                            listBox1.Items.Clear();
                            listBox1.Items.AddRange(data.Customers.Select(c => c.first_name).ToArray());
                        }

                        break;
                }
            }
        }
    }
}
