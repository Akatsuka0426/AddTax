using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            // 変数および定数の宣言
            int money;
            double addTax;
            const double Tax = 0.1;

            // 「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxMoney.Text);

            // 消費税の加算および税込み価格の計算
            addTax = money;
            addTax *= (1 + Tax);
            money = (int)addTax;

            // 税込価格の表示
            labelAddTax.Text = money + " 円";
        }
    }
}
