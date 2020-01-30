namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtCRO = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.chlk = new System.Windows.Forms.CheckBox();
            this.chin = new System.Windows.Forms.CheckBox();
            this.chtw = new System.Windows.Forms.CheckBox();
            this.chfc = new System.Windows.Forms.CheckBox();
            this.DataFrmDentistas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFrmDentistas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(24, 26);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(92, 43);
            this.btnnovo.TabIndex = 0;
            this.btnnovo.Text = "NOVO";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click_1);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(122, 26);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(77, 43);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "SALVAR";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(205, 26);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(74, 43);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(285, 26);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 43);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNOME);
            this.groupBox1.Controls.Add(this.txtCRO);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Location = new System.Drawing.Point(39, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 127);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // txtNOME
            // 
            this.txtNOME.Location = new System.Drawing.Point(50, 84);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(255, 20);
            this.txtNOME.TabIndex = 2;
            // 
            // txtCRO
            // 
            this.txtCRO.Location = new System.Drawing.Point(197, 19);
            this.txtCRO.Name = "txtCRO";
            this.txtCRO.Size = new System.Drawing.Size(100, 20);
            this.txtCRO.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(50, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(9, 24);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 5;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(7, 47);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(70, 17);
            this.rbFeminino.TabIndex = 6;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino ";
            this.rbFeminino.UseVisualStyleBackColor = true;
            this.rbFeminino.CheckedChanged += new System.EventHandler(this.rbFeminino_CheckedChanged);
            // 
            // chlk
            // 
            this.chlk.AutoSize = true;
            this.chlk.Location = new System.Drawing.Point(18, 36);
            this.chlk.Name = "chlk";
            this.chlk.Size = new System.Drawing.Size(57, 17);
            this.chlk.TabIndex = 7;
            this.chlk.Text = "Whats";
            this.chlk.UseVisualStyleBackColor = true;
            // 
            // chin
            // 
            this.chin.AutoSize = true;
            this.chin.Location = new System.Drawing.Point(18, 60);
            this.chin.Name = "chin";
            this.chin.Size = new System.Drawing.Size(49, 17);
            this.chin.TabIndex = 8;
            this.chin.Text = "Insta";
            this.chin.UseVisualStyleBackColor = true;
            // 
            // chtw
            // 
            this.chtw.AutoSize = true;
            this.chtw.Location = new System.Drawing.Point(120, 37);
            this.chtw.Name = "chtw";
            this.chtw.Size = new System.Drawing.Size(58, 17);
            this.chtw.TabIndex = 9;
            this.chtw.Text = "Twitter";
            this.chtw.UseVisualStyleBackColor = true;
            // 
            // chfc
            // 
            this.chfc.AutoSize = true;
            this.chfc.Location = new System.Drawing.Point(120, 60);
            this.chfc.Name = "chfc";
            this.chfc.Size = new System.Drawing.Size(74, 17);
            this.chfc.TabIndex = 10;
            this.chfc.Text = "Facebook";
            this.chfc.UseVisualStyleBackColor = true;
            // 
            // DataFrmDentistas
            // 
            this.DataFrmDentistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFrmDentistas.Location = new System.Drawing.Point(13, 363);
            this.DataFrmDentistas.Name = "DataFrmDentistas";
            this.DataFrmDentistas.Size = new System.Drawing.Size(386, 194);
            this.DataFrmDentistas.TabIndex = 11;
            this.DataFrmDentistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataFrmDentistas_CellContentClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Controls.Add(this.rbFeminino);
            this.groupBox2.Location = new System.Drawing.Point(39, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 94);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEXO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chtw);
            this.groupBox3.Controls.Add(this.chfc);
            this.groupBox3.Controls.Add(this.chin);
            this.groupBox3.Controls.Add(this.chlk);
            this.groupBox3.Location = new System.Drawing.Point(169, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "REDES SOCIAIS ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DataFrmDentistas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFrmDentistas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtCRO;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.CheckBox chlk;
        private System.Windows.Forms.CheckBox chin;
        private System.Windows.Forms.CheckBox chtw;
        private System.Windows.Forms.CheckBox chfc;
        private System.Windows.Forms.DataGridView DataFrmDentistas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

