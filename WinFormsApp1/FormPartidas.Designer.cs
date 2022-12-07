
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonRojo = new System.Windows.Forms.Button();
            this.buttonAzul = new System.Windows.Forms.Button();
            this.buttonVerde = new System.Windows.Forms.Button();
            this.buttonAmarillo = new System.Windows.Forms.Button();
            this.labelcontador = new System.Windows.Forms.Label();
            this.botonUno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(0, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 468);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.vaciaroja;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = global::WinFormsApp1.Properties.Resources.vaciaroja;
            this.pictureBox1.Location = new System.Drawing.Point(574, 157);
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
            this.button1.Location = new System.Drawing.Point(293, 157);
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
            this.label1.Location = new System.Drawing.Point(609, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "10";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(877, 60);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(143, 468);
            this.listBox2.TabIndex = 6;
            this.listBox2.Visible = false;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Oswald SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(387, 399);
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
            this.buttonRojo.Location = new System.Drawing.Point(317, 483);
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
            this.buttonAzul.Location = new System.Drawing.Point(417, 483);
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
            this.buttonVerde.Location = new System.Drawing.Point(523, 483);
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
            this.buttonAmarillo.Location = new System.Drawing.Point(623, 483);
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
            this.labelcontador.Location = new System.Drawing.Point(432, 72);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(136, 32);
            this.labelcontador.TabIndex = 13;
            this.labelcontador.Text = "00:00:00";
            // 
            // botonUno
            // 
            this.botonUno.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.botonUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonUno.FlatAppearance.BorderSize = 0;
            this.botonUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonUno.Font = new System.Drawing.Font("Oswald SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonUno.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.botonUno.Location = new System.Drawing.Point(537, 399);
            this.botonUno.Name = "botonUno";
            this.botonUno.Size = new System.Drawing.Size(94, 43);
            this.botonUno.TabIndex = 14;
            this.botonUno.Text = "Uno";
            this.botonUno.UseVisualStyleBackColor = true;
            this.botonUno.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(450, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 47);
            this.label2.TabIndex = 15;
            this.label2.Text = "Uno!";
            this.label2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::WinFormsApp1.Properties.Resources.pregunta;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(293, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 42);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WinFormsApp1.Properties.Resources.Boton_negro;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Oswald SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(417, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 42);
            this.button3.TabIndex = 19;
            this.button3.Text = "Guardar y Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 31);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cartas jugador 1";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(785, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cartas jugador 2";
            this.label5.Visible = false;
            // 
            // FormPartidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 547);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonUno);
            this.Controls.Add(this.labelcontador);
            this.Controls.Add(this.buttonAmarillo);
            this.Controls.Add(this.buttonVerde);
            this.Controls.Add(this.buttonAzul);
            this.Controls.Add(this.buttonRojo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormPartidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonRojo;
        private System.Windows.Forms.Button buttonAzul;
        private System.Windows.Forms.Button buttonVerde;
        private System.Windows.Forms.Button buttonAmarillo;
        private System.Windows.Forms.Label labelcontador;
        private System.Windows.Forms.Button botonUno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}