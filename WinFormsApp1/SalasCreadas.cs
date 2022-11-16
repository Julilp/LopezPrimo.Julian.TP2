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
 using System.Threading;

namespace WinFormsApp1
{
    public partial class SalasCreadas : Form
    {
        conexion BaseDeDatos = new conexion();
        List<Sala> salas = new List<Sala>();
        List<Sala> listaAux = new List<Sala>();
        public delegate List<Sala> delegadoSort(List<Sala> salas,int index);
        delegadoSort funcionesSort;

        public SalasCreadas()
        {
            InitializeComponent();
            funcionesSort += Sorts;
        }

        private void SalasCreadas_Load(object sender, EventArgs e)
        {
            salas = BaseDeDatos.DevolverSalas();
            foreach (Sala item in this.salas)
            {
                dataGridView1.Rows.Add(Sala.devolverSalaString(item));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormPartidas formPartidas = new FormPartidas();
            if(dataGridView1.CurrentRow.Cells["Estado"].Value.ToString()=="En Partida")
            {
                formPartidas.idSala = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                formPartidas.stTiempo = dataGridView1.CurrentRow.Cells["TiempoDeJuego"].Value.ToString();
                formPartidas.creador = dataGridView1.CurrentRow.Cells["Creador"].Value.ToString();
                formPartidas.Show();
            }        
        }

        private void buttonfltr_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void buttonfltr_MouseLeave(object sender, EventArgs e)
        {
            //panel2.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        public List<Sala> SortByCreador(List<Sala> salas)
        {
            return listaAux = salas.OrderBy(s => s.creador).ToList();            
        }
        public List<Sala> SortByEstado(List<Sala> salas)
        {

            return listaAux = salas.OrderBy(s => s.estado).ToList();
        }
        public List<Sala> SortByTiempo(List<Sala> salas)
        {


            return listaAux = salas.OrderBy(s => s.tiempo).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            salas=funcionesSort.Invoke(salas,1);
            foreach (Sala item in this.salas)
            {
                dataGridView1.Rows.Add(Sala.devolverSalaString(item));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            salas=funcionesSort.Invoke(salas, 2);
            foreach (Sala item in this.salas)
            {
                dataGridView1.Rows.Add(Sala.devolverSalaString(item));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            salas=funcionesSort.Invoke(salas, 3);
            foreach (Sala item in this.salas)
            {
                dataGridView1.Rows.Add(Sala.devolverSalaString(item));
            }

        }
        public List<Sala> Sorts(List<Sala> salas,int index)
        {
            salas = BaseDeDatos.DevolverSalas();
            switch (index)
            {
                case 1:
                    salas=SortByCreador(salas);
                    break;
                case 2:
                    salas = SortByEstado(salas);
                    break;
                case 3:
                    salas = SortByTiempo(salas);
                    break;
            }
            return salas;
        }
    }
}
