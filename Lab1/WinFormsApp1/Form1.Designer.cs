namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_enter_name = new System.Windows.Forms.TextBox();
            this.pictureBox_line = new System.Windows.Forms.PictureBox();
            this.label_nameplate_main = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown_region = new System.Windows.Forms.NumericUpDown();
            this.linkLabel_winomer = new System.Windows.Forms.LinkLabel();
            this.label_region = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_rastamozhena = new System.Windows.Forms.CheckBox();
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.comboBox_kpp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar_clearance = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar_clearance = new System.Windows.Forms.ProgressBar();
            this.label_CoordX = new System.Windows.Forms.Label();
            this.label_CoordY = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_region)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_clearance)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(584, 542);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(82, 22);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите Номерной Знак:";
            // 
            // textBox_enter_name
            // 
            this.textBox_enter_name.Location = new System.Drawing.Point(191, 7);
            this.textBox_enter_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_enter_name.Name = "textBox_enter_name";
            this.textBox_enter_name.Size = new System.Drawing.Size(110, 23);
            this.textBox_enter_name.TabIndex = 3;
            this.textBox_enter_name.TextChanged += new System.EventHandler(this.textBox_enter_name_TextChanged);
            // 
            // pictureBox_line
            // 
            this.pictureBox_line.Location = new System.Drawing.Point(342, 9);
            this.pictureBox_line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_line.Name = "pictureBox_line";
            this.pictureBox_line.Size = new System.Drawing.Size(14, 555);
            this.pictureBox_line.TabIndex = 4;
            this.pictureBox_line.TabStop = false;
            // 
            // label_nameplate_main
            // 
            this.label_nameplate_main.AutoSize = true;
            this.label_nameplate_main.BackColor = System.Drawing.Color.White;
            this.label_nameplate_main.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nameplate_main.ForeColor = System.Drawing.Color.Black;
            this.label_nameplate_main.Location = new System.Drawing.Point(535, 10);
            this.label_nameplate_main.Name = "label_nameplate_main";
            this.label_nameplate_main.Size = new System.Drawing.Size(90, 26);
            this.label_nameplate_main.TabIndex = 6;
            this.label_nameplate_main.Text = "             ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(164, 409);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // numericUpDown_region
            // 
            this.numericUpDown_region.Location = new System.Drawing.Point(191, 37);
            this.numericUpDown_region.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_region.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_region.Name = "numericUpDown_region";
            this.numericUpDown_region.Size = new System.Drawing.Size(109, 23);
            this.numericUpDown_region.TabIndex = 8;
            this.numericUpDown_region.ValueChanged += new System.EventHandler(this.numericUpDown_region_ValueChanged);
            // 
            // linkLabel_winomer
            // 
            this.linkLabel_winomer.AutoSize = true;
            this.linkLabel_winomer.Location = new System.Drawing.Point(418, 7);
            this.linkLabel_winomer.Name = "linkLabel_winomer";
            this.linkLabel_winomer.Size = new System.Drawing.Size(96, 15);
            this.linkLabel_winomer.TabIndex = 10;
            this.linkLabel_winomer.TabStop = true;
            this.linkLabel_winomer.Text = "Номерной знак:";
            this.linkLabel_winomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_winomer_LinkClicked);
            // 
            // label_region
            // 
            this.label_region.AutoSize = true;
            this.label_region.BackColor = System.Drawing.Color.White;
            this.label_region.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label_region.Location = new System.Drawing.Point(640, 10);
            this.label_region.Name = "label_region";
            this.label_region.Size = new System.Drawing.Size(22, 24);
            this.label_region.TabIndex = 11;
            this.label_region.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите Регион:";
            // 
            // checkBox_rastamozhena
            // 
            this.checkBox_rastamozhena.AutoSize = true;
            this.checkBox_rastamozhena.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_rastamozhena.Location = new System.Drawing.Point(10, 69);
            this.checkBox_rastamozhena.Name = "checkBox_rastamozhena";
            this.checkBox_rastamozhena.Size = new System.Drawing.Size(102, 19);
            this.checkBox_rastamozhena.TabIndex = 13;
            this.checkBox_rastamozhena.Text = "Растаможена";
            this.checkBox_rastamozhena.UseVisualStyleBackColor = true;
            this.checkBox_rastamozhena.CheckedChanged += new System.EventHandler(this.checkBox_rastamozhena_CheckedChanged);
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.ImageLocation = "";
            this.pictureBox_car.Location = new System.Drawing.Point(418, 51);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_car.TabIndex = 14;
            this.pictureBox_car.TabStop = false;
            // 
            // comboBox_kpp
            // 
            this.comboBox_kpp.FormattingEnabled = true;
            this.comboBox_kpp.Items.AddRange(new object[] {
            "Автоматическая",
            "Механическая",
            "Вариатор",
            "Робот"});
            this.comboBox_kpp.Location = new System.Drawing.Point(190, 95);
            this.comboBox_kpp.Name = "comboBox_kpp";
            this.comboBox_kpp.Size = new System.Drawing.Size(110, 23);
            this.comboBox_kpp.TabIndex = 15;
            this.comboBox_kpp.SelectedIndexChanged += new System.EventHandler(this.comboBox_kpp_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Выберите КПП:";
            // 
            // trackBar_clearance
            // 
            this.trackBar_clearance.LargeChange = 1;
            this.trackBar_clearance.Location = new System.Drawing.Point(190, 181);
            this.trackBar_clearance.Maximum = 20;
            this.trackBar_clearance.Minimum = 10;
            this.trackBar_clearance.Name = "trackBar_clearance";
            this.trackBar_clearance.Size = new System.Drawing.Size(110, 45);
            this.trackBar_clearance.TabIndex = 17;
            this.trackBar_clearance.Value = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Укажите клиренс:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(190, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Текущее значение:";
            // 
            // progressBar_clearance
            // 
            this.progressBar_clearance.Location = new System.Drawing.Point(196, 151);
            this.progressBar_clearance.Maximum = 20;
            this.progressBar_clearance.Minimum = 10;
            this.progressBar_clearance.Name = "progressBar_clearance";
            this.progressBar_clearance.Size = new System.Drawing.Size(100, 23);
            this.progressBar_clearance.Step = 1;
            this.progressBar_clearance.TabIndex = 20;
            this.progressBar_clearance.Value = 10;
            // 
            // label_CoordX
            // 
            this.label_CoordX.AutoSize = true;
            this.label_CoordX.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CoordX.Location = new System.Drawing.Point(592, 173);
            this.label_CoordX.Name = "label_CoordX";
            this.label_CoordX.Size = new System.Drawing.Size(33, 45);
            this.label_CoordX.TabIndex = 21;
            this.label_CoordX.Text = "_";
            // 
            // label_CoordY
            // 
            this.label_CoordY.AutoSize = true;
            this.label_CoordY.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_CoordY.Location = new System.Drawing.Point(592, 214);
            this.label_CoordY.Name = "label_CoordY";
            this.label_CoordY.Size = new System.Drawing.Size(33, 45);
            this.label_CoordY.TabIndex = 22;
            this.label_CoordY.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(536, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Выбранная коробка";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(372, 409);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(133, 92);
            this.treeView1.TabIndex = 24;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(196, 378);
            this.progressBarTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarTime.MarqueeAnimationSpeed = 0;
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(109, 22);
            this.progressBarTime.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 578);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_CoordY);
            this.Controls.Add(this.label_CoordX);
            this.Controls.Add(this.progressBar_clearance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar_clearance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_kpp);
            this.Controls.Add(this.pictureBox_car);
            this.Controls.Add(this.checkBox_rastamozhena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_region);
            this.Controls.Add(this.linkLabel_winomer);
            this.Controls.Add(this.numericUpDown_region);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_nameplate_main);
            this.Controls.Add(this.pictureBox_line);
            this.Controls.Add(this.textBox_enter_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Добавить авто в базу";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_region)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_clearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_exit;
        private Label label1;
        private TextBox textBox_enter_name;
        private PictureBox pictureBox_line;
        private Label label_nameplate_main;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown_region;
        private LinkLabel linkLabel_winomer;
        private Label label_region;
        private Label label2;
        private CheckBox checkBox_rastamozhena;
        private PictureBox pictureBox_car;
        private ComboBox comboBox_kpp;
        private Label label3;
        private TrackBar trackBar_clearance;
        private Label label4;
        private Label label5;
        private ProgressBar progressBar_clearance;
        private Label label_CoordX;
        private Label label_CoordY;
        private Label label6;
        private TreeView treeView1;
        private System.Windows.Forms.Timer timerProgressBar;
        private ProgressBar progressBarTime;
    }
}