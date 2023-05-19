namespace CompraVentaHP2
{
    partial class Form4
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
            fff = new ListBox();
            txtfer = new TextBox();
            txtlam = new TextBox();
            txtvolk = new TextBox();
            txttwi = new TextBox();
            label2 = new Label();
            lbimpresion = new Label();
            txtnom2 = new TextBox();
            txtape2 = new TextBox();
            txtdoc2 = new TextBox();
            txtfono2 = new TextBox();
            txtferrari2 = new TextBox();
            txtlam2 = new TextBox();
            txtvol2 = new TextBox();
            txtgo2 = new TextBox();
            btncerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // fff
            // 
            fff.BackColor = Color.LightGray;
            fff.BorderStyle = BorderStyle.None;
            fff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fff.FormattingEnabled = true;
            fff.ItemHeight = 20;
            fff.Items.AddRange(new object[] { "Ferrari ", "", "Lamborghini", "", "Volkswagen ", "", "Twingo " });
            fff.Location = new Point(37, 88);
            fff.Name = "fff";
            fff.Size = new Size(123, 140);
            fff.TabIndex = 2;
            fff.SelectedIndexChanged += fff_SelectedIndexChanged;
            // 
            // txtfer
            // 
            txtfer.Location = new Point(179, 88);
            txtfer.Name = "txtfer";
            txtfer.Size = new Size(47, 23);
            txtfer.TabIndex = 3;
            // 
            // txtlam
            // 
            txtlam.Location = new Point(179, 135);
            txtlam.Name = "txtlam";
            txtlam.Size = new Size(47, 23);
            txtlam.TabIndex = 4;
            // 
            // txtvolk
            // 
            txtvolk.Location = new Point(179, 178);
            txtvolk.Name = "txtvolk";
            txtvolk.Size = new Size(47, 23);
            txtvolk.TabIndex = 5;
            // 
            // txttwi
            // 
            txttwi.Location = new Point(179, 219);
            txttwi.Name = "txttwi";
            txttwi.Size = new Size(47, 23);
            txttwi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(368, 47);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 7;
            label2.Text = "Mostrador de facturas";
            // 
            // lbimpresion
            // 
            lbimpresion.AutoSize = true;
            lbimpresion.Location = new Point(327, 155);
            lbimpresion.Name = "lbimpresion";
            lbimpresion.Size = new Size(0, 15);
            lbimpresion.TabIndex = 21;
            // 
            // txtnom2
            // 
            txtnom2.Location = new Point(368, 88);
            txtnom2.Name = "txtnom2";
            txtnom2.Size = new Size(200, 23);
            txtnom2.TabIndex = 22;
            // 
            // txtape2
            // 
            txtape2.Location = new Point(368, 135);
            txtape2.Name = "txtape2";
            txtape2.Size = new Size(200, 23);
            txtape2.TabIndex = 23;
            // 
            // txtdoc2
            // 
            txtdoc2.Location = new Point(368, 178);
            txtdoc2.Name = "txtdoc2";
            txtdoc2.Size = new Size(200, 23);
            txtdoc2.TabIndex = 24;
            // 
            // txtfono2
            // 
            txtfono2.Location = new Point(368, 219);
            txtfono2.Name = "txtfono2";
            txtfono2.Size = new Size(200, 23);
            txtfono2.TabIndex = 25;
            // 
            // txtferrari2
            // 
            txtferrari2.Location = new Point(368, 263);
            txtferrari2.Name = "txtferrari2";
            txtferrari2.Size = new Size(200, 23);
            txtferrari2.TabIndex = 26;
            // 
            // txtlam2
            // 
            txtlam2.Location = new Point(368, 303);
            txtlam2.Name = "txtlam2";
            txtlam2.Size = new Size(200, 23);
            txtlam2.TabIndex = 27;
            // 
            // txtvol2
            // 
            txtvol2.Location = new Point(368, 344);
            txtvol2.Name = "txtvol2";
            txtvol2.Size = new Size(200, 23);
            txtvol2.TabIndex = 28;
            // 
            // txtgo2
            // 
            txtgo2.Location = new Point(368, 382);
            txtgo2.Name = "txtgo2";
            txtgo2.Size = new Size(200, 23);
            txtgo2.TabIndex = 29;
            // 
            // btncerrar
            // 
            btncerrar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btncerrar.ForeColor = Color.FromArgb(0, 192, 0);
            btncerrar.Location = new Point(645, 237);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(84, 49);
            btncerrar.TabIndex = 30;
            btncerrar.Text = "Cerrar";
            btncerrar.UseVisualStyleBackColor = true;
            btncerrar.Click += btncerrar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(793, 434);
            Controls.Add(btncerrar);
            Controls.Add(txtgo2);
            Controls.Add(txtvol2);
            Controls.Add(txtlam2);
            Controls.Add(txtferrari2);
            Controls.Add(txtfono2);
            Controls.Add(txtdoc2);
            Controls.Add(txtape2);
            Controls.Add(txtnom2);
            Controls.Add(lbimpresion);
            Controls.Add(label2);
            Controls.Add(txttwi);
            Controls.Add(txtvolk);
            Controls.Add(txtlam);
            Controls.Add(txtfer);
            Controls.Add(fff);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox fff;
        private TextBox txtfer;
        private TextBox txtlam;
        private TextBox txtvolk;
        private TextBox txttwi;
        private Label label2;
        private Label lbimpresion;
        public TextBox txtnom2;
        public TextBox txtape2;
        public TextBox txtdoc2;
        public TextBox txtfono2;
        public TextBox txtferrari2;
        public TextBox txtlam2;
        public TextBox txtvol2;
        public TextBox txtgo2;
        private Button btncerrar;
    }
}