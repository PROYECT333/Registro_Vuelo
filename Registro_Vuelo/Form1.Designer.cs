namespace Registro_Vuelo
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
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox3 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            comboBox4 = new ComboBox();
            label7 = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 27);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 27);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Clase";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(324, 23);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(38, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ciudad de México", "Guadalajara", "Monterrey", "Cancún", "Mérida" });
            comboBox1.Location = new Point(38, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 23);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 96);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Origen";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(38, 25);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ida y Vuelta";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(182, 25);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Solo ida";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Clase: Economica", "Clase: VIP" });
            comboBox2.Location = new Point(461, 24);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 93);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Salida";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(268, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 205);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 11;
            label5.Text = "Destino";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "México – Ciudad de México", "Estados Unidos – Nueva York", "España – Madrid", "Francia – París", "Japón – Tokio" });
            comboBox3.Location = new Point(38, 236);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(179, 23);
            comboBox3.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(268, 236);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(216, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 205);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 14;
            label6.Text = "Retorno";
            // 
            // button1
            // 
            button1.Location = new Point(644, 23);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 15;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Adultos (18 años)", "Jovenes (12-18 años)", "Niños de (2-12 años)", "Bebés (hasta 2 años)" });
            comboBox4.Location = new Point(555, 125);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(137, 23);
            comboBox4.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 93);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 17;
            label7.Text = "Pasajeros";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(712, 125);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(38, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(641, 216);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 19;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(802, 162);
            dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.avion_estacionado_aeropuerto_cielo_fondo_662214_151474;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(numericUpDown2);
            Controls.Add(label7);
            Controls.Add(comboBox4);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox3;
        private DateTimePicker dateTimePicker2;
        private Label label6;
        private Button button1;
        private ComboBox comboBox4;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
