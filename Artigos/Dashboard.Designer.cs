namespace Artigos
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMinhasAvaliacoes = new System.Windows.Forms.Button();
            this.btnVincularRevisor = new System.Windows.Forms.Button();
            this.btnCadastrarArea = new System.Windows.Forms.Button();
            this.btnRevisarArtigo = new System.Windows.Forms.Button();
            this.btnCadastrarArtigo = new System.Windows.Forms.Button();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnMinhasAvaliacoes
            // 
            this.btnMinhasAvaliacoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinhasAvaliacoes.Image = global::Artigos.Properties.Resources.avaliacao_icon;
            this.btnMinhasAvaliacoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinhasAvaliacoes.Location = new System.Drawing.Point(830, 50);
            this.btnMinhasAvaliacoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinhasAvaliacoes.Name = "btnMinhasAvaliacoes";
            this.btnMinhasAvaliacoes.Size = new System.Drawing.Size(124, 100);
            this.btnMinhasAvaliacoes.TabIndex = 5;
            this.btnMinhasAvaliacoes.Text = "Minhas Avaliações";
            this.btnMinhasAvaliacoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinhasAvaliacoes.UseVisualStyleBackColor = true;
            this.btnMinhasAvaliacoes.Click += new System.EventHandler(this.btnMinhasAvaliacoes_Click);
            // 
            // btnVincularRevisor
            // 
            this.btnVincularRevisor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVincularRevisor.Image = global::Artigos.Properties.Resources.vincular;
            this.btnVincularRevisor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVincularRevisor.Location = new System.Drawing.Point(677, 50);
            this.btnVincularRevisor.Margin = new System.Windows.Forms.Padding(4);
            this.btnVincularRevisor.Name = "btnVincularRevisor";
            this.btnVincularRevisor.Size = new System.Drawing.Size(124, 100);
            this.btnVincularRevisor.TabIndex = 4;
            this.btnVincularRevisor.Text = "Vincular Revisor a Area";
            this.btnVincularRevisor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVincularRevisor.UseVisualStyleBackColor = true;
            this.btnVincularRevisor.Click += new System.EventHandler(this.btnVincularRevisor_Click);
            // 
            // btnCadastrarArea
            // 
            this.btnCadastrarArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarArea.Image = global::Artigos.Properties.Resources.icon_group;
            this.btnCadastrarArea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarArea.Location = new System.Drawing.Point(524, 50);
            this.btnCadastrarArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarArea.Name = "btnCadastrarArea";
            this.btnCadastrarArea.Size = new System.Drawing.Size(124, 100);
            this.btnCadastrarArea.TabIndex = 3;
            this.btnCadastrarArea.Text = "Cadastrar \r\nArea";
            this.btnCadastrarArea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarArea.UseVisualStyleBackColor = true;
            this.btnCadastrarArea.Click += new System.EventHandler(this.btnCadastrarArea_Click);
            // 
            // btnRevisarArtigo
            // 
            this.btnRevisarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisarArtigo.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisarArtigo.Image")));
            this.btnRevisarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRevisarArtigo.Location = new System.Drawing.Point(365, 50);
            this.btnRevisarArtigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevisarArtigo.Name = "btnRevisarArtigo";
            this.btnRevisarArtigo.Size = new System.Drawing.Size(124, 100);
            this.btnRevisarArtigo.TabIndex = 2;
            this.btnRevisarArtigo.Text = "Revisar\r\nArtigo\r\n";
            this.btnRevisarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevisarArtigo.UseVisualStyleBackColor = true;
            this.btnRevisarArtigo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCadastrarArtigo
            // 
            this.btnCadastrarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarArtigo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarArtigo.Image")));
            this.btnCadastrarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarArtigo.Location = new System.Drawing.Point(211, 50);
            this.btnCadastrarArtigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarArtigo.Name = "btnCadastrarArtigo";
            this.btnCadastrarArtigo.Size = new System.Drawing.Size(124, 100);
            this.btnCadastrarArtigo.TabIndex = 1;
            this.btnCadastrarArtigo.Text = "Cadastrar \r\nArtigo";
            this.btnCadastrarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarArtigo.UseVisualStyleBackColor = true;
            this.btnCadastrarArtigo.Click += new System.EventHandler(this.btnCadastrarArtigo_Click);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarUsuario.Enabled = false;
            this.btnCadastrarUsuario.Image = global::Artigos.Properties.Resources.iconUser;
            this.btnCadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(56, 50);
            this.btnCadastrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(124, 100);
            this.btnCadastrarUsuario.TabIndex = 0;
            this.btnCadastrarUsuario.Text = "Cadastrar \r\nUsuário";
            this.btnCadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 575);
            this.Controls.Add(this.btnMinhasAvaliacoes);
            this.Controls.Add(this.btnVincularRevisor);
            this.Controls.Add(this.btnCadastrarArea);
            this.Controls.Add(this.btnRevisarArtigo);
            this.Controls.Add(this.btnCadastrarArtigo);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar artigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCadastrarArtigo;
        private System.Windows.Forms.Button btnRevisarArtigo;
        private System.Windows.Forms.Button btnCadastrarArea;
        private System.Windows.Forms.Button btnVincularRevisor;
        private System.Windows.Forms.Button btnMinhasAvaliacoes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

