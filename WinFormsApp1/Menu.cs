using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace WinFormsApp1
{
    
    public partial class Menu : Form
    {
        public string creador;
        conexion BaseDeDatos = new conexion();
        FormPartidas frmpartida = new FormPartidas();
        SalasCreadas formSala = new SalasCreadas();
        Stats formStats = new Stats();

        public Menu()
        {
            InitializeComponent();
        }

        private void btnVerSala_Click(object sender, EventArgs e)
        {
            formSala.TopLevel = false;
            panel2.Controls.Add(formSala);
            formSala.Show();
            panel2.Visible = true;
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            Sala nuevaSala = new Sala(creador);
            BaseDeDatos.insert(nuevaSala);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DateTime hoy = new DateTime();
            hoy = DateTime.Today;
            label1.Text = creador;
            label2.Text = hoy.ToString("D");
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            formStats.ShowDialog();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();           
        }
    }
}
