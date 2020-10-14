using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnclc_Click(object sender, EventArgs e)
        {
            double money;
            int person;
            double addTax;
            const double tax = 0.08;

            money = int.Parse(txtTaxFree.Text);
            person = int.Parse(txtPerson.Text);
            addTax = money*(1 + tax);
            double onePersonMoney =addTax / person;

            money = (int)onePersonMoney;
            lblonePerson.Text = money + " 円";

            double remainder = addTax % person;
            lblSplit.Text = (int)remainder + " 円";
            
        }
    }
}
