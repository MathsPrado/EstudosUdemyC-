using System;
using System.Globalization;

namespace ExercicioHerançaEPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        #region Construtores
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        #endregion

        #region Funcões
        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
        #endregion
    }
}
