using System.Collections.Generic;
using System.Windows.Input;
using Windows.UI.Popups;
using Commands.Implementation;

namespace Bio2
{
    public class ForestillingCatalog
    {
        private MovieCatalog _film;
        private SalCatalog _sale;
        private TidspunktCatalog _tider;
        private BilletCatalog _billet;

        public List<Forestilling> Forestillinger { get; }

        public ForestillingCatalog()
        {
            _film = new MovieCatalog();
            _sale = new SalCatalog();
            _tider = new TidspunktCatalog();
            _billet = new BilletCatalog();

            //** 
            Forestillinger = new List<Forestilling>();
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));
            //*

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            //*
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            //*
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

            //** Film
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));
         //**
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));
          
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

            //*

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

            //*********
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));
            //*

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[7], _billet.Billeter[1]));

            //*
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[1], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[2], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[3], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[4], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[5], _sale.Sale[7], _billet.Billeter[2]));

            //*
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[0], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

            //** Film
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[1], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));
            //**
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[2], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

            //*

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[0]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[0]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[1]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[1]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[2]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[2]));

            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[0], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[1], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[2], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[3], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[4], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[5], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[6], _billet.Billeter[3]));
            Forestillinger.Add(new Forestilling(_film.Movies[3], _tider.Times[0], _sale.Sale[7], _billet.Billeter[3]));

        }

        public ICommand BuyCommand
        {
            get { return new RelayCommand(ShowConfirmation);}
        }

        private void ShowConfirmation()
        {
            MessageDialog md = new MessageDialog("You have a ticket");
            md.ShowAsync();
        }
    }
}