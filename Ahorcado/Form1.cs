using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Blibliotecas_Clases;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Ahorcado
{

    public partial class Guardado : Form
    {
        Class datos = new Class();
        Conexion cnx = new Conexion();
        Juego jugar = new Juego();

        string seleccion = "";
        string datos_idpalabra;
        public Guardado()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics objeto = e.Graphics;
            Pen btn = new Pen(Color.LightBlue, 10);
            Rectangle cuadrado = new Rectangle(380, 15, 50, 50);
            Rectangle cuadrado2 = new Rectangle(380, 195, 50, 50);
            Rectangle jugar = new Rectangle(420, 280, 50, 50);
            objeto.DrawRectangle(btn, cuadrado);
            objeto.DrawRectangle(btn, cuadrado2);
            objeto.DrawRectangle(btn, jugar);
        }

        private void gridviewpalabra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccion = gridviewpalabra.Rows[e.RowIndex].Cells[0].Value.ToString();
            datos.ID_palabra = gridviewpalabra.Rows[e.RowIndex].Cells[0].Value.ToString();
            gridviewpistas.DataSource = datos.Mostrar_ID();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 380 && e.Y >= 15 && e.X <= 430 && e.Y <= 65)
            {
                textBpalabra.Text.ToLower();
                if (textBpalabra.Text == "")
                {
                    MessageBox.Show("NO llenaste nada en palabra");
                }
                else
                {
                    
                    datos.Palab = textBpalabra.Text;
                    if (datos.insertar_palabra())
                    {
                        gridviewpalabra.DataSource = datos.actualizarpalbra();
                        //MessageBox.Show("Si guardo");
                        textBpalabra.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No se guardo");
                    }
                }
            }
            if (e.X >= 380 && e.Y >= 195 && e.X <= 430 && e.Y <= 245)
            {
                if (textBpista.Text == "")
                {
                    MessageBox.Show("NO llenaste nada en pista");
                }
                else if(seleccion=="")
                {
                    MessageBox.Show("Selecciona la palabra");
                }
                else
                {
                    //MessageBox.Show("si sirve");
                    datos.Pista = textBpista.Text;
                    if (datos.insertar_pista())
                    {
                        textBpista.Text = "";
                        gridviewpistas.DataSource = datos.Mostrar_ID();
                        //MessageBox.Show("Si guardo");
                    }
                    else
                    {
                        MessageBox.Show("No se guardo");
                    }
                }
            }
            if (e.X >= 420 && e.Y >= 280 && e.X <= 470 && e.Y <= 330)
            {
                this.Hide();
                jugar.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'juegoDataSet.Pistas' Puede moverla o quitarla según sea necesario.
            this.pistasTableAdapter.Fill(this.juegoDataSet.Pistas);
            // TODO: esta línea de código carga datos en la tabla 'juegoDataSet.Palabras' Puede moverla o quitarla según sea necesario.
            this.palabrasTableAdapter.Fill(this.juegoDataSet.Palabras);
        }

        private void textBpalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            datos.validacion(e);
        }

        private void Guardado_MouseMove(object sender, MouseEventArgs e)
        {
            coordenadas.Text = e.X + ":" + e.Y;
        }
    }
}
