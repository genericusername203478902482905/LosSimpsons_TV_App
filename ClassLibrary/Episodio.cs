using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
    public class Episodio
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
    {
        private int temporada;
        private int episodio;
        private string enlace;

        public Episodio(int temporada, int episodio)
        {
            this.temporada = temporada;
            this.episodio = episodio;
            this.enlace = $"https://simpsonitos.xyz/episodio/los-simpson-{this.temporada}x{this.episodio}/";
        }


        public int GetTemporada { get => temporada;}
        public int GetEpisodio { get => episodio;}
        public string GetEnlace { get => enlace;}

        /*
        private string crearEnlace()
        {
            return ($"https://simpsonitos.xyz/episodio/los-simpson-{this.temporada}x{this.episodio}/");
        }
        */

        public static List<Episodio> operator +(List<Episodio> listTemp, Episodio ep)
        {
            if (listTemp != ep)
            {
                listTemp.Add(ep);
            }

            return listTemp;
        }
        public static bool operator ==(List<Episodio> listTemp, Episodio episodio)
        {
            bool retorno = false;

            foreach (Episodio ep in listTemp)
            {
                if (episodio.temporada == ep.temporada && episodio.episodio == ep.episodio)
                    retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(List<Episodio> listTemp, Episodio episodio)
        {
            return !(listTemp == episodio);
        }



        }
}
