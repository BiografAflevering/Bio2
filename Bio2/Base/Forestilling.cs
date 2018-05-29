namespace Bio2
{
    public class Forestilling
    {
        private Movie _movies;
        private Tid _times;
        private BioSal _sale;
        private Billet _billeter;

        public Forestilling(Movie m, Tid t, BioSal s, Billet b)
        {
            _movies = m;
            _times = t;
            _sale = s;
            _billeter = b;
        }

        public Movie ShowfilmMovie
        {
            get { return _movies; }
        }

        public Tid ShowTime
        {
            get { return _times; }
        }

        public BioSal Seats
        {
            get { return _sale; }
        }

        public Billet TicketsBillet
        {
            get { return _billeter; }
        }

        public override string ToString()
        {
            return $"{_movies.Name} går kl. {_times.tid} (Sæde {_sale.rækker} {_sale.Sæder}) og {_billeter.Pris} og {_billeter.aldergruppe}";
        }
    }
}