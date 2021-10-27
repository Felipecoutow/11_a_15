namespace Template_Vs
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
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new CustomControls.RJControls.RJButton();
            this.btnLimpar = new CustomControls.RJControls.RJButton();
            this.btnVerMaior = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(29, 102);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(165, 27);
            this.txtN2.TabIndex = 0;
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(29, 152);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(165, 27);
            this.txtN1.TabIndex = 1;
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresultado.Enabled = false;
            this.txtresultado.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(29, 229);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(165, 20);
            this.txtresultado.TabIndex = 2;
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.BackColor = System.Drawing.Color.Transparent;
            this.lbln1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln1.Location = new System.Drawing.Point(29, 81);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(62, 19);
            this.lbln1.TabIndex = 6;
            this.lbln1.Text = "Valor 1:";
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.BackColor = System.Drawing.Color.Transparent;
            this.lbln2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbln2.Location = new System.Drawing.Point(29, 131);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(65, 19);
            this.lbln2.TabIndex = 7;
            this.lbln2.Text = "Valor 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnSair.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.btnSair.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.BorderRadius = 40;
            this.btnSair.BorderSize = 0;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(245, 197);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(150, 40);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextColor = System.Drawing.Color.White;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnLimpar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.btnLimpar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLimpar.BorderRadius = 40;
            this.btnLimpar.BorderSize = 0;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(245, 151);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextColor = System.Drawing.Color.White;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnVerMaior
            // 
            this.btnVerMaior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnVerMaior.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(4)))), ((int)(((byte)(41)))));
            this.btnVerMaior.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerMaior.BorderRadius = 40;
            this.btnVerMaior.BorderSize = 0;
            this.btnVerMaior.FlatAppearance.BorderSize = 0;
            this.btnVerMaior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerMaior.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerMaior.ForeColor = System.Drawing.Color.White;
            this.btnVerMaior.Location = new System.Drawing.Point(245, 105);
            this.btnVerMaior.Name = "btnVerMaior";
            this.btnVerMaior.Size = new System.Drawing.Size(150, 40);
            this.btnVerMaior.TabIndex = 3;
            this.btnVerMaior.Text = "Ver Maior";
            this.btnVerMaior.TextColor = System.Drawing.Color.White;
            this.btnVerMaior.UseVisualStyleBackColor = false;
            this.btnVerMaior.Click += new System.EventHandler(this.btnVerMaior_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(420, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVerMaior);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtN2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtresultado;
        private CustomControls.RJControls.RJButton btnVerMaior;
        private CustomControls.RJControls.RJButton btnLimpar;
        private CustomControls.RJControls.RJButton btnSair;
        private System.Windows.Forms.Label lbln1;
        private System.Windows.Forms.Label lbln2;
        private System.Windows.Forms.Label label2;
    }
}

