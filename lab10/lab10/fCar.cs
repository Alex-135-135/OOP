using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class fCar : Form
    {
        public Car TheCar;

        public fCar(Car f)
        {
            TheCar = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheCar != null)
            {
                tbName.Text = TheCar.Name;
                tbMarka.Text = TheCar.Marka;
                tbMagaz.Text = TheCar.Magaz;
                tbAge.Text = TheCar.Age.ToString();
                tbYearIncome.Text = TheCar.YearIncome.ToString();
                chbCredit.Checked = TheCar.Credit;
                chbStrahovka.Checked = TheCar.Strahovka;
                tbCreditN.Text = TheCar.CreditN.ToString();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheCar.Name = tbName.Text.Trim();
            TheCar.Marka = tbMarka.Text.Trim();
            TheCar.Magaz = tbMagaz.Text.Trim();
            TheCar.Age = int.Parse(tbAge.Text.Trim());
            TheCar.YearIncome = double.Parse(tbYearIncome.Text.Trim());
            TheCar.Credit = chbCredit.Checked;
            TheCar.Strahovka = chbStrahovka.Checked;
            if (TheCar.Credit)
            {
                if (int.Parse(tbCreditN.Text.Trim()) > 5 && TheCar.Credit)
                {
                    TheCar.CreditN = int.Parse(tbCreditN.Text.Trim());
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Кількість місяців по кредиту повинно бути більше 5?", "Помилка", MessageBoxButtons.OK);
                }
            }
            else {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chbStrahovka_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbCredit_CheckedChanged(object sender, EventArgs e)
        {
            tbCreditN.ReadOnly = !tbCreditN.ReadOnly;
        }

        private void tbCreditN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
