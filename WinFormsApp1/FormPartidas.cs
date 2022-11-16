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
using System.IO;


namespace WinFormsApp1
{
    public partial class FormPartidas : Form
    {
        int idAux;
        public int idSala;
        bool turno = false;
        bool partidaEnCurso=true;
        public string creador;

        public delegate void delegadoGuardar(InfoManos manoAGuardar);
        public delegadoGuardar delegado;

        Baraja baraja = new Baraja();

        List<Carta> cartasUsuario = new List<Carta>();
        List<Carta> cartasUsuarioDos = new List<Carta>();
        List<Carta> mazo = new List<Carta>();

        Carta cartaAux = new Carta();
        
        DateTime contador = new DateTime();

        conexion baseDeDatos = new conexion();
        public string stTiempo;
        public FormPartidas()
        {
            InitializeComponent();
        }

        private void FormPartidas_Load(object sender, EventArgs e)
        {
            InfoManos manoAGuardar = new InfoManos(idSala, cartasUsuario, cartasUsuarioDos, baraja, mazo);
            if (stTiempo == "")
            {
                baseDeDatos.CrearManos(idSala);
                cartasUsuario = baraja.Repartir(baraja.listaCompleta);
                cartasUsuarioDos = baraja.Repartir(baraja.listaCompleta);
                mazo.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
                label1.Text = mazo[0].valor.ToString();
                this.cambiarColor(pictureBox1, label1);
                Task t = new Task(CambiarHora);
                t.Start();
            }
            else
            {
              manoAGuardar.distribuirCartas(manoAGuardar);
              label1.Text = mazo[0].valor.ToString();
              contador =Convert.ToDateTime(stTiempo);
              this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
              Task t = new Task(CambiarHora);
              t.Start();

            }          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            turno = CambioDeTurno(turno);
            if (turno == false)
            {
                listBox1.Visible = true;
                listBox2.Visible = false;
            }
            else
            {
                if(turno == true)
                {
                    listBox1.Visible = false;
                    listBox2.Visible = true;
                }
            }
        }

        public bool CambioDeTurno (bool turno)
        {
            bool nt=false;
            if (turno == false)
            {
                nt = true;
            }
            else
            {

                if (turno == true)
                {
                    nt = false;
                }
            }
            return nt;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button4.Visible = false;         
            cartaAux = cartaAux.CompararYDevolverCarta(cartasUsuario, listBox1.SelectedItem.ToString());
            if (cartaAux.color == mazo[mazo.Count() - 1].color || cartaAux.valor == mazo[mazo.Count() - 1].valor && cartaAux.color != "Comodin")
            {
                mazo=Carta.AgregarCartaAlMazo(cartasUsuario,cartaAux,mazo);
                cartasUsuario=Carta.EliminarCarta(cartasUsuario,cartaAux);
                label1.Text = cartaAux.valor.ToString();
                this.cambiarColor(pictureBox1, label1);
                listBox1.Items.Clear();

                this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
                if (cartaAux.especial == false)
                {
                    turno = CambioDeTurno(turno);
                    if (turno == false)
                    {
                        listBox1.Visible = true;
                        listBox2.Visible = false;
                    }
                    else
                    {
                        if (turno == true)
                        {
                            listBox1.Visible = false;
                            listBox2.Visible = true;
                        }
                    }
                }
                else
                {
                    idAux = Carta.CartaEspecialColor(cartaAux);
                    switch (idAux)
                    {
                        case 2:
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            break;
                    }
                }

            }
            else
            {
                if (cartaAux.color == "Comodin")
                {
                    idAux = Carta.CartaEspecialComodin(cartaAux);
                    switch (idAux)
                    {
                        case 1:
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuarioDos.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            buttonAmarillo.Visible = true;
                            buttonAzul.Visible = true;
                            buttonRojo.Visible = true;
                            buttonVerde.Visible = true;
                            break;
                        case 2:
                            buttonAmarillo.Visible = true;
                            buttonAzul.Visible = true;
                            buttonRojo.Visible = true;
                            buttonVerde.Visible = true;

                            break;
                    }
                }
            }
            CompararGanador(listBox1,listBox2,creador,labelcontador.Text);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            button4.Visible = false;
            cartaAux = cartaAux.CompararYDevolverCarta(cartasUsuarioDos, listBox2.SelectedItem.ToString());
            if (cartaAux.color == mazo[mazo.Count()-1].color || cartaAux.valor == mazo[mazo.Count() - 1].valor && cartaAux.color !="Comodin")
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
                cartasUsuarioDos = Carta.EliminarCarta(cartasUsuarioDos, cartaAux);
                label1.Text = cartaAux.valor.ToString();
                this.cambiarColor(pictureBox1, label1);
                listBox2.Items.Clear();
                this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
                if (cartaAux.especial == false)
                {
                    turno = CambioDeTurno(turno);
                    if (turno == false)
                    {
                        listBox1.Visible = true;
                        listBox2.Visible = false;
                    }
                    else
                    {
                        if (turno == true)
                        {
                            listBox1.Visible = false;
                            listBox2.Visible = true;
                        }
                    }
                }
                else
                {
                    idAux = Carta.CartaEspecialColor(cartaAux);
                    switch (idAux)
                    {
                        case 2:
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                        break;
                    }                   
                }

            }
            else
            {
                if(cartaAux.color == "Comodin")
                {
                    idAux = Carta.CartaEspecialComodin(cartaAux);
                    switch (idAux)
                    {
                        case 1:
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            cartasUsuario.Add(baraja.DarCartaRandom(baraja.listaCompleta));
                            buttonAmarillo.Visible = true;
                            buttonAzul.Visible = true;
                            buttonRojo.Visible = true;
                            buttonVerde.Visible = true;
                            break;
                        case 2:
                            buttonAmarillo.Visible = true;
                            buttonAzul.Visible = true;
                            buttonRojo.Visible = true;
                            buttonVerde.Visible = true;
                           
                            break;
                    }
                }
            }
            CompararGanador(listBox1, listBox2, creador, labelcontador.Text);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
            this.cambiarColor(pictureBox1, label1);

          
        }

        private void buttonRojo_Click(object sender, EventArgs e)
        {
            cartaAux.color = "Rojo";
            buttonAmarillo.Visible = false;
            buttonAzul.Visible = false;
            buttonRojo.Visible = false;
            buttonVerde.Visible = false;          
            if (turno == true)
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
                cartasUsuarioDos = Carta.EliminarCarta(cartasUsuarioDos, cartaAux);
            }
            else
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuario, cartaAux, mazo);
                cartasUsuario = Carta.EliminarCarta(cartasUsuario, cartaAux);
            }
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
            label1.Text = mazo[mazo.Count() - 1].valor.ToString();
        }

        private void buttonAzul_Click(object sender, EventArgs e)
        {
            cartaAux.color = "Azul";
            buttonAmarillo.Visible = false;
            buttonAzul.Visible = false;
            buttonRojo.Visible = false;
            buttonVerde.Visible = false;
            mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
            if (turno == true)
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
                cartasUsuarioDos = Carta.EliminarCarta(cartasUsuarioDos, cartaAux);
            }
            else
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuario, cartaAux, mazo);
                cartasUsuario = Carta.EliminarCarta(cartasUsuario, cartaAux);
            }
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
            label1.Text = mazo[mazo.Count() - 1].valor.ToString();
        }

        private void buttonVerde_Click(object sender, EventArgs e)
        {
            cartaAux.color = "Verde";
            buttonAmarillo.Visible = false;
            buttonAzul.Visible = false;
            buttonRojo.Visible = false;
            buttonVerde.Visible = false;
            mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
            if (turno == true)
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
                cartasUsuarioDos = Carta.EliminarCarta(cartasUsuarioDos, cartaAux);
            }
            else
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuario, cartaAux, mazo);
                cartasUsuario = Carta.EliminarCarta(cartasUsuario, cartaAux);
            }
            listBox2.Items.Clear();
            listBox1.Items.Clear();

            this.actualizarManos(cartasUsuario, listBox1, cartasUsuarioDos, listBox2);
            label1.Text = mazo[mazo.Count() - 1].valor.ToString();
        }

        private void buttonAmarillo_Click(object sender, EventArgs e)
        {
            cartaAux.color = "Amarillo";
            buttonAmarillo.Visible = false;
            buttonAzul.Visible = false;
            buttonRojo.Visible = false;
            buttonVerde.Visible = false;
            mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
            if (turno == true)
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuarioDos, cartaAux, mazo);
                cartasUsuarioDos = Carta.EliminarCarta(cartasUsuarioDos, cartaAux);
            }
            else
            {
                mazo = Carta.AgregarCartaAlMazo(cartasUsuario, cartaAux, mazo);
                cartasUsuario = Carta.EliminarCarta(cartasUsuario, cartaAux);
            }
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            this.actualizarManos(cartasUsuario,listBox1,cartasUsuarioDos,listBox2);
            label1.Text = mazo[mazo.Count() - 1].valor.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carta aux1 = new Carta();
            button4.Visible = true;
            if (turno== false)
            {
                cartaAux = baraja.DarCartaRandom(baraja.listaCompleta);
                if(cartaAux is not null)
                {
                    cartasUsuario.Add(cartaAux);
                    listBox1.Items.Clear();
                    foreach (Carta item in this.cartasUsuario)
                    {
                        listBox1.Items.Add(aux1.StringCarta(item));
                    }
                }
                else
                {
                    MessageBox.Show("No quedan cartas en el mazo");
                }
                
            }
            else
            {
                cartaAux = baraja.DarCartaRandom(baraja.listaCompleta);
                if (cartaAux is not null)
                {
                    cartasUsuarioDos.Add(cartaAux);
                    listBox2.Items.Clear();
                    foreach (Carta item in this.cartasUsuarioDos)
                    {
                        listBox2.Items.Add(cartaAux.StringCarta(item));
                    }
                }
                else
                {
                    MessageBox.Show("No quedan cartas en el mazo");
                }
            }
        }
        public void cambiarColor (PictureBox pictureBox,Label label1)
        {
            switch (mazo[mazo.Count() - 1].color)
            {
                case "Amarillo":
                    pictureBox1.Image = Image.FromFile("CartaAmarilla.jpg");
                    label1.BackColor = Color.FromArgb(232, 207, 3);
                    break;
                case "Verde":
                    pictureBox1.Image = Image.FromFile("CartaVerde.jpg");
                    label1.BackColor = Color.FromArgb(50, 138, 16);
                    break;
                case "Rojo":
                    pictureBox1.Image = Image.FromFile("vaciaroja.png");
                    label1.BackColor = Color.FromArgb(192, 11, 0);
                    break;
                case "Azul":
                    pictureBox1.Image = Image.FromFile("cartaAzul.jpg");
                    label1.BackColor = Color.FromArgb(9, 74, 164);
                    break;
            }
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        } 
        public void actualizarManos (List<Carta> Usuario1,ListBox listbox1, List<Carta> Usuario2, ListBox listbox2)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (Carta item in Usuario2)
            {
                
                listbox2.Items.Add(item.StringCarta(item));
            }
            foreach (Carta item in Usuario1)
            {
                listbox1.Items.Add(item.StringCarta(item));
            }
        }
        public void AsignarHora()
        {
            
            try
            {
                if (this.labelcontador.InvokeRequired)
                {
                    Action d = new Action(this.AsignarHora);

                    this.labelcontador.Invoke(d);
                }
                else
                {
                    contador = contador.AddSeconds(1);
                    labelcontador.Text = contador.ToString("H:mm:ss");
                }
            }
            catch(Exception)
            {
                
            }
            

        }

        public void CambiarHora()
        {
            while (partidaEnCurso)
            {
                Thread.Sleep(1000);
                this.AsignarHora();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoManos manoAGuardar = new InfoManos(idSala, cartasUsuario, cartasUsuarioDos, baraja, mazo);
            
            
            if (stTiempo == "")
            {

                manoAGuardar.GuardarMano(manoAGuardar);
                partidaEnCurso = false;
            }
            else
            {
                baseDeDatos.BorrarManos(idSala);
                manoAGuardar.GuardarMano(manoAGuardar);

                partidaEnCurso = false;

            }
            baseDeDatos.GuardarSala(idSala,contador.ToString());
            
            this.Close();

        }

        public void CompararGanador(ListBox listBox1, ListBox listBox2, string creador, string tiempo)
        {
            bool resultado = false;
            if (listBox1.Items.Count == 0)
            {
                listBox1.Enabled = false;
                listBox2.Enabled = false;
                MessageBox.Show("Felicidades, jugador 1 gano la partida");
                resultado = true;
            }
            else
            {
                if (listBox2.Items.Count == 0)
                {
                    listBox1.Enabled = false;
                    listBox2.Enabled = false;
                    MessageBox.Show("Felicidades, jugador 2 gano la partida");
                    resultado = true;

                }

            }
            if (resultado == true)
            {
                UsuariosHistorial Guardar = new UsuariosHistorial(creador, tiempo);
                StreamWriter agregar = File.AppendText("ganadores.txt");
                agregar.WriteLine(" ");
                agregar.WriteLine($"{Guardar.ToString()}");
                agregar.Close();
                

                InfoManos manoAGuardar = new InfoManos(idSala, cartasUsuario, cartasUsuarioDos, baraja, mazo);
                if (stTiempo == "")
                {

                    manoAGuardar.GuardarMano(manoAGuardar);
                    partidaEnCurso = false;
                }
                else
                {
                    baseDeDatos.BorrarManos(idSala);
                    manoAGuardar.GuardarMano(manoAGuardar);
                    partidaEnCurso = false;

                }
                baseDeDatos.GuardarSala(idSala, contador.ToString());
                baseDeDatos.TerminarPartida(idSala);
                this.Close();
            }
        }
    }
}
