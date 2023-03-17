using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace UnitTests
{
    
    [TestClass]
    public class ModelTests
    {
        Context _ctx;

        public ModelTests()
        {
            _ctx = new Context();
        }

        [TestMethod]
        public void Test_AddProduc()
        {
          
                Product product = new Product
                {
                    CategoryID = _ctx.Categories.FirstOrDefault()?.ID,
                    Name = "Тестовый продукт",
                    Price = 10,
                };

                _ctx.Products.Add(product);
                _ctx.SaveChanges();
                Assert.AreNotEqual(default(int),product.ID, message: "Тест создания продукта не пройден");
           
        }

        /// <summary>
        /// Тест валидации 
        /// </summary>
        [TestMethod]
        public void test_ProductValidate()
        {
            Product product = new Product
            {
                CategoryID = _ctx.Categories.FirstOrDefault()?.ID,
                Price = 10,
            };

            _ctx.Products.Add(product);

            try
            {
                _ctx.SaveChanges();

            }catch(DbEntityValidationException ex)
            {
                var broken = ex.EntityValidationErrors.FirstOrDefault();
                Assert.AreEqual(broken.Entry.Entity.GetType(), typeof(Product));
            }

            Assert.AreEqual(default(int),product.ID, message: "Тест создания продукта не пройден");
        }
    }
}
