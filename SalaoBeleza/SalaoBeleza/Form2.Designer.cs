namespace SalaoBeleza
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroClientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.serviçosToolStripMenuItem,
            this.mnuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroClientesToolStripMenuItem
            // 
            this.cadastroClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastroClientesToolStripMenuItem.Name = "cadastroClientesToolStripMenuItem";
            this.cadastroClientesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.cadastroClientesToolStripMenuItem.Text = "Cadastro Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProdutos});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(205, 22);
            this.mnuProdutos.Text = "Fornecedores e Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.mnuProdutos_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escovaToolStripMenuItem,
            this.alinhamentoToolStripMenuItem,
            this.corteToolStripMenuItem,
            this.selagemToolStripMenuItem,
            this.pinturaToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // escovaToolStripMenuItem
            // 
            this.escovaToolStripMenuItem.Name = "escovaToolStripMenuItem";
            this.escovaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escovaToolStripMenuItem.Text = "Escova";
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // corteToolStripMenuItem
            // 
            this.corteToolStripMenuItem.Name = "corteToolStripMenuItem";
            this.corteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.corteToolStripMenuItem.Text = "Corte";
            // 
            // selagemToolStripMenuItem
            // 
            this.selagemToolStripMenuItem.Name = "selagemToolStripMenuItem";
            this.selagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selagemToolStripMenuItem.Text = "Selagem";
            // 
            // pinturaToolStripMenuItem
            // 
            this.pinturaToolStripMenuItem.Name = "pinturaToolStripMenuItem";
            this.pinturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pinturaToolStripMenuItem.Text = "Pintura";
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(38, 20);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPessoa});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mnuPessoa
            // 
            this.mnuPessoa.Name = "mnuPessoa";
            this.mnuPessoa.Size = new System.Drawing.Size(180, 22);
            this.mnuPessoa.Text = "Pessoa Física";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPessoa;
    }
}