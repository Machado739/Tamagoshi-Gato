using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gato
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int velocidad = 15;
        int direccionX = 0;
        int direccionY = 0;
        double cantidadComida = 100;
        double cantidadVida = 100;
        private List<PictureBox> obstaculos = new List<PictureBox>();
        private List<PictureBox> comidas = new List<PictureBox>();
        private bool gatoEstaComiendo = false;

        public Form1()
        {
            InitializeComponent();
            // Agrega todos los PictureBox de obstáculos a la lista.
            obstaculos.Add(pictureBox1);
            obstaculos.Add(pictureBox2);
            obstaculos.Add(pictureBox3);
            obstaculos.Add(pictureBox4);
            obstaculos.Add(pictureBox5);
            obstaculos.Add(pictureBox6);
            obstaculos.Add(pictureBox7);
            obstaculos.Add(pictureBox8);
            obstaculos.Add(pictureBox9);
            obstaculos.Add(pictureBox10);

            // Agrega todos los PictureBox de comida a la lista.
            comidas.Add(comida);
            comidas.Add(comida1);
            comidas.Add(comida2);
            comidas.Add(comida3);

            barraComida.Value = (int)cantidadComida;
            barraVida.Value = (int)cantidadVida;
            lblComida.Text = "Comida: " + cantidadComida.ToString("F2");
            lblVida.Text = "Vida: " + cantidadVida.ToString("F2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerMovimiento.Start();

            // Mover el gato y la comida al azar
            
            MoverComidaAleatoriamente(comida);

            // Coloca el PictureBox "alcohol" en una posición aleatoria
            MoverAlcoholAleatoriamente();
        }

        private void timerMovimiento_Tick_1(object sender, EventArgs e)
        {
            if (!gatoEstaComiendo) // Verifica si el gato no está comiendo
            {
                direccionX = random.Next(-2, 4);
                direccionY = random.Next(-2, 4);

                int nuevaX = gato.Location.X + (direccionX * velocidad);
                int nuevaY = gato.Location.Y + (direccionY * velocidad);

                nuevaX = Math.Max(0, Math.Min(nuevaX, this.ClientSize.Width - gato.Width));
                nuevaY = Math.Max(0, Math.Min(nuevaY, this.ClientSize.Height - gato.Height));

                // Verifica si el gato colisiona con la comida
                foreach (PictureBox comida in comidas)
                {
                    if (gato.Bounds.IntersectsWith(comida.Bounds) && comida.Visible)
                    {
                        comida.Visible = false;
                        cantidadComida = 100.0;
                        barraComida.Value = (int)cantidadComida;
                        lblComida.Text = "Comida: " + cantidadComida.ToString("F2");

                        MoverComidaAleatoriamente(comida);

                        gatoEstaComiendo = true; // El gato está comiendo

                        // Configura un temporizador para detener al gato durante 5 segundos
                        Timer temporizadorComida = new Timer();
                        temporizadorComida.Interval = 5000; // 5000 ms (5 segundos)
                        temporizadorComida.Tick += (s, args) =>
                        {
                            gatoEstaComiendo = false; // El gato deja de comer
                            temporizadorComida.Stop(); // Detiene el temporizador
                            temporizadorComida.Dispose(); // Libera recursos
                        };
                        temporizadorComida.Start();
                    }
                }

                // Verifica si el gato colisiona con los obstáculos
                bool colisionObstaculo = false;
                foreach (PictureBox obstaculo in obstaculos)
                {
                    if (obstaculo.Bounds.IntersectsWith(new Rectangle(nuevaX, nuevaY, gato.Width, gato.Height)))
                    {
                        colisionObstaculo = true;
                        break;
                    }
                }

                // Verifica si el gato colisiona con el alcohol
                if (gato.Bounds.IntersectsWith(alcohol.Bounds) && alcohol.Visible)
                {
                    // Gato muere al tocar el alcohol
                    gato.Image = Properties.Resources.dead;
                    timerMovimiento.Stop();
                    MessageBox.Show("El gato ha tocado el alcohol y ha muerto. ¡Juego terminado!");
                    Application.Exit();
                }

                if (!colisionObstaculo)
                {
                    gato.Location = new Point(nuevaX, nuevaY);

                    if (cantidadComida > 0)
                    {
                        cantidadComida -= 1.0;
                        barraComida.Value = (int)cantidadComida;
                        lblComida.Text = "Comida: " + cantidadComida.ToString("F2");
                    }

                    if (cantidadComida <= 0)
                    {
                        cantidadVida -= 10.0;
                        barraVida.Value = (int)cantidadVida;
                        lblVida.Text = "Vida: " + cantidadVida.ToString("F2");

                        if (cantidadVida <= 0)
                        {
                            gato.Image = Properties.Resources.dead;
                            timerMovimiento.Stop();
                            MessageBox.Show("El gato ha perdido toda su vida. ¡Juego terminado!");
                            Application.Exit();
                        }
                    }
                }
            }

            if (gato.Bounds.IntersectsWith(comida.Bounds) && comida.Visible)
            {
                comida.Visible = false;
                cantidadComida = 100.0;
                barraComida.Value = (int)cantidadComida;
                lblComida.Text = "Comida: " + cantidadComida.ToString("F2");

                MoverComidaAleatoriamente(comida);

                gatoEstaComiendo = true; // El gato está comiendo

                // Configura un temporizador para detener al gato durante 5 segundos
                Timer temporizadorComida = new Timer();
                temporizadorComida.Interval = 5000; // 5000 ms (5 segundos)
                temporizadorComida.Tick += (s, args) =>
                {
                    gatoEstaComiendo = false; // El gato deja de comer
                    temporizadorComida.Stop(); // Detiene el temporizador
                    temporizadorComida.Dispose(); // Libera recursos
                };
                temporizadorComida.Start();
            }
        }

        // Agrega un método para mover el PictureBox "alcohol" a una posición aleatoria
        private void MoverAlcoholAleatoriamente()
        {
            bool colisionConObstaculo = false;
            bool colisionConComida = false;

            int nuevaX, nuevaY;
            do
            {
                nuevaX = random.Next(ClientSize.Width - alcohol.Width);
                nuevaY = random.Next(ClientSize.Height - alcohol.Height);

                // Verifica si hay colisión con obstáculos
                foreach (PictureBox obstaculo in obstaculos)
                {
                    if (obstaculo.Bounds.IntersectsWith(new Rectangle(nuevaX, nuevaY, alcohol.Width, alcohol.Height)))
                    {
                        colisionConObstaculo = true;
                        break;
                    }
                }

                // Verifica si hay colisión con comidas
                foreach (PictureBox comida in comidas)
                {
                    if (comida.Bounds.IntersectsWith(new Rectangle(nuevaX, nuevaY, alcohol.Width, alcohol.Height)))
                    {
                        colisionConComida = true;
                        break;
                    }
                }
            } while (colisionConObstaculo || colisionConComida);

            // Asigna la nueva ubicación al PictureBox "alcohol"
            alcohol.Location = new Point(nuevaX, nuevaY);
        }

        private void MoverComidaAleatoriamente(PictureBox comida)
        {
            int nuevaX, nuevaY;
            bool colision;

            do
            {
                colision = false;
                nuevaX = random.Next(ClientSize.Width - comida.Width);
                nuevaY = random.Next(ClientSize.Height - comida.Height);

                // Verifica si la nueva ubicación colisiona con los obstáculos
                foreach (PictureBox obstaculo in obstaculos)
                {
                    if (obstaculo.Bounds.IntersectsWith(new Rectangle(nuevaX, nuevaY, comida.Width, comida.Height)))
                    {
                        colision = true;
                        break;
                    }
                }

                // Verifica si la nueva ubicación colisiona con otras comidas
                foreach (PictureBox otraComida in comidas)
                {
                    if (otraComida != comida && otraComida.Bounds.IntersectsWith(new Rectangle(nuevaX, nuevaY, comida.Width, comida.Height)))
                    {
                        colision = true;
                        break;
                    }
                }
            }
            while (colision);

            comida.Location = new Point(nuevaX, nuevaY);
            comida.Visible = true;
        }

    }
}
