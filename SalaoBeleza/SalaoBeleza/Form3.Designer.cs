namespace SalaoBeleza
{
    partial class Clientes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.rbtDinheiro = new System.Windows.Forms.RadioButton();
            this.rbtCartao = new System.Windows.Forms.RadioButton();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.gbxPag = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gbxPag.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(25, 89);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(274, 20);
            this.txtEnd.TabIndex = 6;
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(25, 151);
            this.mtbTel.Mask = "(00)00000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(105, 20);
            this.mtbTel.TabIndex = 7;
            // 
            // rbtDinheiro
            // 
            this.rbtDinheiro.AutoSize = true;
            this.rbtDinheiro.Location = new System.Drawing.Point(6, 19);
            this.rbtDinheiro.Name = "rbtDinheiro";
            this.rbtDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rbtDinheiro.TabIndex = 8;
            this.rbtDinheiro.TabStop = true;
            this.rbtDinheiro.Text = "Dinheiro";
            this.rbtDinheiro.UseVisualStyleBackColor = true;
            this.rbtDinheiro.CheckedChanged += new System.EventHandler(this.rbtDinheiro_CheckedChanged);
            // 
            // rbtCartao
            // 
            this.rbtCartao.AutoSize = true;
            this.rbtCartao.Location = new System.Drawing.Point(6, 42);
            this.rbtCartao.Name = "rbtCartao";
            this.rbtCartao.Size = new System.Drawing.Size(56, 17);
            this.rbtCartao.TabIndex = 9;
            this.rbtCartao.TabStop = true;
            this.rbtCartao.Text = "Cartão";
            this.rbtCartao.UseVisualStyleBackColor = true;
            // 
            // dtpHora
            // 
            this.dtpHora.Location = new System.Drawing.Point(227, 151);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(159, 20);
            this.dtpHora.TabIndex = 10;
            // 
            // gbxPag
            // 
            this.gbxPag.Controls.Add(this.rbtCartao);
            this.gbxPag.Controls.Add(this.rbtDinheiro);
            this.gbxPag.Location = new System.Drawing.Point(25, 220);
            this.gbxPag.Name = "gbxPag";
            this.gbxPag.Size = new System.Drawing.Size(166, 75);
            this.gbxPag.TabIndex = 11;
            this.gbxPag.TabStop = false;
            this.gbxPag.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(269, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(269, 272);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(269, 327);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 421);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxPag);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.gbxPag.ResumeLayout(false);
            this.gbxPag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.RadioButton rbtDinheiro;
        private System.Windows.Forms.RadioButton rbtCartao;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.GroupBox gbxPag;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAlterar;
    }
}