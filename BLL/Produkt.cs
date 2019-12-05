using System;

namespace BLL
{
    public class Produkt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime DateTimeNow { get; set; }

        public Produkt()
        {

        }
        public Produkt(string name, int amount, DateTime expiryDate)
        {
            Name = name;
            Amount = amount;
            ExpiryDate = expiryDate;
            DateTimeNow = DateTime.Now;
        }
    }
}
