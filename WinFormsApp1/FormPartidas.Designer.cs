
namespace WinFormsApp1
{
    partial class FormPartidas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRojo = new System.Windows.Forms.Button();
            this.buttonAzul = new System.Windows.Forms.Button();
            this.buttonVerde = new System.Windows.Forms.Button();
            this.buttonAmarillo = new System.Windows.Forms.Button();
            this.labelcontador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 458);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.vaciaroja;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::WinFormsApp1.Properties.Resources.vaciaroja;
            this.pictureBox1.Location = new System.Drawing.Point(444, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WinFormsApp1.Properties.Resources.dadavuelta1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(205, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 190);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(477, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "10";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Guardar y Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(663, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 458);
            this.listBox2.TabIndex = 6;
            this.listBox2.Visible = false;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "Paso";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonRojo
            // 
            this.buttonRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(11)))), ((int)(((byte)(0)))));
            this.buttonRojo.FlatAppearance.BorderSize = 0;
            this.buttonRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRojo.Location = new System.Drawing.Point(205, 390);
            this.buttonRojo.Name = "buttonRojo";
            this.buttonRojo.Size = new System.Drawing.Size(94, 43);
            this.buttonRojo.TabIndex = 9;
            this.buttonRojo.UseVisualStyleBackColor = false;
            this.buttonRojo.Visible = false;
            this.buttonRojo.Click += new System.EventHandler(this.buttonRojo_Click);
            // 
            // buttonAzul
            // 
            this.buttonAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(74)))), ((int)(((byte)(164)))));
            this.buttonAzul.FlatAppearance.BorderSize = 0;
            this.buttonAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAzul.Location = new System.Drawing.Point(305, 390);
            this.buttonAzul.Name = "buttonAzul";
            this.buttonAzul.Size = new System.Drawing.Size(94, 43);
            this.buttonAzul.TabIndex = 10;
            this.buttonAzul.UseVisualStyleBackColor = false;
            this.buttonAzul.Visible = false;
            this.buttonAzul.Click += new System.EventHandler(this.buttonAzul_Click);
            // 
            // buttonVerde
            // 
            this.buttonVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(138)))), ((int)(((byte)(16)))));
            this.buttonVerde.FlatAppearance.BorderSize = 0;
            this.buttonVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerde.Location = new System.Drawing.Point(411, 390);
            this.buttonVerde.Name = "buttonVerde";
            this.buttonVerde.Size = new System.Drawing.Size(94, 43);
            this.buttonVerde.TabIndex = 11;
            this.buttonVerde.UseVisualStyleBackColor = false;
            this.buttonVerde.Visible = false;
            this.buttonVerde.Click += new System.EventHandler(this.buttonVerde_Click);
            // 
            // buttonAmarillo
            // 
            this.buttonAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(207)))), ((int)(((byte)(3)))));
            this.buttonAmarillo.FlatAppearance.BorderSize = 0;
            this.buttonAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAmarillo.Location = new System.Drawing.Point(511, 390);
            this.buttonAmarillo.Name = "buttonAmarillo";
            this.buttonAmarillo.Size = new System.Drawing.Size(94, 43);
            this.buttonAmarillo.TabIndex = 12;
            this.buttonAmarillo.UseVisualStyleBackColor = false;
            this.buttonAmarillo.Visible = false;
            this.buttonAmarillo.Click += new System.EventHandler(this.buttonAmarillo_Click);
            // 
            // labelcontador
            // 
            this.labelcontador.AutoSize = true;
            this.labelcontador.BackColor = System.Drawing.Color.Transparent;
            this.labelcontador.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelcontador.ForeColor = System.Drawing.Color.White;
            this.labelcontador.Location = new System.Drawing.Point(338, 9);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(136, 32);
            this.labelcontador.TabIndex = 13;
            this.labelcontador.Text = "00:00:00";
            // 
            // FormPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.fondo_mesa__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 458);
            this.Controls.Add(this.labelcontador);
            this.Controls.Add(this.buttonAmarillo);
            this.Controls.Add(this.buttonVerde);
            this.Controls.Add(this.buttonAzul);
            this.Controls.Add(this.buttonRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(822, 497);
            this.MinimumSize = new System.Drawing.Size(822, 497);
            this.Name = "FormPartidas";
            this.Text = "SalasDisponibles";
            this.Load += new System.EventHandler(this.FormPartidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonRojo;
        private System.Windows.Forms.Button buttonAzul;
        private System.Windows.Forms.Button buttonVerde;
        private System.Windows.Forms.Button buttonAmarillo;
        private System.Windows.Forms.Label labelcontador;
    }
}