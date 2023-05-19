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
            label1 = new Label();
            label2 = new Label();
            lbimpresion = new Label();
            btningresar = new Button();
            txtusu = new TextBox();
            txtcontra = new TextBox();
            btnAtras = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(160, 92);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(149, 196);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // lbimpresion
            // 
            lbimpresion.AutoSize = true;
            lbimpresion.Location = new Point(63, 248);
            lbimpresion.Name = "lbimpresion";
            lbimpresion.Size = new Size(0, 15);
            lbimpresion.TabIndex = 2;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btningresar.ForeColor = Color.CadetBlue;
            btningresar.Location = new Point(141, 302);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(100, 30);
            btningresar.TabIndex = 3;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtusu
            // 
            txtusu.BackColor = Color.WhiteSmoke;
            txtusu.BorderStyle = BorderStyle.FixedSingle;
            txtusu.ForeColor = SystemColors.MenuHighlight;
            txtusu.Location = new Point(141, 142);
            txtusu.Name = "txtusu";
            txtusu.Size = new Size(100, 23);
            txtusu.TabIndex = 4;
            // 
            // txtcontra
            // 
            txtcontra.BackColor = Color.Snow;
            txtcontra.BorderStyle = BorderStyle.FixedSingle;
            txtcontra.Location = new Point(141, 240);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(100, 23);
            txtcontra.TabIndex = 5;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.ForeColor = Color.Red;
            btnAtras.Location = new Point(12, 377);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 23);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(127, 40);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "ADMINISTRADOR";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(399, 412);
            Controls.Add(label3);
            Controls.Add(btnAtras);
            Controls.Add(txtcontra);
            Controls.Add(txtusu);
            Controls.Add(btningresar);
            Controls.Add(lbimpresion);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            Text = "Sing Up";
            TransparencyKey = Color.FromArgb(192, 0, 0);
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbimpresion;
        private Button btningresar;
        private TextBox txtusu;
        private TextBox txtcontra;
        private Button btnAtras;
        private Label label3;
    }
}