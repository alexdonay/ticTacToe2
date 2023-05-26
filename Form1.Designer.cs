namespace ticTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPedra = new System.Windows.Forms.PictureBox();
            this.pbPapel = new System.Windows.Forms.PictureBox();
            this.pbTesoura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTesoura)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPedra
            // 
            this.pbPedra.Location = new System.Drawing.Point(64, 62);
            this.pbPedra.Name = "pbPedra";
            this.pbPedra.Size = new System.Drawing.Size(100, 100);
            this.pbPedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPedra.TabIndex = 0;
            this.pbPedra.TabStop = false;
            this.pbPedra.Click += new System.EventHandler(this.pbPedra_Click);
            // 
            // pbPapel
            // 
            this.pbPapel.Location = new System.Drawing.Point(200, 62);
            this.pbPapel.Name = "pbPapel";
            this.pbPapel.Size = new System.Drawing.Size(100, 100);
            this.pbPapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPapel.TabIndex = 1;
            this.pbPapel.TabStop = false;
            this.pbPapel.Click += new System.EventHandler(this.pbPapel_Click);
            // 
            // pbTesoura
            // 
            this.pbTesoura.Location = new System.Drawing.Point(338, 62);
            this.pbTesoura.Name = "pbTesoura";
            this.pbTesoura.Size = new System.Drawing.Size(100, 100);
            this.pbTesoura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTesoura.TabIndex = 2;
            this.pbTesoura.TabStop = false;
            this.pbTesoura.Click += new System.EventHandler(this.pbTesoura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTesoura);
            this.Controls.Add(this.pbPapel);
            this.Controls.Add(this.pbPedra);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTesoura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPedra;
        private System.Windows.Forms.PictureBox pbPapel;
        private System.Windows.Forms.PictureBox pbTesoura;
    }
}

