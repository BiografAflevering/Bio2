using System.Collections.Generic;

namespace Bio2
{
    class SalCatalog
    {
        private List<BioSal> sale;

        public SalCatalog()
        {
            sale = new List<BioSal>();
            //første række
            sale.Add(new BioSal(1, 1, 8));
            sale.Add(new BioSal(1, 1, 6));
            sale.Add(new BioSal(1, 1, 4));
            sale.Add(new BioSal(1, 1, 2));
            sale.Add(new BioSal(1, 1, 1));
            sale.Add(new BioSal(1, 1, 3));
            sale.Add(new BioSal(1, 1, 5));
            sale.Add(new BioSal(1, 1, 7));
            //anden række
            sale.Add(new BioSal(1, 2, 8));
            sale.Add(new BioSal(1, 2, 6));
            sale.Add(new BioSal(1, 2, 4));
            sale.Add(new BioSal(1, 2, 2));
            sale.Add(new BioSal(1, 2, 1));
            sale.Add(new BioSal(1, 2, 3));
            sale.Add(new BioSal(1, 2, 5));
            sale.Add(new BioSal(1, 2, 7));
            //tredje række
            sale.Add(new BioSal(1, 3, 8));
            sale.Add(new BioSal(1, 3, 6));
            sale.Add(new BioSal(1, 3, 4));
            sale.Add(new BioSal(1, 3, 2));
            sale.Add(new BioSal(1, 3, 1));
            sale.Add(new BioSal(1, 3, 3));
            sale.Add(new BioSal(1, 3, 5));
            sale.Add(new BioSal(1, 3, 7));
            //fjerde række
            sale.Add(new BioSal(1, 4, 8));
            sale.Add(new BioSal(1, 4, 6));
            sale.Add(new BioSal(1, 4, 4));
            sale.Add(new BioSal(1, 4, 2));
            sale.Add(new BioSal(1, 4, 1));
            sale.Add(new BioSal(1, 4, 3));
            sale.Add(new BioSal(1, 4, 5));
            sale.Add(new BioSal(1, 4, 7));
        }

        public List<BioSal> Sale
        {
            get { return sale; }
        }

    }
}