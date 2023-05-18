namespace CompraVentaHP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnusu = new Button();
            btnadmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(70, 87);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 0;
            label1.Text = "Elija la función que quiera desempeñar";
            label1.Click += label1_Click;
            // 
            // btnusu
            // 
            btnusu.BackColor = Color.FromArgb(224, 224, 224);
            btnusu.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnusu.ForeColor = Color.FromArgb(255, 128, 128);
            btnusu.Location = new Point(225, 134);
            btnusu.Name = "btnusu";
            btnusu.Size = new Size(131, 43);
            btnusu.TabIndex = 1;
            btnusu.Text = "Usuario";
            btnusu.UseVisualStyleBackColor = false;
            btnusu.Click += btnusu_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.FromArgb(224, 224, 224);
            btnadmin.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnadmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            btnadmin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnadmin.ForeColor = Color.FromArgb(0, 192, 0);
            btnadmin.Location = new Point(44, 134);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(127, 43);
            btnadmin.TabIndex = 2;
            btnadmin.Text = "Administrador";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(412, 242);
            Controls.Add(btnadmin);
            Controls.Add(btnusu);
            Controls.Add(label1);
            ForeColor = Color.LightGray;
            Name = "Form1";
            Text = "Opciones a desempeñar";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnusu;
        private Button btnadmin;
    }
}