//namespace Cosmetics.Products
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;

//    using Cosmetics.Contracts;
//    using Cosmetics.Common;

//    public class Category : ICategory
//    {
//        private const int MinCategoryNameLength = 2;
//        private const int MaxCategoryNameLength = 15;

//        private string name;
//        private readonly ICollection<IProduct> products;

//        public Category(string name)
//        {
//            this.Name = name;
//            this.products = new List<IProduct>();
//        }

//        public string Name
//        {
//            get
//            {
//                return this.name;
//            }
//            private set
//            {
//                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
//                Validator.CheckIfStringLengthIsValid(value, MaxCategoryNameLength, MinCategoryNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryNameLength, MaxCategoryNameLength));
//                this.name = value;
//            }
//        }

//        public void AddCosmetics(IProduct cosmetics)
//        {
//            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));
//            this.products.Add(cosmetics);
//        }

//        public void RemoveCosmetics(IProduct cosmetics)
//        {
//            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove from category"));
//            if (!this.products.Contains(cosmetics))
//            {
//                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
//            }

//            this.products.Remove(cosmetics);
//        }

//        public string Print()
//        {
//            var categoryString = string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count != 1 ? "products" : "product");

//            var result = new StringBuilder();
//            result.AppendLine(categoryString);

//            var sortedProducts =
//                this.products
//                    .OrderBy(pr => pr.Brand)
//                    .ThenByDescending(pr => pr.Price);

//            foreach (var product in sortedProducts)
//            {
//                result.AppendLine(product.Print());
//            }
//            return result.ToString().Trim();
//        }
//    }
//}

namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class Category : ICategory
    {
        private const int MinCategoryName = 2;
        private const int MaxcategoryName = 15;

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                //minimum category name’s length length is 2 symbols and maximum is 15 symbols.
                Validator.CheckIfStringLengthIsValid(value, MaxcategoryName, MinCategoryName, String.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryName, MaxcategoryName));
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            //if (cosmetics != null)
            //{
            //    this.products.Add(cosmetics);
            //}
            Validator.CheckIfNull(cosmetics, "Cosmetics to add can't be null");
            this.products.Add(cosmetics);

        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            //Product {product name} does not exist in category {category name}!
            if (this.products.Count < 0 || cosmetics == null)
            {
                throw new InvalidOperationException(String.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            //Validator.CheckIfNull(cosmetics, "Cosmetics to remove can't be null");
            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            /*
            {category name} category – {number of products} products/product in total
            - {product brand} – {product name}:
              * Price: ${product price}
              * For gender: Men/Women/Unisex
              * Ingredients: {product ingredients, separated by “, “} (when applicable)
            - {product brand} – {product name}:
              * Price: ${product price}
              * For gender: {product gender}
              * Quantity: {product quantity} ml (when applicable)
              * Usage: EveryDay/Medical (when applicable)
             */

            StringBuilder result = new StringBuilder();
            result.Append(String.Format("{0} category – {1} {2} in total", this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products"));
  
            //sort products
            //Products in category should be sorted by brand in ascending order and then by price in descending order.
            var sortedProducts = this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);

            //toString of each product
            foreach (var product in sortedProducts)
            {
                result.AppendLine(product.ToString());
            }
            return result.ToString();
        }
    }
}
