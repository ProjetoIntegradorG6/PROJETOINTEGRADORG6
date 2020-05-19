namespace SalaoBeleza
{
    partial class Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtkCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtkTel = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalve = new System.Windows.Forms.Button();
            this.btnCanc = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtkCNPJ);
            this.panel1.Controls.Add(this.mtkTel);
            this.panel1.Controls.Add(this.txtEndereco);
            this.panel1.Controls.Add(this.txtNomee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 180);
            this.panel1.TabIndex = 3;
            // 
            // mtkCNPJ
            // 
            this.mtkCNPJ.Location = new System.Drawing.Point(7, 152);
            this.mtkCNPJ.Mask = "00.000.000/0000-00";
            this.mtkCNPJ.Name = "mtkCNPJ";
            this.mtkCNPJ.Size = new System.Drawing.Size(100, 20);
            this.mtkCNPJ.TabIndex = 7;
            // 
            // mtkTel
            // 
            this.mtkTel.Location = new System.Drawing.Point(7, 108);
            this.mtkTel.Mask = "(00)99999-9999";
            this.mtkTel.Name = "mtkTel";
            this.mtkTel.Size = new System.Drawing.Size(100, 20);
            this.mtkTel.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 69);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(243, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtNomee
            // 
            this.txtNomee.Location = new System.Drawing.Point(6, 26);
            this.txtNomee.Name = "txtNomee";
            this.txtNomee.Size = new System.Drawing.Size(243, 20);
            this.txtNomee.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome";
            // 
            // btnSalve
            // 
            this.btnSalve.Location = new System.Drawing.Point(21, 386);
            this.btnSalve.Name = "btnSalve";
            this.btnSalve.Size = new System.Drawing.Size(75, 23);
            this.btnSalve.TabIndex = 4;
            this.btnSalve.Text = "Salvar";
            this.btnSalve.UseVisualStyleBackColor = true;
            this.btnSalve.Click += new System.EventHandler(this.btnSalve_Click);
            // 
            // btnCanc
            // 
            this.btnCanc.Location = new System.Drawing.Point(153, 386);
            this.btnCanc.Name = "btnCanc";
            this.btnCanc.Size = new System.Drawing.Size(75, 23);
            this.btnCanc.TabIndex = 5;
            this.btnCanc.Text = "Cancelar";
            this.btnCanc.UseVisualStyleBackColor = true;
            this.btnCanc.Click += new System.EventHandler(this.btnCanc_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(278, 386);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 23);
            this.btnAlt.TabIndex = 6;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alisantes",
            "Cremes para hidratação",
            "Escovas",
            "Pentes",
            "Pranchas",
            "Secadores",
            "Tesouras",
            "Tinturas",
            "Toalhas"});
            this.comboBox1.Location = new System.Drawing.Point(15, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.btnCanc);
            this.Controls.Add(this.btnSalve);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtkCNPJ;
        private System.Windows.Forms.MaskedTextBox mtkTel;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNomee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalve;
        private System.Windows.Forms.Button btnCanc;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}