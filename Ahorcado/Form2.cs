using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Blibliotecas_Clases;
using System.Threading;

namespace Ahorcado
{
    public partial class Juego : Form
    {
        string palabraescogida = "";
        int dif = 0;
        int cont = 0;
        int win = 0;
        TextBox[] cajas;
        char[] letras;
        int paint;
        int fallos = 9;
        string seleccion = "";
        int tiempo= 0 ;
        int Time = 0;

        public Juego()
        {
            InitializeComponent();
        }

        Class datos = new Class();

        private void Juego_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'juegoDataSet.Pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.juegoDataSet.Pistas);
            // TODO: esta línea de código carga datos en la tabla 'juegoDataSet.Palabras' Puede moverla o quitarla según sea necesario.
            this.palabrasTableAdapter.Fill(this.juegoDataSet.Palabras);
            labelfallos.Text = Convert.ToString(fallos);
        }

        private void Juego_MouseMove(object sender, MouseEventArgs e)
        {
            coordenadas.Text = e.X + ":" + e.Y;
        }

        private void Juego_MouseClick(object sender, MouseEventArgs e)
        {
            if (paneldejuego0.Visible == true)
            {
                //Mensaje para no accionar otras cosas antes de selccionar una palabra 
                MessageBox.Show("¡¡¡Aun no has selcecionado la *Palabra* haslo para poder jugar!!!");
            }
            else
            {
                //Botones de letra o palabra
                if (e.X >= 25 && e.Y >= 15 && e.X <= 105 && e.Y <= 40)
                {
                    //Eliminar info de la TextBox no eleigida 
                    textBoxjuegopalabra.Text = "";
                    //Mostrar Letra
                    labeljuegoletra.Visible = true;
                    textBoxjuegoletra.Visible = true;
                    //Ocultar Plabra
                    labeljuegopalabra.Visible = false;
                    textBoxjuegopalabra.Visible = false;
                }

                if (e.X >= 155 && e.Y >= 15 && e.X <= 255 && e.Y <= 40)
                {
                    //Eliminar info de la TextBox no eleigida 
                    textBoxjuegoletra.Text = "";
                    //Mostrar Palabra
                    labeljuegopalabra.Visible = true;
                    textBoxjuegopalabra.Visible = true;
                    //Ocultar Letra
                    labeljuegoletra.Visible = false;
                    textBoxjuegoletra.Visible = false;
                }
                //Boton pista
                if (e.X >= 35 && e.Y >= 105 && e.X <= 75 && e.Y <= 125)
                {
                    if (GridViewpista.Visible == false)
                    {
                        DialogResult r = MessageBox.Show("¡¡¡Si quieres ver las pistas te costara 3 Fallos incluso " +
                            "puedes perder por ello!!!", "¡¡¡CUIDADO!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (r == DialogResult.OK)
                        {
                            GridViewpista.Visible = true;
                            paint = paint + 3;
                            fallos = fallos - 3;
                            labelfallos.Text = Convert.ToString(fallos);
                            Refresh();
                        }
                    }
                }

                    //Chequeo y llenado de los TexBox generados y de los predeterminados 
                    if (e.X >= 551 && e.Y >= 191 && e.X <= 661 && e.Y <=221 )
                    {
                    textBoxjuegoletra.Text.ToLower();
                    textBoxjuegopalabra.Text.ToLower();
                    if ((textBoxjuegoletra.Text =="") && (textBoxjuegopalabra.Text == ""))
                    {
                        MessageBox.Show("Verifica que llenaste el campo correspondiente");
                    }
                    else
                    {
                        if (textBoxjuegopalabra.Text == seleccion)
                        {
                            backgroundWorker1.CancelAsync();
                            timer1.Stop();
                            MessageBox.Show("¡¡¡YOU ARE THE CHAMPION LA PALABRA ES:" + seleccion + "!!!");
                            textBoxjuegoletra.Enabled = false;
                            textBoxjuegopalabra.Enabled = false;
                        }

                        else if (palabraescogida.Contains(textBoxjuegoletra.Text.ToLower()))
                        {
                            if (textBoxjuegoletra.Text == "")
                            {
                                fallos = fallos - 1;
                                labelfallos.Text = Convert.ToString(fallos);
                                paint += 1;
                                if (fallos == 0)
                                { 
                                    Refresh();
                                    backgroundWorker1.CancelAsync();
                                    timer1.Stop();
                                    MessageBox.Show("!!!YOU LOSE¡¡¡");
                                    textBoxjuegoletra.Enabled = false;
                                    textBoxjuegopalabra.Enabled = false;
                                }
                                Refresh();
                            }
                            else
                            {
                                for (cont = 0; cont <= palabraescogida.Length - 1; cont++)
                                {
                                    if (letras[cont] == Convert.ToChar(textBoxjuegoletra.Text))
                                    {
                                        if (cajas[cont].Text == textBoxjuegoletra.Text.ToLower())
                                        {

                                        }
                                        else
                                        {
                                            cajas[cont].Text = textBoxjuegoletra.Text.ToLower();
                                            win += 1;
                                        }
                                    }
                                }
                                if (win == (palabraescogida.Length))
                                {
                                    backgroundWorker1.CancelAsync();
                                    timer1.Stop();
                                    MessageBox.Show("¡¡¡YOU ARE THE CHAMPION!!!");
                                    textBoxjuegoletra.Enabled = false;
                                    textBoxjuegopalabra.Enabled = false;
                                }
                            }
                        }

                        else
                        {
                            fallos = fallos - 1;
                            labelfallos.Text = Convert.ToString(fallos);
                            paint += 1;
                            if (fallos == 0)
                            {
                                Refresh();
                                timer1.Stop();
                                backgroundWorker1.CancelAsync();
                                MessageBox.Show("!!!YOU LOSE¡¡¡");
                                textBoxjuegoletra.Enabled = false;
                                textBoxjuegopalabra.Enabled = false;
                            }
                            Refresh();
                        }
                    }
                    textBoxjuegoletra.Text = "";
                    textBoxjuegopalabra.Text = "";
                    }

                //Boton Reset
                if (e.X >= 564 && e.Y >= 244 && e.X <= 644 && e.Y <= 274)
                {
                    backgroundWorker1.CancelAsync();
                    for (cont = 0; cont <= palabraescogida.Length - 1; cont++)
                    {
                        this.Controls.Remove(cajas[cont]);
                    }
                    timer1.Stop();
                    palabraescogida = "";
                    letras.DefaultIfEmpty();
                    cajas.DefaultIfEmpty();
                    cont = 0;
                    paint = 0;
                    Refresh();
                    dif = 0;
                    win = 0;
                    fallos = 9;
                    seleccion = "";
                    labelfallos.Text = Convert.ToString(fallos);
                    textBoxjuegoletra.Visible = false;
                    textBoxjuegopalabra.Visible = false;
                    labeljuegopalabra.Visible = false;
                    labeljuegoletra.Visible = false;
                    GridViewpista.Visible = false;
                    paneldejuego0.Visible = true;
                    tiempo = 0;
                    labeltime.Visible = true;
                    
                }
            }
        }

        private void Juego_Paint(object sender, PaintEventArgs e)
        {
            //Botones de accion
            Graphics objbtn = e.Graphics;
            Pen btn = new Pen(Color.LightBlue, 8);
            Rectangle cuadrado = new Rectangle(25, 15, 80, 25);
            Rectangle cuadrado2 = new Rectangle(155, 15, 100, 25);
            Rectangle comprobar = new Rectangle(551, 191, 110, 30);
            Rectangle reset = new Rectangle(564, 244, 80, 30);
            Rectangle pista = new Rectangle(35, 105, 40, 20);
            objbtn.DrawRectangle(btn, cuadrado);
            objbtn.DrawRectangle(btn, cuadrado2);
            objbtn.DrawRectangle(btn, comprobar);
            objbtn.DrawRectangle(btn, reset);
            objbtn.DrawRectangle(btn, pista);


            //Partes del Ahorcado
            Graphics objeto = e.Graphics;
            Pen pluma = new Pen(Color.BurlyWood, 4);
            Pen pluma2 = new Pen(Color.DarkRed, 4);

            if (paint ==1 || paint > 1)
            {
                //Base1
                Rectangle A = new Rectangle(170, 100, 4, 250);
                objeto.DrawRectangle(pluma, A);
            }
            if (paint == 2 || paint > 2)
            {
                //Base2
                Rectangle B = new Rectangle(170, 100, 260, 4);
                objeto.DrawRectangle(pluma, B);
            }
            if (paint == 3 || paint > 3)
            {
                //Cuerda XD
                Rectangle C = new Rectangle(430, 100, 4, 30);
                objeto.DrawRectangle(pluma, C);
            }
            if (paint == 4 || paint > 4)
            {
                //Cabeza
                Rectangle D = new Rectangle(402, 130, 60, 60);
                objeto.DrawEllipse(pluma2, D);
            }
            if (paint == 5 || paint > 5)
            {
                //cuerpo
                Rectangle E = new Rectangle(430, 190, 4, 75);
                objeto.DrawRectangle(pluma2, E);
            }
            if (paint == 6 || paint > 6)
            {
                //Pierna Izquierda
                Point f1 = new Point(430, 265);
                Point f2 = new Point(398, 310);
                objeto.DrawLine(pluma2, f1, f2);
            }
            if (paint == 7 || paint > 7)
            {
                //Pierna Derecha
                Point g1 = new Point(430, 265);
                Point g2 = new Point(462, 310);
                objeto.DrawLine(pluma2, g1, g2);
            }
            if (paint == 8 || paint > 8)
            {
                //brazo izquierdo
                Point h1 = new Point(430, 190);
                Point h2 = new Point(398, 240);
                objeto.DrawLine(pluma2, h1, h2);
            }
            if (paint == 9 || paint > 9)
            {
                //brazo derecho
                Point i1 = new Point(430, 190);
                Point i2 = new Point(462, 240);
                objeto.DrawLine(pluma2, i1, i2);
            }
        }

        private void paneldejuego0_Paint(object sender, PaintEventArgs e)
        {
            //Botones del Panel
            Graphics objeto = e.Graphics;
            Pen btn = new Pen(Color.LightBlue, 10);
            Rectangle cuadrado = new Rectangle(200, 110, 100, 40);
            Rectangle regreso = new Rectangle(221, 172, 50, 20);
            objeto.DrawRectangle(btn, cuadrado);
            objeto.DrawRectangle(btn, regreso);
        }

        private void paneldejuego0_MouseMove(object sender, MouseEventArgs e)
        {
            coordenadas.Text = e.X + ":" + e.Y;
        }

        private void paneldejuego0_MouseClick(object sender, MouseEventArgs e)
        {

            //Ocultar Panel
            //Crear cajas de texto
            if (e.X >= 221 && e.Y >= 172 && e.X <= 271 && e.Y <= 192)
            {
                paneltiempo.Visible = true;
            }
            else if (seleccion == "")
            {
                MessageBox.Show("Selecciona la Palabra");
            }
            else 
            {
                if (e.X >= 200 && e.Y >= 110 && e.X <= 300 && e.Y <= 150)
                {
                    labeltime.Visible=true;
                    backgroundWorker1.RunWorkerAsync();
                    timer1.Start();
                    textBoxjuegoletra.Enabled = true;
                    textBoxjuegopalabra.Enabled = true;
                    letras = palabraescogida.ToCharArray();
                    cajas = new TextBox[palabraescogida.Length];
                    for (cont = 0; cont <= palabraescogida.Length - 1; cont++)
                    {
                        cajas[cont] = new TextBox();
                        cajas[cont].Height = 30;
                        cajas[cont].Width = 30;
                        cajas[cont].Location = new Point(100 + dif, 400);
                        cajas[cont].Enabled = false;
                        cajas[cont].BackColor = Color.LightBlue;
                        cajas[cont].Font = new Font("Comic Sans MS", 18, FontStyle.Bold);
                        this.Controls.Add(cajas[cont]);
                        dif += 50;
                    }
                    paneldejuego0.Visible = false;
                    GridViewpista.DataSource = datos.Mostrar_ID();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Asignacion de datos desde GridView
            datos.ID_palabra= gridviewplabraparajuego.Rows[e.RowIndex].Cells[0].Value.ToString();
            palabraescogida = gridviewplabraparajuego.Rows[e.RowIndex].Cells[1].Value.ToString();
            seleccion = gridviewplabraparajuego.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void textBoxjuegoletra_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.validacion(e);
        }

        private void textBoxjuegopalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.validacion(e);
        }

        private void paneltiempo_MouseMove(object sender, MouseEventArgs e)
        {
            coordenadas.Text = e.X + ":" + e.Y;
        }

        private void paneltiempo_Paint(object sender, PaintEventArgs e)
        {
            Graphics objbtn = e.Graphics;
            Pen btn = new Pen(Color.LightBlue, 8);
            Rectangle segundo = new Rectangle(38, 98, 70, 50);
            Rectangle segundo2 = new Rectangle(189, 98, 80, 50);
            Rectangle minuto = new Rectangle(332, 98, 70, 50);
            Rectangle regrso = new Rectangle(190, 186, 70, 20);
            objbtn.DrawRectangle(btn, segundo);
            objbtn.DrawRectangle(btn, segundo2);
            objbtn.DrawRectangle(btn, minuto);
            objbtn.DrawRectangle(btn, regrso);
        }

        private void paneltiempo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >=38 && e.Y >= 98 && e.X <= 108 && e.Y <= 148)
            {
                tiempo =600 ;
                Time = 60;
                paneltiempo.Visible = false;
            }
            if (e.X >= 189 && e.Y >= 98 && e.X <= 269 && e.Y <= 148)
            {
                tiempo =900 ;
                Time = 90;
                paneltiempo.Visible = false;
            }
            if (e.X >= 332 && e.Y >= 98 && e.X <= 402 && e.Y <= 148)
            {
                tiempo = 1200;
                Time = 120;
                paneltiempo.Visible = false;
            }
            if(e.X >=190 && e.Y >= 186 && e.X <= 250 && e.Y <= 206)
            {
                Guardado guard = new Guardado();
                guard.Show();
                this.Dispose();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if(backgroundWorker1.CancellationPending==true)
                {

                    e.Cancel = true;
                    break;
                }
                int porcentaje = i;
                Thread.Sleep(tiempo);                
                backgroundWorker1.ReportProgress(porcentaje);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progresb.Value = e.ProgressPercentage; 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("GAME OVER");
            for (cont = 0; cont <= palabraescogida.Length - 1; cont++)
            {
                this.Controls.Remove(cajas[cont]);
            }
            palabraescogida = "";
            letras.DefaultIfEmpty();
            cajas.DefaultIfEmpty();
            cont = 0;
            paint = 0;
            Refresh();
            dif = 0;
            win = 0;
            fallos = 9;
            seleccion = "";
            labelfallos.Text = Convert.ToString(fallos);
            textBoxjuegoletra.Visible = false;
            textBoxjuegopalabra.Visible = false;
            labeljuegopalabra.Visible = false;
            labeljuegoletra.Visible = false;
            GridViewpista.Visible = false;
            paneldejuego0.Visible = true;
            paneltiempo.Visible = true;
            tiempo = 0;
            labeltime.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labeltime.Text ="Tiempo Restante:"+Time.ToString()+"Segundos";
            Time -= 1;
            if(Time < 0)
            {
                timer1.Stop();
            }

        }
    }
}
