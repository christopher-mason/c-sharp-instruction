using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_product_manager.business {
    class Product {
        public string code { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public Product() {

            }

        public Product(string code, string description, double price) {
            this.code = code;
            this.description = description;
            this.price = price;
            }

        //public override string ToString() {
        //    return "Product: code = " + code + ", description = " + description + ", " + "price = " + price;
        //    }

        // using string interpolation
        public override string ToString() {
            return $"Product: code = {code}, description = {description}, price = {price}";
            }
        }
}
