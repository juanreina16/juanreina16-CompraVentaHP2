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
            this.btnf1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fff = new System.Windows.Forms.ListBox();
            this.txtferrari = new System.Windows.Forms.TextBox();
            this.txtlambo = new System.Windows.Forms.TextBox();
            this.txtvol = new System.Windows.Forms.TextBox();
            this.txtgo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbf1 = new System.Windows.Forms.Label();
            this.lbf2 = new System.Windows.Forms.Label();
            this.lbf3 = new System.Windows.Forms.Label();
            this.lbf4 = new System.Windows.Forms.Label();
            this.lbf6 = new System.Windows.Forms.Label();
            this.lbf5 = new System.Windows.Forms.Label();
            this.btnf2 = new System.Windows.Forms.Button();
            this.btnf3 = new System.Windows.Forms.Button();
            this.btnf4 = new System.Windows.Forms.Button();
            this.btnf5 = new System.Windows.Forms.Button();
            this.btnf6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnf1
            // 
            this.btnf1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf1.Location = new System.Drawing.Point(281, 88);
            this.btnf1.Name = "btnf1";
            this.btnf1.Size = new System.Drawing.Size(92, 45);
            this.btnf1.TabIndex = 0;
            this.btnf1.Text = "Factura 1";
            this.btnf1.UseVisualStyleBackColor = true;
            this.btnf1.Click += new System.EventHandler(this.btnf1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventario";
            // 
            // fff
            // 
            this.fff.BackColor = System.Drawing.Color.LightGray;
            this.fff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fff.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fff.FormattingEnabled = true;
            this.fff.ItemHeight = 22;
            this.fff.Items.AddRange(new object[] {
            "Ferrari ",
            "",
            "Lamborghini",
            "",
            "Volkswagen ",
            "",
            "Twingo "});
            this.fff.Location = new System.Drawing.Point(37, 88);
            this.fff.Name = "fff";
            this.fff.Size = new System.Drawing.Size(123, 154);
            this.fff.TabIndex = 2;
            this.fff.SelectedIndexChanged += new System.EventHandler(this.fff_SelectedIndexChanged);
            // 
            // txtferrari
            // 
            this.txtferrari.Location = new System.Drawing.Point(179, 88);
            this.txtferrari.Name = "txtferrari";
            this.txtferrari.Size = new System.Drawing.Size(47, 23);
            this.txtferrari.TabIndex = 3;
            // 
            // txtlambo
            // 
            this.txtlambo.Location = new System.Drawing.Point(179, 135);
            this.txtlambo.Name = "txtlambo";
            this.txtlambo.Size = new System.Drawing.Size(47, 23);
            this.txtlambo.TabIndex = 4;
            // 
            // txtvol
            // 
            this.txtvol.Location = new System.Drawing.Point(179, 178);
            this.txtvol.Name = "txtvol";
            this.txtvol.Size = new System.Drawing.Size(47, 23);
            this.txtvol.TabIndex = 5;
            // 
            // txtgo
            // 
            this.txtgo.Location = new System.Drawing.Point(179, 219);
            this.txtgo.Name = "txtgo";
            this.txtgo.Size = new System.Drawing.Size(47, 23);
            this.txtgo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(281, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mostrador de facturas";
            // 
            // lbf1
            // 
            this.lbf1.AutoSize = true;
            this.lbf1.Location = new System.Drawing.Point(444, 96);
            this.lbf1.Name = "lbf1";
            this.lbf1.Size = new System.Drawing.Size(55, 15);
            this.lbf1.TabIndex = 8;
            this.lbf1.Text = "Factura 1";
            // 
            // lbf2
            // 
            this.lbf2.AutoSize = true;
            this.lbf2.Location = new System.Drawing.Point(586, 96);
            this.lbf2.Name = "lbf2";
            this.lbf2.Size = new System.Drawing.Size(55, 15);
            this.lbf2.TabIndex = 9;
            this.lbf2.Text = "Factura 2";
            // 
            // lbf3
            // 
            this.lbf3.AutoSize = true;
            this.lbf3.Location = new System.Drawing.Point(741, 96);
            this.lbf3.Name = "lbf3";
            this.lbf3.Size = new System.Drawing.Size(55, 15);
            this.lbf3.TabIndex = 10;
            this.lbf3.Text = "Factura 3";
            // 
            // lbf4
            // 
            this.lbf4.AutoSize = true;
            this.lbf4.Location = new System.Drawing.Point(444, 276);
            this.lbf4.Name = "lbf4";
            this.lbf4.Size = new System.Drawing.Size(55, 15);
            this.lbf4.TabIndex = 11;
            this.lbf4.Text = "Factura 4";
            // 
            // lbf6
            // 
            this.lbf6.AutoSize = true;
            this.lbf6.Location = new System.Drawing.Point(741, 276);
            this.lbf6.Name = "lbf6";
            this.lbf6.Size = new System.Drawing.Size(55, 15);
            this.lbf6.TabIndex = 12;
            this.lbf6.Text = "Factura 6";
            // 
            // lbf5
            // 
            this.lbf5.AutoSize = true;
            this.lbf5.Location = new System.Drawing.Point(586, 276);
            this.lbf5.Name = "lbf5";
            this.lbf5.Size = new System.Drawing.Size(55, 15);
            this.lbf5.TabIndex = 13;
            this.lbf5.Text = "Factura 5";
            // 
            // btnf2
            // 
            this.btnf2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf2.Location = new System.Drawing.Point(281, 139);
            this.btnf2.Name = "btnf2";
            this.btnf2.Size = new System.Drawing.Size(92, 45);
            this.btnf2.TabIndex = 18;
            this.btnf2.Text = "Factura 2";
            this.btnf2.UseVisualStyleBackColor = true;
            this.btnf2.Click += new System.EventHandler(this.btnf2_Click);
            // 
            // btnf3
            // 
            this.btnf3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf3.Location = new System.Drawing.Point(281, 195);
            this.btnf3.Name = "btnf3";
            this.btnf3.Size = new System.Drawing.Size(92, 45);
            this.btnf3.TabIndex = 19;
            this.btnf3.Text = "Factura 3";
            this.btnf3.UseVisualStyleBackColor = true;
            this.btnf3.Click += new System.EventHandler(this.btnf3_Click);
            // 
            // btnf4
            // 
            this.btnf4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf4.Location = new System.Drawing.Point(281, 246);
            this.btnf4.Name = "btnf4";
            this.btnf4.Size = new System.Drawing.Size(92, 45);
            this.btnf4.TabIndex = 20;
            this.btnf4.Text = "Factura 4";
            this.btnf4.UseVisualStyleBackColor = true;
            this.btnf4.Click += new System.EventHandler(this.btnf4_Click);
            // 
            // btnf5
            // 
            this.btnf5.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf5.Location = new System.Drawing.Point(281, 297);
            this.btnf5.Name = "btnf5";
            this.btnf5.Size = new System.Drawing.Size(92, 45);
            this.btnf5.TabIndex = 21;
            this.btnf5.Text = "Factura 5";
            this.btnf5.UseVisualStyleBackColor = true;
            this.btnf5.Click += new System.EventHandler(this.btnf5_Click);
            // 
            // btnf6
            // 
            this.btnf6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnf6.Location = new System.Drawing.Point(281, 361);
            this.btnf6.Name = "btnf6";
            this.btnf6.Size = new System.Drawing.Size(92, 45);
            this.btnf6.TabIndex = 22;
            this.btnf6.Text = "Factura 6";
            this.btnf6.UseVisualStyleBackColor = true;
            this.btnf6.Click += new System.EventHandler(this.btnf6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(892, 490);
            this.Controls.Add(this.btnf6);
            this.Controls.Add(this.btnf5);
            this.Controls.Add(this.btnf4);
            this.Controls.Add(this.btnf3);
            this.Controls.Add(this.btnf2);
            this.Controls.Add(this.lbf5);
            this.Controls.Add(this.lbf6);
            this.Controls.Add(this.lbf4);
            this.Controls.Add(this.lbf3);
            this.Controls.Add(this.lbf2);
            this.Controls.Add(this.lbf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgo);
            this.Controls.Add(this.txtvol);
            this.Controls.Add(this.txtlambo);
            this.Controls.Add(this.txtferrari);
            this.Controls.Add(this.fff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnf1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnf1;
        private Label label1;
        private ListBox fff;
        private TextBox txtferrari;
        private TextBox txtlambo;
        private TextBox txtvol;
        private TextBox txtgo;
        private Label label2;
        private Label lbf1;
        private Label lbf2;
        private Label lbf3;
        private Label lbf4;
        private Label lbf6;
        private Label lbf5;
        private Button btnf2;
        private Button btnf3;
        private Button btnf4;
        private Button btnf5;
        private Button btnf6;
    }
}