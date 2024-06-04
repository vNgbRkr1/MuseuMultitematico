namespace Museu_multitematico
{
    partial class informacoes4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informacoes4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(155, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 375);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neste pequeno quadrado amarelo é onde fica localizado o mar da tranquilidade,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "local de pouso na lua, durante a primeira missão tripulada.";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(0, 437);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(87, 34);
            this.btn_voltar.TabIndex = 9;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_prox
            // 
            this.btn_prox.Location = new System.Drawing.Point(710, 437);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(90, 34);
            this.btn_prox.TabIndex = 10;
            this.btn_prox.Text = "Próxima";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.btn_prox_Click);
            // 
            // informacoes4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "informacoes4";
            this.Text = "informacoes4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_prox;
    }
}