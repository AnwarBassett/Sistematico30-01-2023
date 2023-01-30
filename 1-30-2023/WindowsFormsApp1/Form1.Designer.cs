namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNtEspañol = new System.Windows.Forms.TextBox();
            this.txtNtMatematica = new System.Windows.Forms.TextBox();
            this.txtNtFisica = new System.Windows.Forms.TextBox();
            this.txtNtIngles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Reg_Estu = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Español = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEliminarF = new System.Windows.Forms.Button();
            this.btnEliminarReg = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPromNt = new System.Windows.Forms.TextBox();
            this.lbApr = new System.Windows.Forms.Label();
            this.lbCnEstu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Reg_Estu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Español: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matematica: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fisica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingles: ";
            // 
            // txtNtEspañol
            // 
            this.txtNtEspañol.Location = new System.Drawing.Point(83, 81);
            this.txtNtEspañol.Name = "txtNtEspañol";
            this.txtNtEspañol.Size = new System.Drawing.Size(125, 20);
            this.txtNtEspañol.TabIndex = 5;
            // 
            // txtNtMatematica
            // 
            this.txtNtMatematica.Location = new System.Drawing.Point(83, 108);
            this.txtNtMatematica.Name = "txtNtMatematica";
            this.txtNtMatematica.Size = new System.Drawing.Size(125, 20);
            this.txtNtMatematica.TabIndex = 6;
            // 
            // txtNtFisica
            // 
            this.txtNtFisica.Location = new System.Drawing.Point(56, 134);
            this.txtNtFisica.Name = "txtNtFisica";
            this.txtNtFisica.Size = new System.Drawing.Size(152, 20);
            this.txtNtFisica.TabIndex = 7;
            this.txtNtFisica.TextChanged += new System.EventHandler(this.txtNtFisica_TextChanged);
            // 
            // txtNtIngles
            // 
            this.txtNtIngles.Location = new System.Drawing.Point(56, 159);
            this.txtNtIngles.Name = "txtNtIngles";
            this.txtNtIngles.Size = new System.Drawing.Size(152, 20);
            this.txtNtIngles.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Notas:";
            // 
            // Reg_Estu
            // 
            this.Reg_Estu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reg_Estu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Matematica,
            this.Fisica,
            this.Ingles,
            this.Español});
            this.Reg_Estu.Location = new System.Drawing.Point(12, 185);
            this.Reg_Estu.Name = "Reg_Estu";
            this.Reg_Estu.Size = new System.Drawing.Size(541, 166);
            this.Reg_Estu.TabIndex = 10;
            this.Reg_Estu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Matematica
            // 
            this.Matematica.HeaderText = "Matematica";
            this.Matematica.Name = "Matematica";
            // 
            // Fisica
            // 
            this.Fisica.HeaderText = "Fisica";
            this.Fisica.Name = "Fisica";
            // 
            // Ingles
            // 
            this.Ingles.HeaderText = "Ingles";
            this.Ingles.Name = "Ingles";
            // 
            // Español
            // 
            this.Español.HeaderText = "Español";
            this.Español.Name = "Español";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(370, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // btnEliminarF
            // 
            this.btnEliminarF.Location = new System.Drawing.Point(370, 51);
            this.btnEliminarF.Name = "btnEliminarF";
            this.btnEliminarF.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarF.TabIndex = 13;
            this.btnEliminarF.Text = "Eliminar Fila";
            this.btnEliminarF.UseVisualStyleBackColor = true;
            this.btnEliminarF.Click += new System.EventHandler(this.btnEliminarF_Click);
            // 
            // btnEliminarReg
            // 
            this.btnEliminarReg.Location = new System.Drawing.Point(370, 83);
            this.btnEliminarReg.Name = "btnEliminarReg";
            this.btnEliminarReg.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarReg.TabIndex = 14;
            this.btnEliminarReg.Text = "Eliminar Registro";
            this.btnEliminarReg.UseVisualStyleBackColor = true;
            this.btnEliminarReg.Click += new System.EventHandler(this.btnEliminarReg_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(370, 112);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "Mostrar Resultado";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estudiante:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Promedio:";
            // 
            // txtPromNt
            // 
            this.txtPromNt.Enabled = false;
            this.txtPromNt.Location = new System.Drawing.Point(206, 377);
            this.txtPromNt.Name = "txtPromNt";
            this.txtPromNt.Size = new System.Drawing.Size(100, 20);
            this.txtPromNt.TabIndex = 19;
            // 
            // lbApr
            // 
            this.lbApr.AutoSize = true;
            this.lbApr.Location = new System.Drawing.Point(329, 380);
            this.lbApr.Name = "lbApr";
            this.lbApr.Size = new System.Drawing.Size(111, 13);
            this.lbApr.TabIndex = 20;
            this.lbApr.Text = "Aprobado/Reprobado";
            // 
            // lbCnEstu
            // 
            this.lbCnEstu.AutoSize = true;
            this.lbCnEstu.Location = new System.Drawing.Point(12, 466);
            this.lbCnEstu.Name = "lbCnEstu";
            this.lbCnEstu.Size = new System.Drawing.Size(107, 13);
            this.lbCnEstu.TabIndex = 21;
            this.lbCnEstu.Text = "Cantidad Estudiantes";
            this.lbCnEstu.Click += new System.EventHandler(this.lbCnEstu_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Suma:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Promedio del Salon:";
            // 
            // txtBox1
            // 
            this.txtBox1.Enabled = false;
            this.txtBox1.Location = new System.Drawing.Point(125, 463);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(38, 20);
            this.txtBox1.TabIndex = 24;
            // 
            // txtBox2
            // 
            this.txtBox2.Enabled = false;
            this.txtBox2.Location = new System.Drawing.Point(246, 463);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(79, 20);
            this.txtBox2.TabIndex = 25;
            // 
            // txtBox3
            // 
            this.txtBox3.Enabled = false;
            this.txtBox3.Location = new System.Drawing.Point(438, 463);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 26;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(370, 141);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(447, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Nota_Mayor:";
            // 
            // txtMayor
            // 
            this.txtMayor.Enabled = false;
            this.txtMayor.Location = new System.Drawing.Point(521, 376);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(77, 20);
            this.txtMayor.TabIndex = 29;
            // 
            // txtMenor
            // 
            this.txtMenor.Enabled = false;
            this.txtMenor.Location = new System.Drawing.Point(522, 411);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(76, 20);
            this.txtMenor.TabIndex = 30;
            this.txtMenor.TextChanged += new System.EventHandler(this.txtMenor_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Nota_Menor:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(74, 377);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(66, 20);
            this.txtName.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 513);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbCnEstu);
            this.Controls.Add(this.lbApr);
            this.Controls.Add(this.txtPromNt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEliminarReg);
            this.Controls.Add(this.btnEliminarF);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.Reg_Estu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNtIngles);
            this.Controls.Add(this.txtNtFisica);
            this.Controls.Add(this.txtNtMatematica);
            this.Controls.Add(this.txtNtEspañol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reg_Estu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNtEspañol;
        private System.Windows.Forms.TextBox txtNtMatematica;
        private System.Windows.Forms.TextBox txtNtFisica;
        private System.Windows.Forms.TextBox txtNtIngles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Reg_Estu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matematica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Español;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEliminarF;
        private System.Windows.Forms.Button btnEliminarReg;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPromNt;
        private System.Windows.Forms.Label lbApr;
        private System.Windows.Forms.Label lbCnEstu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtName;
    }
}

