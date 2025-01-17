﻿using NuGet.Protocol.Plugins;
using System.Collections.Generic;
using System.Drawing;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void DeleteProduct(Product product);


        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        //{
        //    return _conn.Query<Category>("SELECT * FROM categories;");
        //}


        public Product AssignCategory();
        //{
        //    var categoryList = GetCategories();
        //    var product = new Product();
        //    product.Categories = categoryList;
        //    return product;
        //}
    }
}
