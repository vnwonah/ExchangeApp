using System;

namespace ExchangeApp.Models
{
    public class Offer
    {
        public string Title { get; set; }
        public double PercentageReturn { get; set; }
        public double MinimumBidAmount { get; set; }
        public DateTime OfferStart { get; set; }
        public DateTime OfferEnd { get; set; }
        public string LogoUrl { get; set; }
    }
}
