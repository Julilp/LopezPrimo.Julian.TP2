using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private ConexionDeUsuarios baseDeDatos = new ConexionDeUsuarios();
        Usuario persona = new Usuario();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            labelAsterisco1.Visible = true;
            labelAsterisco2.Visible = true;
            labelCompletar1.Visible = true;
            labelCompletar2.Visible = true;
            buttonGuardar.Visible = true;
            buttonCancelar.Visible = true;
            textBoxContraseña.Text = "";
            textBoxUsuario.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            labelAsterisco1.Visible = false;
            labelAsterisco2.Visible = false;
            labelCompletar1.Visible = false;
            labelCompletar2.Visible = false;
            buttonGuardar.Visible = false;
            buttonCancelar.Visible = false;
            textBoxContraseña.Text = "";
            textBoxUsuario.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.contrasenia = textBoxContraseña.Text;
            persona.nombre = textBoxUsuario.Text;
           if(baseDeDatos.insert(persona) ==true)
            {
                Menu frm = new Menu();
                this.Hide();
                frm.creador = textBoxUsuario.Text;
                frm.ShowDialog();
            }
           else
            {
                label6.Visible = true;
                textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";

            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(baseDeDatos.RegistrarUsuario(persona) ==true)
            {
                label5.Visible = true;
                labelAsterisco1.Visible = false;
                labelAsterisco2.Visible = false;
                labelCompletar1.Visible = false;
                labelCompletar2.Visible = false;
                buttonGuardar.Visible = false;
                buttonCancelar.Visible = false;
                textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";
            }
            else
            {
                label4.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
