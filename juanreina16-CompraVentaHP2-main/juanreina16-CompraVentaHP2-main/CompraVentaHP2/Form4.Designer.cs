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
            txtferrari = new TextBox();
            txtlambo = new TextBox();
            txtvol = new TextBox();
            txtgo = new TextBox();
            label2 = new Label();
            btnfac = new Button();
            dtgvproductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Ferrari = new DataGridViewTextBoxColumn();
            Lamborghini = new DataGridViewTextBoxColumn();
            Volkswagen = new DataGridViewTextBoxColumn();
            Twingo = new DataGridViewTextBoxColumn();
            lbimpresion = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvproductos).BeginInit();
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
            // txtferrari
            // 
            txtferrari.Location = new Point(179, 88);
            txtferrari.Name = "txtferrari";
            txtferrari.Size = new Size(47, 23);
            txtferrari.TabIndex = 3;
            // 
            // txtlambo
            // 
            txtlambo.Location = new Point(179, 135);
            txtlambo.Name = "txtlambo";
            txtlambo.Size = new Size(47, 23);
            txtlambo.TabIndex = 4;
            // 
            // txtvol
            // 
            txtvol.Location = new Point(179, 178);
            txtvol.Name = "txtvol";
            txtvol.Size = new Size(47, 23);
            txtvol.TabIndex = 5;
            // 
            // txtgo
            // 
            txtgo.Location = new Point(179, 219);
            txtgo.Name = "txtgo";
            txtgo.Size = new Size(47, 23);
            txtgo.TabIndex = 6;
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
            // btnfac
            // 
            btnfac.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnfac.ForeColor = Color.FromArgb(0, 192, 0);
            btnfac.Location = new Point(651, 62);
            btnfac.Name = "btnfac";
            btnfac.Size = new Size(84, 49);
            btnfac.TabIndex = 20;
            btnfac.Text = "Factura";
            btnfac.UseVisualStyleBackColor = true;
            btnfac.Click += btnfac_Click;
            // 
            // dtgvproductos
            // 
            dtgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvproductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Documento, Telefono, Ferrari, Lamborghini, Volkswagen, Twingo });
            dtgvproductos.Location = new Point(281, 142);
            dtgvproductos.Name = "dtgvproductos";
            dtgvproductos.RowTemplate.Height = 25;
            dtgvproductos.Size = new Size(504, 219);
            dtgvproductos.TabIndex = 22;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Documento
            // 
            Documento.HeaderText = "Documento";
            Documento.Name = "Documento";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Ferrari
            // 
            Ferrari.HeaderText = "Ferrari";
            Ferrari.Name = "Ferrari";
            // 
            // Lamborghini
            // 
            Lamborghini.HeaderText = "Lamborghini";
            Lamborghini.Name = "Lamborghini";
            // 
            // Volkswagen
            // 
            Volkswagen.HeaderText = "Volkswagen";
            Volkswagen.Name = "Volkswagen";
            // 
            // Twingo
            // 
            Twingo.HeaderText = "Twingo";
            Twingo.Name = "Twingo";
            // 
            // lbimpresion
            // 
            lbimpresion.AutoSize = true;
            lbimpresion.Location = new Point(327, 155);
            lbimpresion.Name = "lbimpresion";
            lbimpresion.Size = new Size(0, 15);
            lbimpresion.TabIndex = 21;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(793, 365);
            Controls.Add(dtgvproductos);
            Controls.Add(lbimpresion);
            Controls.Add(btnfac);
            Controls.Add(label2);
            Controls.Add(txtgo);
            Controls.Add(txtvol);
            Controls.Add(txtlambo);
            Controls.Add(txtferrari);
            Controls.Add(fff);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvproductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox fff;
        private TextBox txtferrari;
        private TextBox txtlambo;
        private TextBox txtvol;
        private TextBox txtgo;
        private Label label2;
        private Button btnfac;
        private DataGridView dtgvproductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Ferrari;
        private DataGridViewTextBoxColumn Lamborghini;
        private DataGridViewTextBoxColumn Volkswagen;
        private DataGridViewTextBoxColumn Twingo;
        private Label lbimpresion;
    }
}