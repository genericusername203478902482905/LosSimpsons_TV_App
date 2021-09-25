using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace LosSimpsons_Random_App
{
    public partial class SimpsonsTV : Form
    {
        Temporada temp1 = new Temporada(1);
        Temporada temp2 = new Temporada(2);
        Temporada temp3 = new Temporada(3);
        Temporada temp4 = new Temporada(4);
        Temporada temp5 = new Temporada(5);
        Temporada temp6 = new Temporada(6);
        Temporada temp7 = new Temporada(7);
        Temporada temp8 = new Temporada(8);
        Temporada temp9 = new Temporada(9);
        Temporada temp10 = new Temporada(10);
        Temporada temp11 = new Temporada(11);
        Temporada temp12 = new Temporada(12);

        public SimpsonsTV()
        {
            InitializeComponent();
        }

        private void SimpsonsTV_Load(object sender, EventArgs e)
        {
            //play short simpsons riff midi when opened

            banner.SizeMode = PictureBoxSizeMode.Zoom;
            sideshowBob.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void botonReproducir_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTemporadas.CheckedItems.Count != 0)
            {
                List<int> temporadasTildadas = new List<int>();
                var random = new Random();
                int tempSeleccionada;
                Episodio epSeleccionado;

                for (int i=0; i<checkedListBoxTemporadas.CheckedIndices.Count;i++)
                {
                    temporadasTildadas.Add(checkedListBoxTemporadas.CheckedIndices[i]);
                }
                int index = random.Next(temporadasTildadas.Count);
                tempSeleccionada = temporadasTildadas[index] + 1;

                Temporada tempObj = new Temporada(tempSeleccionada);
                epSeleccionado = tempObj.RetornarEpisodio();

                System.Diagnostics.Process.Start(epSeleccionado.GetEnlace);
            }
            else
            {
                MessageBox.Show("Seleccione al menos una temporada");
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cafecito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cafecito.app/juancarruyo");
        }
    }
}
