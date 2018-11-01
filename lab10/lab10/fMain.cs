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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30; 
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0); 
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvCars.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn(); column.DataPropertyName = "Name"; column.Name = "Назва"; gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name"; 
            column.Name = "Назва автомобіля"; gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Marka"; 
            column.Name = "Марка автомобіля"; 
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Magaz";
            column.Name = "Назва магазину"; 
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Кількість років автомобілю";
            column.Width = 130;
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "Ціна автомобіля, грн"; 
            column.Width = 120; 
            gvCars.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Strahovka"; 
            column.Name = "Страховка"; 
            column.Width = 80; 
            gvCars.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Credit"; 
            column.Name = "Кредит"; 
            column.Width = 60; 
            gvCars.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "GetPrice";
            column.Name = "Місячна плата по кредиту, грн";
            column.Width = 200;
            gvCars.Columns.Add(column);

            //bindSrcTowns.Add(new Car("Львів", "Україна", "Львівська обл.", 800000, 2000000, 400, false, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car town = new Car();

            fCar ft = new fCar(town); 
            if (ft.ShowDialog() == DialogResult.OK) { 
                bindSrcTowns.Add(town); 
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Car town = (Car)bindSrcTowns.List[bindSrcTowns.Position];

            fCar ft = new fCar(town); 
            if (ft.ShowDialog() == DialogResult.OK) { 
                bindSrcTowns.List[bindSrcTowns.Position] = town; 
            } 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) { 
                bindSrcTowns.RemoveCurrent(); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { 
                bindSrcTowns.Clear(); 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) { 
                Application.Exit(); 
            }
        }
    }
}
