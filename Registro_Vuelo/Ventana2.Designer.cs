namespace Registro_Vuelo
{
    partial class Ventana2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Asientos disponibles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Asientos Ocupados:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(680, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ciudad de Mexico (MEX)", "Guadalajara (GDL)", "Cancún (CUN)", "Monterrey (MTY)", "Tijuana (TIJ)" });
            comboBox1.Location = new Point(12, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ciudad de Mexico (MEX)", "Guadalajara (GDL)", "Cancún (CUN)", "Monterrey (MTY)", "Tijuana (TIJ)" });
            comboBox2.Location = new Point(168, 47);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Ciudad de Mexico (MEX)", "Guadalajara (GDL)", "Cancún (CUN)", "Monterrey (MTY)", "Tijuana (TIJ)" });
            comboBox3.Location = new Point(12, 150);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Ciudad de Mexico (MEX)", "Guadalajara (GDL)", "Cancún (CUN)", "Monterrey (MTY)", "Tijuana (TIJ)" });
            comboBox4.Location = new Point(168, 150);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 47);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(122, 15);
            label5.TabIndex = 8;
            label5.Text = "Clase: Economica/VIP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 153);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(100, 15);
            label6.TabIndex = 9;
            label6.Text = "Clase: Economica";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 103);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "14:50 --- 17:00";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 217);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "11:56 --- 14:40";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 278);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "17:59 --- 20:40";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(416, 189);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(72, 23);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 19F);
            label7.Location = new Point(589, 103);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(129, 36);
            label7.TabIndex = 14;
            label7.Text = "MX$1,815";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(602, 139);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(106, 30);
            label8.TabIndex = 15;
            label8.Text = "Precio  por Adulto \r\n     Ida y Vuelta";
            // 
            // button1
            // 
            button1.Location = new Point(589, 217);
            button1.Name = "button1";
            button1.Size = new Size(129, 33);
            button1.TabIndex = 16;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(589, 278);
            button2.Name = "button2";
            button2.Size = new Size(129, 33);
            button2.TabIndex = 17;
            button2.Text = "Elegir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Ventana2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.avion_estacionado_aeropuerto_cielo_fondo_662214_151474;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ventana2";
            Text = "Ventana2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label5;
        private Label label6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
    }
}