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
    public partial class Form5 : Form
    {
        public string Opschrift { get; set; }
        public Form5()
        {
            InitializeComponent();
        }

        private void btnAddBadge_Click(object sender, EventArgs e)
        {
            Opschrift = opschriftAdd.Text;
        }
    }
}
