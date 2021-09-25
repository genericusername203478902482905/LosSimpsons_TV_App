using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Temporada
    {
        private int numTemporada;
        private int cantEpisodios;
        private List<Episodio> episodeList;

        private Temporada()
        {
            this.episodeList = new List<Episodio>();
        }
        public Temporada(int numTemporada) : this()
        {
            this.numTemporada = numTemporada;
            switch(numTemporada)
            {
                case 1:
                    this.cantEpisodios = 13;
                    break;
                case 2:
                    this.cantEpisodios = 22;
                    break;
                case 3:
                    this.cantEpisodios = 24;
                    break;
                case 4:
                    this.cantEpisodios = 22;
                    break;
                case 5:
                    this.cantEpisodios = 22;
                    break;
                case 6:
                    this.cantEpisodios = 25;
                    break;
                case 7:
                    this.cantEpisodios = 25;
                    break;
                case 8:
                    this.cantEpisodios = 25;
                    break;
                case 9:
                    this.cantEpisodios = 25;
                    break;
                case 10:
                    this.cantEpisodios = 23;
                    break;
                case 11:
                    this.cantEpisodios = 22;
                    break;
                case 12:
                    this.cantEpisodios = 21;
                    break;
            }
            this.GenerarEpisodios();
        }

        public Episodio AgregarEpisodio
        {
            set { this.episodeList += value; }
        }

        private void GenerarEpisodios()
        {
            for (int i = 1; i<= this.cantEpisodios; i++)
            {
                this.AgregarEpisodio = new Episodio(this.numTemporada, i);
            }
        }

        public Episodio RetornarEpisodio()
        {
            var random = new Random();
            int r = random.Next(1,episodeList.Count);
            return new Episodio(this.numTemporada, r);
        }


    }
}
