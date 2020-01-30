namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtMotivoR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDentista = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataR = new System.Windows.Forms.DateTimePicker();
            this.dataC = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(30, 32);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(97, 31);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "NOVO";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnsalvar.Location = new System.Drawing.Point(133, 32);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(98, 31);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(237, 32);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(87, 31);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(330, 32);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(86, 31);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.Text = "EXCLUIR";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID consulta";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(97, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(110, 20);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(97, 171);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(303, 20);
            this.txtDia.TabIndex = 6;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(98, 93);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(303, 20);
            this.txtMotivo.TabIndex = 7;
            this.txtMotivo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMotivoR
            // 
            this.txtMotivoR.Location = new System.Drawing.Point(98, 119);
            this.txtMotivoR.Name = "txtMotivoR";
            this.txtMotivoR.Size = new System.Drawing.Size(303, 20);
            this.txtMotivoR.TabIndex = 8;
            this.txtMotivoR.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data de Retorno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Receita";
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(97, 145);
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(303, 20);
            this.txtReceita.TabIndex = 13;
            this.txtReceita.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motivo do Retorno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Diagnostico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motivo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Data da Consulta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnnovo);
            this.groupBox1.Controls.Add(this.btnsalvar);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnexcluir);
            this.groupBox1.Location = new System.Drawing.Point(12, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDentista);
            this.groupBox2.Controls.Add(this.cmbPaciente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DataR);
            this.groupBox2.Controls.Add(this.dataC);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtReceita);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDia);
            this.groupBox2.Controls.Add(this.txtMotivo);
            this.groupBox2.Controls.Add(this.txtMotivoR);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 270);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Consulta";
            // 
            // cmbDentista
            // 
            this.cmbDentista.FormattingEnabled = true;
            this.cmbDentista.Location = new System.Drawing.Point(98, 224);
            this.cmbDentista.Name = "cmbDentista";
            this.cmbDentista.Size = new System.Drawing.Size(303, 21);
            this.cmbDentista.TabIndex = 23;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(98, 197);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(303, 21);
            this.cmbPaciente.TabIndex = 22;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nome do Dentista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nome do Paciente";
            // 
            // DataR
            // 
            this.DataR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataR.Location = new System.Drawing.Point(310, 62);
            this.DataR.Name = "DataR";
            this.DataR.Size = new System.Drawing.Size(119, 20);
            this.DataR.TabIndex = 19;
            // 
            // dataC
            // 
            this.dataC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataC.Location = new System.Drawing.Point(98, 66);
            this.dataC.Name = "dataC";
            this.dataC.Size = new System.Drawing.Size(109, 20);
            this.dataC.TabIndex = 18;
            this.dataC.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 106);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtMotivoR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDentista;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DataR;
        private System.Windows.Forms.DateTimePicker dataC;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}