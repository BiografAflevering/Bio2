namespace Bio2
{
    public partial class BioSal 
    {
        private int _antalSal;
        private int _sæder;
        private int _rækker;

        public BioSal(int AntalSal, int rækker, int sæder)
        {
            _antalSal = AntalSal;
            _sæder = Sæder;
            _rækker = rækker;

        }
        public int AntalSal
        {
            get { return _antalSal; }
        }

        public int Sæder
        {
            get { return _sæder; }
        }

        public int rækker
        {
            get { return _rækker; }
        }

        
    }
}