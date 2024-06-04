namespace Museu_multitematico
{
    partial class Informacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacoes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_prox = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "O módulo lunar da missão Apollo 11, chamado de Eagle,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "foi responsável por auxiliar na chegada do primeiro homem à lua.";
            // 
            // btn_prox
            // 
            this.btn_prox.Location = new System.Drawing.Point(501, 486);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(90, 34);
            this.btn_prox.TabIndex = 3;
            this.btn_prox.Text = "Próxima";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.btn_prox_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Location = new System.Drawing.Point(1, 486);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(90, 34);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.Text = "Início";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(77, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 426);
            this.panel1.TabIndex = 0;
            // 
            // Informacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(593, 521);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Informacoes";
            this.Text = "Informacoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_prox;
        private System.Windows.Forms.Button btn_inicio;
    }
}