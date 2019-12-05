using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public interface IProduktRepo
    {
        void Create(string name, int amount, DateTime expiryDate);
        List<Produkt> GetProduktList();
    }
}
