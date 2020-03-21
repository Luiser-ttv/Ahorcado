using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {

        int numFallos = 0;
        String palabraOculta = eligePalabra();
        Boolean partidaTerminada = false;
        String palabraGuiones = "";

        public Form1()
        {
            InitializeComponent();
            button28.Enabled = false;




            
            for (int i = 0; i < palabraOculta.Length; i++)
            {
                if (palabraOculta[i] != ' ')
                {
                    palabraGuiones += "_ ";
                }
                else
                {
                    palabraGuiones += "  ";
                }
                label1.Text = palabraGuiones;
            }

            this.BackColor = Color.FromArgb(34, 36, 49);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static String eligePalabra()
        {
            String[] listaPalabras = { "Hola", "Baby Yoda", "Willyrex", "Coronavirus"};
            Random aleatorio = new Random();
            int pos = aleatorio.Next(listaPalabras.Length);
            return listaPalabras[pos].ToUpper();
        }

        private void letraPulsada(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            String letra = boton.Text;
            letra = letra.ToUpper();
            if (palabraOculta.Contains(letra))
            {
                for (int i = 0; i < palabraOculta.Length; i++)
                {
                    if (palabraOculta[i] == letra[0])
                    {
                        label1.Text = label1.Text.Remove(2 * i, 1).Insert(2 * i, letra);
                    }
                }
            }
            else
            {
                numFallos++;
            }

            if (!label1.Text.Contains('_'))
            {
                numFallos = -100;
            }
            
            
            switch (numFallos)
            {
                case 0: pictureBox1.Image = Properties.Resources.ahorcado_0; break;
                case 1: pictureBox1.Image = Properties.Resources.ahorcado_1; break;
                case 2: pictureBox1.Image = Properties.Resources.ahorcado_2; break;
                case 3: pictureBox1.Image = Properties.Resources.ahorcado_3; break;
                case 4: pictureBox1.Image = Properties.Resources.ahorcado_4; break;
                case 5: pictureBox1.Image = Properties.Resources.ahorcado_5; break;
                case 6:
                    pictureBox1.Image = Properties.Resources.ahorcado_fin;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                    button17.Enabled = false;
                    button18.Enabled = false;
                    button19.Enabled = false;
                    button20.Enabled = false;
                    button21.Enabled = false;
                    button22.Enabled = false;
                    button23.Enabled = false;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button26.Enabled = false;
                    button27.Enabled = false;
                    button28.Enabled = true;

                    break;
                    
                case -100: pictureBox1.Image = Properties.Resources.acertasteTodo; break;
                default: pictureBox1.Image = Properties.Resources.ahorcado_fin; break;

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
            label1.Text = palabraGuiones;


            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = false;
            numFallos = 0;
        }
    }
}
