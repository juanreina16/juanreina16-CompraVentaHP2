namespace CompraVentaHP2
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbimpresion = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // lbimpresion
            // 
            this.lbimpresion.AutoSize = true;
            this.lbimpresion.Location = new System.Drawing.Point(63, 248);
            this.lbimpresion.Name = "lbimpresion";
            this.lbimpresion.Size = new System.Drawing.Size(0, 15);
            this.lbimpresion.TabIndex = 2;
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btningresar.ForeColor = System.Drawing.Color.Navy;
            this.btningresar.Location = new System.Drawing.Point(83, 189);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(100, 23);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtusu
            // 
            this.txtusu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtusu.Location = new System.Drawing.Point(83, 78);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(100, 23);
            this.txtusu.TabIndex = 4;
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.Snow;
            this.txtcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontra.Location = new System.Drawing.Point(83, 137);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 23);
            this.txtcontra.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(276, 277);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.lbimpresion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "Log in";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbimpresion;
        private Button btningresar;
        private TextBox txtusu;
        private TextBox txtcontra;
    }
}