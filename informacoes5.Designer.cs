namespace Museu_multitematico
{
    partial class informacoes5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informacoes5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(196, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 390);
            this.panel1.TabIndex = 0;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(2, 446);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(87, 34);
            this.btn_voltar.TabIndex = 10;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "A missão da Apollo 11 durou em torno de 8 dias, desde o lançamento até o retorno " +
    "à Terra.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Início";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // informacoes5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.panel1);
            this.Name = "informacoes5";
            this.Text = "informacoes5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}