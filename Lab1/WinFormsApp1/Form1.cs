using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox_line.Image = Image.FromFile("line.png");
            pictureBox_car.Image = Image.FromFile("car.png");
            // установка обработчика события Scroll
            trackBar_clearance.Scroll += trackBar_clearance_Scroll;
            timerProgressBar.Start();
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_enter_name_TextChanged(object sender, EventArgs e)
        {
            label_nameplate_main.Text = textBox_enter_name.Text;
        }


        private void numericUpDown_region_ValueChanged(object sender, EventArgs e)
        {
            label_region.Text = numericUpDown_region.Text;
        }

        private void linkLabel_winomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ссылка на страницу
            string path = @"D:/number.png";
            //переход по ссылке
            System.Diagnostics.Process.Start(path);
            //цвет ссылки окрашивается в заданный цвет, отличный от цвета не посещённой ссылки
            this.linkLabel_winomer.LinkVisited = true;
        }

        private void checkBox_rastamozhena_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Машина растаможена");
        }
        private void trackBar_clearance_Scroll(object sender, EventArgs e)
        {
            progressBar_clearance.Value = trackBar_clearance.Value;
            label5.Text = String.Format("Текущее значение: {0} см", trackBar_clearance.Value);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label_CoordX.Text = e.X.ToString();
            label_CoordY.Text = e.Y.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Location = new System.Drawing.Point(e.X - btn.Size.Width/2, e.Y - btn.Size.Height / 2);
            btn.Name = "button_exit";
            btn.Size = new System.Drawing.Size(94, 29);
            btn.TabIndex = 0;
            btn.Text = "EXIT!!!";
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(this.button_exit_Click);

            this.Controls.Add(btn);
        }


        private void comboBox_kpp_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox_kpp.Text;
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawEllipse(Pens.Red, 500, 550, 200, 200);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            treeView1.Nodes.Add(e.Start.ToLongDateString());
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            
            if (progressBarTime.Value == progressBarTime.Maximum)
            {
                timerProgressBar.Interval = 100;
                progressBarTime.Value = 0;
            }
            
            progressBarTime.PerformStep();
            if (progressBarTime.Value == progressBarTime.Maximum)
            {
                timerProgressBar.Interval = 500;
            }


        }

        ///


    }
}