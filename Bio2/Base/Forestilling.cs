namespace Bio2
{
    public class Forestilling
    {
        private Movie _movies;
        private Tid _times;
        private BioSal _sale;
        private Billet _billeter;

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

    }
}