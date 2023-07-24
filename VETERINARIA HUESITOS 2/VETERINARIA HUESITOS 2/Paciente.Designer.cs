namespace VETERINARIA_HUESITOS_2
{
    partial class Paciente
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
            this.Tamaño = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Castrado = new System.Windows.Forms.ComboBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.Especie = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.PacienteGV = new System.Windows.Forms.DataGridView();
            this.Fecha_de_Nacimiento = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.TextBox();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Raza = new System.Windows.Forms.TextBox();
            this.Nombre_Paciente = new System.Windows.Forms.TextBox();
            this.Fecha_de_Ingreso = new System.Windows.Forms.TextBox();
            this.Id_Cliente = new System.Windows.Forms.TextBox();
            this.Id_Paciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tamaño
            // 
            this.Tamaño.FormattingEnabled = true;
            this.Tamaño.Items.AddRange(new object[] {
            "Toy",
            "Pequeño",
            "Mediano",
            "Grande"});
            this.Tamaño.Location = new System.Drawing.Point(116, 155);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(107, 21);
            this.Tamaño.TabIndex = 64;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(162, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 34);
            this.button4.TabIndex = 63;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(35, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 34);
            this.button3.TabIndex = 62;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 61;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 60;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Castrado
            // 
            this.Castrado.FormattingEnabled = true;
            this.Castrado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Castrado.Location = new System.Drawing.Point(682, 155);
            this.Castrado.Name = "Castrado";
            this.Castrado.Size = new System.Drawing.Size(57, 21);
            this.Castrado.TabIndex = 59;
            // 
            // Sexo
            // 
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Hembra",
            "Macho"});
            this.Sexo.Location = new System.Drawing.Point(680, 115);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(90, 21);
            this.Sexo.TabIndex = 58;
            // 
            // Especie
            // 
            this.Especie.FormattingEnabled = true;
            this.Especie.Items.AddRange(new object[] {
            "Canino",
            "Felino",
            "Conejo",
            "Hamster"});
            this.Especie.Location = new System.Drawing.Point(317, 117);
            this.Especie.Name = "Especie";
            this.Especie.Size = new System.Drawing.Size(110, 21);
            this.Especie.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(465, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 15);
            this.label15.TabIndex = 56;
            this.label15.Text = "Lista de Pacientes";
            // 
            // PacienteGV
            // 
            this.PacienteGV.BackgroundColor = System.Drawing.Color.White;
            this.PacienteGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacienteGV.Location = new System.Drawing.Point(271, 222);
            this.PacienteGV.Name = "PacienteGV";
            this.PacienteGV.Size = new System.Drawing.Size(517, 216);
            this.PacienteGV.TabIndex = 55;
            this.PacienteGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PacienteGV_CellContentClick);
            // 
            // Fecha_de_Nacimiento
            // 
            this.Fecha_de_Nacimiento.Location = new System.Drawing.Point(181, 190);
            this.Fecha_de_Nacimiento.Name = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.Size = new System.Drawing.Size(100, 20);
            this.Fecha_de_Nacimiento.TabIndex = 54;
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(490, 154);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(100, 20);
            this.Color.TabIndex = 53;
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(317, 151);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(100, 20);
            this.Peso.TabIndex = 52;
            // 
            // Raza
            // 
            this.Raza.Location = new System.Drawing.Point(490, 119);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(100, 20);
            this.Raza.TabIndex = 51;
            // 
            // Nombre_Paciente
            // 
            this.Nombre_Paciente.Location = new System.Drawing.Point(123, 118);
            this.Nombre_Paciente.Name = "Nombre_Paciente";
            this.Nombre_Paciente.Size = new System.Drawing.Size(100, 20);
            this.Nombre_Paciente.TabIndex = 50;
            // 
            // Fecha_de_Ingreso
            // 
            this.Fecha_de_Ingreso.Location = new System.Drawing.Point(621, 80);
            this.Fecha_de_Ingreso.Name = "Fecha_de_Ingreso";
            this.Fecha_de_Ingreso.Size = new System.Drawing.Size(100, 20);
            this.Fecha_de_Ingreso.TabIndex = 49;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.Location = new System.Drawing.Point(317, 80);
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Size = new System.Drawing.Size(106, 20);
            this.Id_Cliente.TabIndex = 48;
            // 
            // Id_Paciente
            // 
            this.Id_Paciente.Location = new System.Drawing.Point(116, 83);
            this.Id_Paciente.Name = "Id_Paciente";
            this.Id_Paciente.Size = new System.Drawing.Size(107, 20);
            this.Id_Paciente.TabIndex = 47;
            this.Id_Paciente.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(487, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "Fecha de Ingreso";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 194);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 16);
            this.label13.TabIndex = 45;
            this.label13.Text = "Fecha de Nacimento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(606, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 44;
            this.label12.Text = "Castrado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Peso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Tamaño";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(634, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Raza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cliente Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Paciente Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 72);
            this.panel1.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VETERINARIA HUESITOS";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tamaño);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Castrado);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Especie);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.PacienteGV);
            this.Controls.Add(this.Fecha_de_Nacimiento);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.Nombre_Paciente);
            this.Controls.Add(this.Fecha_de_Ingreso);
            this.Controls.Add(this.Id_Cliente);
            this.Controls.Add(this.Id_Paciente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PACIENTE";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacienteGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Tamaño;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Castrado;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.ComboBox Especie;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView PacienteGV;
        private System.Windows.Forms.TextBox Fecha_de_Nacimiento;
        private System.Windows.Forms.TextBox Color;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Raza;
        private System.Windows.Forms.TextBox Nombre_Paciente;
        private System.Windows.Forms.TextBox Fecha_de_Ingreso;
        private System.Windows.Forms.TextBox Id_Cliente;
        private System.Windows.Forms.TextBox Id_Paciente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}