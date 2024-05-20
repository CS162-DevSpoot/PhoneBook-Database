using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS162_Formbook
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'phoneListDataSet1.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter1.Fill(this.phoneListDataSet1.Person);
            // TODO: This line of code loads data into the 'phoneListDataSet.Person' table. You can move, or remove it, as needed.

        }
    }
}
