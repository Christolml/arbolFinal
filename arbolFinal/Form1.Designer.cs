namespace arbolFinal
{
    partial class Form1
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
            this.txtEcuación = new System.Windows.Forms.TextBox();
            this.lblEcuación = new System.Windows.Forms.Label();
            this.btnArmar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEcuación
            // 
            this.txtEcuación.Location = new System.Drawing.Point(190, 41);
            this.txtEcuación.Name = "txtEcuación";
            this.txtEcuación.Size = new System.Drawing.Size(411, 38);
            this.txtEcuación.TabIndex = 0;
            // 
            // lblEcuación
            // 
            this.lblEcuación.AutoSize = true;
            this.lblEcuación.Location = new System.Drawing.Point(25, 47);
            this.lblEcuación.Name = "lblEcuación";
            this.lblEcuación.Size = new System.Drawing.Size(141, 32);
            this.lblEcuación.TabIndex = 1;
            this.lblEcuación.Text = "Ecuación:";
            // 
            // btnArmar
            // 
            this.btnArmar.Location = new System.Drawing.Point(40, 125);
            this.btnArmar.Name = "btnArmar";
            this.btnArmar.Size = new System.Drawing.Size(126, 81);
            this.btnArmar.TabIndex = 2;
            this.btnArmar.Text = "Armar arbol";
            this.btnArmar.UseVisualStyleBackColor = true;
            this.btnArmar.Click += new System.EventHandler(this.btnArmar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(335, 110);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(503, 194);
            this.txtResultado.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(40, 277);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 49);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 400);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnArmar);
            this.Controls.Add(this.lblEcuación);
            this.Controls.Add(this.txtEcuación);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEcuación;
        private System.Windows.Forms.Label lblEcuación;
        private System.Windows.Forms.Button btnArmar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSalir;
    }
}

