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
    public partial class Form4 : Form
    {

        public int PersoonId { get; set; }
        public int BadgeId { get; set; }
        public Form4()
        {

            InitializeComponent();
            using (DatabaseFirstOefEntitiess data = new DatabaseFirstOefEntitiess())
            {
                var collectionPersonen = data.Customers.Select(c => new { Id = c.id, Name = c.first_name + " " + c.last_name }).ToArray();

                cbPersonen.DataSource = collectionPersonen;
                cbPersonen.DisplayMember = "Name";
                cbPersonen.ValueMember = "Id";

                var collectionBadges = data.Badges.Select(b => new {Id = b.Id, Opschrift = b.Opschrift}).ToArray();
                cbBadge.DataSource = collectionBadges;
                cbBadge.DisplayMember = "Opschrift";
                cbBadge.ValueMember = "Id";
            }
        }

        private void btnAddBadge_Click(object sender, EventArgs e)
        {
            PersoonId = Convert.ToInt32(cbPersonen.SelectedValue);
            BadgeId = Convert.ToInt32(cbBadge.SelectedValue);
        }
    }
}
