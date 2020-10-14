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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 計算ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnclc_Click(object sender, EventArgs e)
        {
            
            double money;
            int person;
            Calc calc = new Calc();

            money = int.Parse(txtTaxFree.Text);
            person = int.Parse(txtPerson.Text);

            money = (int)calc.OnePersonMoney(money,person);
            lblonePerson.Text = money + " 円";

            lblSplit.Text = (int)calc.Remainder(person) + " 円";
            
        }
    }
}
