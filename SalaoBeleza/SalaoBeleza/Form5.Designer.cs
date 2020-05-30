namespace SalaoBeleza
{
    partial class Serviços
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
            this.cmbServ = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serviços Oferecidos";
            // 
            // cmbServ
            // 
            this.cmbServ.FormattingEnabled = true;
            this.cmbServ.Items.AddRange(new object[] {
            "Alinhamento",
            "Botox",
            "Corte",
            "Escova",
            "Progressiva",
            "Selagem",
            "Tintura"});
            this.cmbServ.Location = new System.Drawing.Point(15, 39);
            this.cmbServ.Name = "cmbServ";
            this.cmbServ.Size = new System.Drawing.Size(121, 21);
            this.cmbServ.TabIndex = 1;
            // 
            // Serviços
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.cmbServ);
            this.Controls.Add(this.label1);
            this.Name = "Serviços";
            this.Text = "Serviços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbServ;
    }
}