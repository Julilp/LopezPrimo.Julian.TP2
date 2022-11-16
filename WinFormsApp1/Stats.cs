using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Stats : Form
    {
        List<UsuariosHistorial> historial = new List<UsuariosHistorial>();
        List<UsuariosHistorial> listaAux = new List<UsuariosHistorial>();
        UsuariosHistorial unaPersona = new UsuariosHistorial();

        public Stats()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            
        }
        public List<UsuariosHistorial> SortTiempo(List<UsuariosHistorial> historial)
        {
            return listaAux=historial.OrderBy(d => d.tiempo).ToList();
        }

        private void Stats_Activated(object sender, EventArgs e)
        {
            string lineaGanador;
            TextReader leer = new StreamReader("ganadores.txt");
            historial.Clear();
            listBox1.Items.Clear();
            while (leer.ReadLine() is not null)
            {
                unaPersona = new UsuariosHistorial();
                lineaGanador = leer.ReadLine();
                unaPersona.usuario = lineaGanador.Split(",")[0];
                unaPersona.tiempo = lineaGanador.Split(",")[1];
                historial.Add(unaPersona);
            }
            historial = SortTiempo(historial);
            foreach (UsuariosHistorial item in historial)
            {
                listBox1.Items.Add(unaPersona.DevolverStringHistorial(item));
            }

            lablCampeon.Text = historial[0].usuario;
            lblSubCampeon.Text = historial[1].usuario;
            lblTercero.Text = historial[2].usuario;
        }
    }
}
