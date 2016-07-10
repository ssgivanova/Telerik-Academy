namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Product : IProduct
    {
        private const int MinProductName = 3;
        private const int MaxProductName = 10;
        private const string ProductName = "Product name";
        private const string BrandName = "Product brand";

        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        //Minimum product name’s length is 3 symbols and maximum is 10 symbols.
        //The error message should be "Product name must be between {min} and {max} symbols long!"
        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, MaxProductName, MinProductName, String.Format(GlobalErrorMessages.InvalidStringLength, ProductName, MinProductName, MaxProductName));
                this.name = value;
            }
        }

        //Minimum brand name’s length is 2 symbols and maximum is 10 symbols.
        public string Brand
        {
            get { return this.brand; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, GlobalErrorMessages.StringCannotBeNullOrEmpty);
                Validator.CheckIfStringLengthIsValid(value, 10, 2, String.Format(GlobalErrorMessages.InvalidStringLength, BrandName, 2, 10));
                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            protected set
            {
                //TODO - not needed ?
                if (value <= 0)
                {
                    throw new ArgumentException("Price can't be less or equal to 0");
                }
                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            /*
           - {product brand} – {product name}:
           * Price: ${product price}
           * For gender: Men/Women/Unisex
           * Ingredients: {product ingredients, separated by “, “} (when applicable) - for Toothpaste
             */
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(String.Format("  * Price: ${0}", this.Price));
            result.Append(String.Format("  * For gender: {0}", this.Gender));
            return result.ToString();
        }
    }
}
