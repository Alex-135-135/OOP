using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Перетворення текстових рядків, які ввів користувач,  
            // у змінні числового типу 
            double x1min = double.Parse(tbx1min.Text); 
            double x1max = double.Parse(tbx1max.Text); 
            double x2min = double.Parse(tbx2min.Text); 
            double x2max = double.Parse(tbx2max.Text); 
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);

            // Обчислення кількості рядків та стовпчиків таблиці 
            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 2; 
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;
           
            // Вивід заголовків рядків та стовпців таблиці 
            for (int i = 0; i < gv.RowCount - 1; i++)     
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000"); 
            gv.RowHeadersWidth = 80; 
            for (int i = 0; i < gv.ColumnCount - 1; i++) { 
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000"); 
                gv.Columns[i].Width = 60; 
            }
            gv.Rows[gv.RowCount - 1].HeaderCell.Value = string.Format("Сума");
            gv.Columns[gv.ColumnCount - 1].HeaderCell.Value = string.Format("Сума");

            // Для автоматичного підлаштування розмірів стовпчиків та рядків  
            // можна використовувати ці методи 
            //gv.AutoResizeColumns(); 
            //gv.AutoResizeRows(); 

            int cl, rw; 
            double x1, x2, y, s = 0;

            // Розрахунок і вивід результатів 
            rw = 0; x1 = x1min; 
            while (x1 <= x1max) { 
                x2 = x2min; cl = 0;
                double cv = 0;
                while (x2 <= x2max) { 
                    //y = x1 + x2; 
                    y = 23 * Math.Pow(Math.Cos(Math.Pow(x1,3) * Math.Pow(x2,5)),2) + 2 * x1;
                    if (Math.Sin(y) < 0) {
                        s += Math.Sin(y);  
                    }
                    cv += y;
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    
                    x2 += dx2; cl++; 
                } 
                gv.Rows[rw].Cells[gv.ColumnCount - 1].Value = cv.ToString("0.000"); 
                x1 += dx1; rw++;
                tbsin.Text = s.ToString("0.000");
            }

            //double balans = 0;
            int ol = 0;
            while(ol < gv.ColumnCount - 1){
                double balans = 0;
                gv.Rows[gv.RowCount - 1].Cells[ol].Value = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    double incom = 0;
                    double.TryParse((row.Cells[ol].Value ?? "0").ToString().Replace(".", ","), out incom);
                    balans += incom;
                    //gvcolum.Rows[rw].Cells[0].Value = bal.ToString("0.000"); 
                }
                gv.Rows[gv.RowCount - 1].Cells[ol].Value = balans.ToString("0.000"); 
                balans = 0;
                ol++;
        }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = ""; 
            tbx1max.Text = ""; 
            tbx2min.Text = ""; 
            tbx2max.Text = ""; 
            tbdx1.Text = ""; 
            tbdx2.Text = "";

            gv.Rows.Clear(); 
            for (int Cl = 0; Cl < gv.ColumnCount; Cl++) 
                gv.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
