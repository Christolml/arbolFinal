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
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalculoPost = new System.Windows.Forms.Button();
            this.btnCalculoPre = new System.Windows.Forms.Button();
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
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(31, 237);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(154, 49);
            this.btnPreOrden.TabIndex = 4;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(31, 301);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(164, 49);
            this.btnPostOrden.TabIndex = 5;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(785, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 49);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalculoPost
            // 
            this.btnCalculoPost.Enabled = false;
            this.btnCalculoPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoPost.Location = new System.Drawing.Point(31, 462);
            this.btnCalculoPost.Name = "btnCalculoPost";
            this.btnCalculoPost.Size = new System.Drawing.Size(135, 64);
            this.btnCalculoPost.TabIndex = 7;
            this.btnCalculoPost.Text = "Calculo por\r\nPostOrden";
            this.btnCalculoPost.UseVisualStyleBackColor = true;
            this.btnCalculoPost.Click += new System.EventHandler(this.btnCalculoPost_Click);
            // 
            // btnCalculoPre
            // 
            this.btnCalculoPre.Enabled = false;
            this.btnCalculoPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoPre.Location = new System.Drawing.Point(31, 369);
            this.btnCalculoPre.Name = "btnCalculoPre";
            this.btnCalculoPre.Size = new System.Drawing.Size(135, 64);
            this.btnCalculoPre.TabIndex = 8;
            this.btnCalculoPre.Text = "Calculo por\r\nPreOrden";
            this.btnCalculoPre.UseVisualStyleBackColor = true;
            this.btnCalculoPre.Click += new System.EventHandler(this.btnCalculoPre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 595);
            this.Controls.Add(this.btnCalculoPre);
            this.Controls.Add(this.btnCalculoPost);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.btnPreOrden);
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
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalculoPost;
        private System.Windows.Forms.Button btnCalculoPre;
    }
}

