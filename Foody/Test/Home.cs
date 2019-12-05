using BLL;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foody.Test
{
    public class Home
    {
        [Inject]
        public IProduktRepo ProduktRepo { get; set; }
        public List<Produkt> Produkt { get; set; }

        public string Name { get; set; }
        public string Amount { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.Now;


        public Home(IProduktRepo produktRepo)
        {
            ProduktRepo = produktRepo;
            Produkt = ProduktRepo.GetProduktList();
        }
        public void OnLoad()
        {
            Produkt = ProduktRepo.GetProduktList();
        }

        public void Save()
        {
            ProduktRepo.Create(Name, Convert.ToInt32(Amount), ExpiryDate);
            Produkt = ProduktRepo.GetProduktList();
        }
    }
}
