using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_de_matrices
{
    public partial class Form1 : Form
    {
        private TextBox[,] Matriz1;
        private TextBox[,] Matriz2;
        private TextBox[,] Resultante;
        private float determinante;

        int linea1, columna1;
        int linea2, columna2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1crearmatriz_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            /*if (textBox1.Text.Length == 0)
           {
               MessageBox.Show("El tamaño de la matriz es nula", "Error");
               return;
           }
           if (textBox3.Text == null)
           {
               MessageBox.Show("La columna de la matriz es nula.", "Error");
               return;
           }
           linea1 = Convert.ToInt32(textBox1.Text);
           columna1 = Convert.ToInt32(textBox3.Text);*/
            if (!int.TryParse(textBox1.Text, out linea1))
            {
                MessageBox.Show("La linea de la matriz 1 es nula.", "Error");
                return;
            }
            if (!int.TryParse(textBox3.Text, out columna1))
            {
                MessageBox.Show("La columna de la primera matriz es nula.", "Error");
                return;
            }


            Matriz1 = new TextBox[linea1, columna1];
            int TamanhoText = groupBoxMatriz1.Width / coluna1;
            for (int x = 0; x < Matriz1.GetLength(0); x++)
            {
                for (int y = 0; y < Matriz1.GetLength(1); y++)
                {
                    Matriz1[x, y] = new TextBox();
                    Matriz1[x, y].Text = "0";
                    Matriz1[x, y].Top = (x * Matriz1[x, y].Height) + 20;
                    Matriz1[x, y].Left = y * TamanhoText + 6;
                    Matriz1[x, y].Width = TamanhoText;
                    groupBoxMatriz1.Controls.Add(Matriz1[x, y]);
                }
            }
        }
    }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
