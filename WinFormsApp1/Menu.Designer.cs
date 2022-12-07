
namespace WinFormsApp1
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnVerSala = new System.Windows.Forms.Button();
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3stat = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panelStats);
            this.panel1.Controls.Add(this.btnEstadistica);
            this.panel1.Controls.Add(this.btnVerSala);
            this.panel1.Controls.Add(this.btnCrearSala);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 574);
            this.panel1.TabIndex = 0;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.Transparent;
            this.panelStats.Location = new System.Drawing.Point(134, 101);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(910, 473);
            this.panelStats.TabIndex = 9;
            this.panelStats.Visible = false;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.BackColor = System.Drawing.Color.Black;
            this.btnEstadistica.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadistica.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEstadistica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadistica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstadistica.Location = new System.Drawing.Point(0, 211);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(134, 46);
            this.btnEstadistica.TabIndex = 7;
            this.btnEstadistica.Text = "Estadisticas";
            this.btnEstadistica.UseVisualStyleBackColor = false;
            this.btnEstadistica.Click += new System.EventHandler(this.btnEstadistica_Click);
            // 
            // btnVerSala
            // 
            this.btnVerSala.BackColor = System.Drawing.Color.Black;
            this.btnVerSala.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerSala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerSala.FlatAppearance.BorderSize = 0;
            this.btnVerSala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnVerSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnVerSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSala.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerSala.Location = new System.Drawing.Point(0, 165);
            this.btnVerSala.Name = "btnVerSala";
            this.btnVerSala.Size = new System.Drawing.Size(134, 46);
            this.btnVerSala.TabIndex = 6;
            this.btnVerSala.Text = "Ver Salas";
            this.btnVerSala.UseVisualStyleBackColor = false;
            this.btnVerSala.Click += new System.EventHandler(this.btnVerSala_Click);
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.BackColor = System.Drawing.Color.Black;
            this.btnCrearSala.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCrearSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearSala.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrearSala.FlatAppearance.BorderSize = 0;
            this.btnCrearSala.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCrearSala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCrearSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearSala.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearSala.Location = new System.Drawing.Point(0, 119);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(134, 46);
            this.btnCrearSala.TabIndex = 2;
            this.btnCrearSala.Text = "Crear Sala";
            this.btnCrearSala.UseVisualStyleBackColor = false;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WinFormsApp1.Properties.Resources.PhotoRoom_20220923_063253_p__m_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WinFormsApp1.Properties.Resources.Uno_removebg_preview;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(134, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(910, 101);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "UsuarioText";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(910, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "      Usuario   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(540, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "FechaText";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(134, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 473);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // panel3stat
            // 
            this.panel3stat.Location = new System.Drawing.Point(134, 1);
            this.panel3stat.Name = "panel3stat";
            this.panel3stat.Size = new System.Drawing.Size(910, 573);
            this.panel3stat.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(70)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1044, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3stat);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearSala;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnVerSala;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3stat;
    }
}