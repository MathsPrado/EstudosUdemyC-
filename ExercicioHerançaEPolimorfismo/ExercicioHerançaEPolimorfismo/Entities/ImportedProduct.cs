using System.Globalization;

namespace ExercicioHerançaEPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        #region Construtores
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double costomsFee) : base(name, price)
        {
            CustomsFee = costomsFee;
        }
        #endregion


        #region Metodos
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: $ "
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
        #endregion

    }
}
