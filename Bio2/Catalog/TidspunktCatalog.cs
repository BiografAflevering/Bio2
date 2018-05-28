using System.Collections.Generic;

namespace Bio2
{
    public class TidspunktCatalog
    {
        private List<Tid> times;

        public TidspunktCatalog()
        {
            times = new List<Tid>();
            times.Add(new Tid("kl.13:00"));
            times.Add(new Tid("kl.15:00"));
            times.Add(new Tid("kl.17:00"));
            times.Add(new Tid("kl.19:00"));
            times.Add(new Tid("kl.21:00"));
            times.Add(new Tid("kl.23:00"));

        }

        public List<Tid> Times
        {
            get { return times; }
        }
    }
}