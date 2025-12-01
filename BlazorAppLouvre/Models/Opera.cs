

namespace BlazorAppLouvre.Models
{
    public class Opera
    {
        int idOpera;
        string titolo;
        string autore;
        int annoCompletamento;
        static int contaOpere = 1;
        string imagefile = "";

        public  Opera (string Titolo, string Autore, int AnnoCompletamento, string ImageFile="")
        {
            titolo = Titolo;
            autore = Autore;
            annoCompletamento = AnnoCompletamento;
            idOpera = contaOpere;
            contaOpere++;
        }

        public string TitoloEAutore
        {
            get { return titolo + "di" + autore; }
        }

        public int AnnoCompletamento
        {
            get { return annoCompletamento; }
        }

        public int ContaOpere
        {
            get { return contaOpere; }
        }


        public string OttieniInformazione()
        {
            return "L'opera è" + titolo + "di" + autore;
        }

        public string OttieniInformazioneDettagliata ()
        {
            return "L'opera è" + titolo + "di" + autore + "completata nel" + annoCompletamento;
        }
    }
}
