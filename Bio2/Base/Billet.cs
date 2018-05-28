namespace Bio2
{
    public class Billet :DomainClassBase
    {
        private string _aldersgruppe;
        private int _pris;

        public Billet(string aldersgruppe, int Pris)
        {
            _aldersgruppe = aldersgruppe;
            _pris = Pris;
        }

        public string aldergruppe
        {
            get { return _aldersgruppe; }
        }

        public int Pris
        {
            get { return _pris; }
        }

        public override string ToString()
        {
            return $"{aldergruppe}";
        }

        public override int Key { get; set; }
    }
}