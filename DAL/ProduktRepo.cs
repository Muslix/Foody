using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;

namespace DAL
{
    public class ProduktRepo : IProduktRepo
    {
        public void Create(string name, int amount, DateTime expiryDate)
        {
            using (var produktRepo = new DatabaseContext())
            {
                try
                {
                    //produktRepo.Database.EnsureDeleted();
                    produktRepo.Database.EnsureCreated();

                    var produkt = new Produkt(name, amount, expiryDate);

                    produktRepo.Produkt.Add(produkt);
                    produktRepo.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception("" + e);
                }
            }
        }

        public List<Produkt> GetProduktList()
        {
            using (var produktRepo = new DatabaseContext())
            {
                produktRepo.Database.EnsureCreated();

                return produktRepo.Produkt.ToList();
            }
        }
    }
}
