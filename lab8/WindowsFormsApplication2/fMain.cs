using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            fCar ft = new fCar(car);

            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbCarsInfo.Text += string.Format("Назва автомобіля: {0}, Марка автомобіля: {1}, Назва магазину: {2}, Кількість років автомобілю: {3}, Ціна автомобіля: {4} грн, {5}, {6}, {7}\r\n",
                car.Name,
                car.Marka,
                car.Magaz,
                car.Age,
                car.YearIncome,

                car.Strahovka ? "Є страховка" : "Немає страховки",
                car.Credit ? "Кредит можливий" : "Кредит неможливий",

                car.GetPrice());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
