using System.Collections.Generic;

namespace Bio2
{
    public class BilletCatalog
    {
        private List<Billet> billeter;

        public BilletCatalog()
        {
            billeter = new List<Billet>();
            billeter.Add(new Billet("Voksen", 100));
            billeter.Add(new Billet("Barn", 70));
            billeter.Add(new Billet("Senior", 70));
        }

        public List<Billet> Billeter
        {
            get { return billeter; }
        }

    }
}