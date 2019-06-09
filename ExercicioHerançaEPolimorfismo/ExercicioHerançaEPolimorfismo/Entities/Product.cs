using System.Globalization;

namespace ExercicioHerançaEPolimorfismo.Entities
{
    class Product
    {
     
        public string Name { get; set; }
        public double Price { get; set; }

        #region Construtores
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }
        #endregion

        #region Funções
        public virtual string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
