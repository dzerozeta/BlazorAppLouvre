namespace BlazorAppLouvre.Models
{
    public class Scultura : Opera
    {
        string materiale;
        string tecnica;

        public Scultura(string Titolo, string Autore, int AnnoCompletamento, string Materiale, string Tecnica, string ImageFile) : base (Titolo, Autore, AnnoCompletamento,ImageFile)
        {
            materiale = Materiale;
            tecnica = Tecnica;
        }

        public string Materiale
        { 
             get { return materiale; }
        }
        public string Tecnica
        {
            get { return tecnica; }
        }

        public string OttieniInformazione ()
        {
            return base.OttieniInformazione() + " è una scultura" ;
        }

        public  string OttieniInformazioneDettagliata()
        {
            return base.OttieniInformazioneDettagliata + " è una scultura fatta in" + materiale + "usando la tecnica" + tecnica;
        }
    }
}
