namespace CompraVentaHP2
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            txtnom = new TextBox();
            txtape = new TextBox();
            txtdoc = new TextBox();
            txtfono = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            txtCantidad = new TextBox();
            txtlam = new TextBox();
            txtvol = new TextBox();
            txtgo = new TextBox();
            lbimpresion = new Label();
            btncomprar = new Button();
            dtgvproductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Ferrari = new DataGridViewTextBoxColumn();
            Lamborghini = new DataGridViewTextBoxColumn();
            Precioo = new DataGridViewTextBoxColumn();
            Pago = new DataGridViewTextBoxColumn();
            btnvisualizar = new Button();
            btnExport = new Button();
            cboProducto = new ComboBox();
            lblResultado = new Label();
            lblFecha = new Label();
            rdAmerican = new RadioButton();
            rdGana = new RadioButton();
            label6 = new Label();
            cboTipo = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvproductos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(32, 83);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(108, 24);
            label3.TabIndex = 2;
            label3.Text = "Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(32, 204);
            label4.Name = "label4";
            label4.Size = new Size(85, 24);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtnom
            // 
            txtnom.Location = new Point(32, 56);
            txtnom.Name = "txtnom";
            txtnom.Size = new Size(94, 23);
            txtnom.TabIndex = 4;
            // 
            // txtape
            // 
            txtape.Location = new Point(32, 107);
            txtape.Name = "txtape";
            txtape.Size = new Size(94, 23);
            txtape.TabIndex = 5;
            // 
            // txtdoc
            // 
            txtdoc.Location = new Point(32, 167);
            txtdoc.Name = "txtdoc";
            txtdoc.Size = new Size(94, 23);
            txtdoc.TabIndex = 6;
            // 
            // txtfono
            // 
            txtfono.Location = new Point(32, 230);
            txtfono.Name = "txtfono";
            txtfono.Size = new Size(94, 23);
            txtfono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(155, 38);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 8;
            label5.Text = "Tipo de vehículos";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(632, 97);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 20);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Ferrari ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Mongolian Baiti", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(632, 123);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 20);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Lamborghini";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Mongolian Baiti", 12F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox3.Location = new Point(632, 149);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(106, 20);
            checkBox3.TabIndex = 11;
            checkBox3.Text = "Volkswagen";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(632, 173);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(76, 20);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "Twingo";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(186, 168);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(94, 23);
            txtCantidad.TabIndex = 13;
            // 
            // txtlam
            // 
            txtlam.Location = new Point(533, 107);
            txtlam.Name = "txtlam";
            txtlam.Size = new Size(94, 23);
            txtlam.TabIndex = 14;
            // 
            // txtvol
            // 
            txtvol.Location = new Point(533, 143);
            txtvol.Name = "txtvol";
            txtvol.Size = new Size(94, 23);
            txtvol.TabIndex = 15;
            // 
            // txtgo
            // 
            txtgo.Location = new Point(533, 175);
            txtgo.Name = "txtgo";
            txtgo.Size = new Size(94, 23);
            txtgo.TabIndex = 16;
            // 
            // lbimpresion
            // 
            lbimpresion.AutoSize = true;
            lbimpresion.Location = new Point(376, 169);
            lbimpresion.Name = "lbimpresion";
            lbimpresion.Size = new Size(0, 15);
            lbimpresion.TabIndex = 17;
            // 
            // btncomprar
            // 
            btncomprar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btncomprar.ForeColor = Color.FromArgb(0, 192, 0);
            btncomprar.Location = new Point(776, 122);
            btncomprar.Name = "btncomprar";
            btncomprar.Size = new Size(81, 60);
            btncomprar.TabIndex = 19;
            btncomprar.Text = "Comprar";
            btncomprar.UseVisualStyleBackColor = true;
            btncomprar.Click += btncomprar_Click;
            // 
            // dtgvproductos
            // 
            dtgvproductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvproductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Documento, Telefono, Ferrari, Lamborghini, Precioo, Pago });
            dtgvproductos.Location = new Point(-1, 274);
            dtgvproductos.Name = "dtgvproductos";
            dtgvproductos.RowTemplate.Height = 25;
            dtgvproductos.Size = new Size(898, 210);
            dtgvproductos.TabIndex = 20;
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
            Ferrari.HeaderText = "Vehiculo";
            Ferrari.Name = "Ferrari";
            // 
            // Lamborghini
            // 
            Lamborghini.HeaderText = "Cantidad";
            Lamborghini.Name = "Lamborghini";
            // 
            // Precioo
            // 
            Precioo.HeaderText = "Total";
            Precioo.Name = "Precioo";
            // 
            // Pago
            // 
            Pago.HeaderText = "Metodo de pago";
            Pago.Name = "Pago";
            // 
            // btnvisualizar
            // 
            btnvisualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnvisualizar.ForeColor = Color.FromArgb(192, 0, 192);
            btnvisualizar.Location = new Point(757, 41);
            btnvisualizar.Name = "btnvisualizar";
            btnvisualizar.Size = new Size(100, 49);
            btnvisualizar.TabIndex = 21;
            btnvisualizar.Text = "Ver inventario";
            btnvisualizar.UseVisualStyleBackColor = true;
            btnvisualizar.Click += btnvisualizar_Click;
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnExport.ForeColor = Color.Blue;
            btnExport.Location = new Point(697, 220);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(179, 33);
            btnExport.TabIndex = 22;
            btnExport.Text = "Imprimir factura/s";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Ferrari", "Lamborghini", "Volkswagen", "Twingo" });
            cboProducto.Location = new Point(172, 67);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(121, 23);
            cboProducto.TabIndex = 23;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(299, 75);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(40, 15);
            lblResultado.TabIndex = 24;
            lblResultado.Text = "Precio";
            lblResultado.Click += lblPrecio_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 25;
            lblFecha.Text = "label6";
            // 
            // rdAmerican
            // 
            rdAmerican.AutoSize = true;
            rdAmerican.Location = new Point(376, 148);
            rdAmerican.Name = "rdAmerican";
            rdAmerican.Size = new Size(118, 19);
            rdAmerican.TabIndex = 26;
            rdAmerican.TabStop = true;
            rdAmerican.Text = "American Express";
            rdAmerican.UseVisualStyleBackColor = true;
            // 
            // rdGana
            // 
            rdGana.AutoSize = true;
            rdGana.Location = new Point(376, 173);
            rdGana.Name = "rdGana";
            rdGana.Size = new Size(52, 19);
            rdGana.TabIndex = 27;
            rdGana.TabStop = true;
            rdGana.Text = "Gana";
            rdGana.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 143);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 28;
            label6.Text = "Cantidad";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Amarillo", "Azul", "Rojo", "Atletico Nacional", "Deportivo Pasto" });
            cboTipo.Location = new Point(395, 67);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(395, 38);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 30;
            label7.Text = "Diseño";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(888, 466);
            Controls.Add(label7);
            Controls.Add(cboTipo);
            Controls.Add(label6);
            Controls.Add(rdGana);
            Controls.Add(rdAmerican);
            Controls.Add(lblFecha);
            Controls.Add(lblResultado);
            Controls.Add(cboProducto);
            Controls.Add(btnExport);
            Controls.Add(btnvisualizar);
            Controls.Add(dtgvproductos);
            Controls.Add(btncomprar);
            Controls.Add(lbimpresion);
            Controls.Add(txtgo);
            Controls.Add(txtvol);
            Controls.Add(txtlam);
            Controls.Add(txtCantidad);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label5);
            Controls.Add(txtfono);
            Controls.Add(txtdoc);
            Controls.Add(txtape);
            Controls.Add(txtnom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Proceso de compra";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvproductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Label lbimpresion;
        private Button btncomprar;
        public Button btnvisualizar;
        public DataGridView dtgvproductos;
        public TextBox txtnom;
        public TextBox txtape;
        public TextBox txtdoc;
        public TextBox txtfono;
        public TextBox txtferrari;
        public TextBox txtlam;
        public TextBox txtvol;
        public TextBox txtgo;
        private Button btnExport;
        private ComboBox cboProducto;
        private Label lblPrecio;
        private Label lblFecha;
        private RadioButton rdAmerican;
        private RadioButton rdGana;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Ferrari;
        private DataGridViewTextBoxColumn Lamborghini;
        private DataGridViewTextBoxColumn Precioo;
        private DataGridViewTextBoxColumn Pago;
        public TextBox txtCantidad;
        private Label label6;
        private ComboBox cboTipo;
        private Label label7;
        private Label lblResultado;
    }
}