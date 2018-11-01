using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * tsSeparator1.Width;     
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

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*"; 
            saveFileDialog.Title = "Зберегти дані у текстовому форматі"; 
            saveFileDialog.InitialDirectory = Application.StartupPath;

            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) { 
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8); 
                try { foreach (Car car in bindSrcTowns.List) { 
                    sw.Write(car.Name + "\t" + car.Marka + "\t" + car.Magaz + "\t" +
                        car.Age + "\t" + car.YearIncome + "\t" + car.Strahovka + "\t" + 
                        car.Credit + "\t" + car.CreditN + "\t\n"); 


                   
                } 
               } 
                catch (Exception ex) { 
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                } finally { 
                    sw.Close(); 
                } 
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.cars)|*.cars|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw; if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try
                {
                    foreach (Car car in bindSrcTowns.List)
                    {
                        bw.Write(car.Name);
                        bw.Write(car.Marka);
                        bw.Write(car.Magaz);
                        bw.Write(car.Age);
                        bw.Write(car.YearIncome);
                        bw.Write(car.YearIncome);
                        bw.Write(car.Strahovka);
                        bw.Write(car.Credit);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
             
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*"; 
            openFileDialog.Title = "Прочитати дані у текстовому форматі"; 
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Clear(); 
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8); 
                string s;

                try { while ((s = sr.ReadLine()) != null) { string[] split = s.Split('\t'); 
                    Car car = new Car(split[0], split[1], split[2], double.Parse(split[3]), double.Parse(split[4]), bool.Parse(split[5]), bool.Parse(split[6]), double.Parse(split[7])); 
                    bindSrcTowns.Add(car); 
                } }
                catch (Exception ex) { 
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                finally { sr.Close(); }
            } 
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Файли даних (*.cars)|*.cars|All files (*.*)|*.*"; 
            openFileDialog.Title = "Прочитати дані у бінарному форматі"; 
            openFileDialog.InitialDirectory = Application.StartupPath; 
            BinaryReader br; 
            if (openFileDialog.ShowDialog() == DialogResult.OK) {     
                bindSrcTowns.Clear();     
                br = new BinaryReader(openFileDialog.OpenFile());     
                try{         
                    Car car;         
                    while (br.BaseStream.Position < br.BaseStream.Length){ 
                        car = new Car();             
                        for (int i = 1; i <= 8; i++){                 
                            switch (i){                     
                                case 1:                         
                                    car.Name = br.ReadString();                         
                                    break;                     
                                case 2:                         
                                    car.Marka = br.ReadString();                         
                                    break;                     
                                case 3:                         
                                    car.Magaz = br.ReadString();                         
                                    break;                     
                                case 4:                         
                                    car.Age = br.ReadDouble();                         
                                    break;                     
                                case 5:                         
                                    car.YearIncome = br.ReadDouble();                         
                                    break;                     
                                case 6:                         
                                    car.Strahovka = br.ReadBoolean();                        
                                    break;                     
                                case 7:                         
                                    car.Credit = br.ReadBoolean();                         
                                    break;                     
                                case 8:                   
                                    car.CreditN = br.ReadDouble();                       
                                    break;                 
                            }           
                        }             
                        bindSrcTowns.Add(car);         
                    }     
                } catch (Exception ex){         
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,MessageBoxButtons.OK, MessageBoxIcon.Error);     
                } finally {         
                    br.Close();     
                }   
            } 
        } 
        
    }
}
