using Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class MyDataBaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context ctx)
        {
            var cnt = new Unit
            {
                Name = "шт."
            };

            var ml = new Unit
            {
                Name = "мл."
            };

            var gr = new Unit
            {
                Name = "гр"
            };
            ctx.Units.AddRange(new Unit[] { cnt, ml, gr });
             
            ctx.Categories.Add(new Category
            {
                Name = "Кофе",
                Products = new List<Product> 
                {
                    new Product { Name ="Эспрессо",UnitName = ml,Price = 100 },
                    new Product { Name ="Американо",UnitName = ml,Price = 100 },
                    new Product { Name ="Латте", UnitName = ml, Price = 120},
                    new Product { Name ="Капуччино",UnitName = ml,Price = 100},
                    new Product { Name ="Flat White",UnitName = ml, Price = 125},
                    new Product { Name ="Моккачино",UnitName = ml, Price = 100},
                    new Product { Name ="Венский кофе",UnitName = ml, Price = 150},
                }
            });
            ctx.Categories.Add(new Category 
            {
                Name = "Тортики",
                Products = new List<Product> 
                { 
                    new Product { Name ="Шоколадный",UnitName = gr,Price = 150},
                    new Product { Name ="Три шоколада",UnitName = gr,Price = 150},
                    new Product { Name ="Красный бархат",UnitName = gr,Price = 150},
                    new Product { Name ="Лимонный",UnitName = gr,Price = 150},
                    new Product { Name ="Чизкейк",UnitName = gr,Price = 150},
                }
            });

            ctx.Categories.Add(new Category 
            { 
                Name = "Горячие напитки",
                Products = new List<Product> 
                {
                    new Product { Name = "Зеленый чай",UnitName = ml,Price = 150},
                    new Product { Name = "Зеленый чай с жасмином",UnitName = ml,Price = 150},
                    new Product { Name = "Английский завтрак",UnitName = ml,Price = 150 },
                    new Product { Name = "Эрл Грэй" ,UnitName = ml,Price = 150},
                    new Product { Name = "Земляничный чай" ,UnitName = ml,Price = 150},
                }
            });

            ctx.Organizations.Add(
                new Organization { 
                    Name = "ООО Кофейня", INN = "123456789" ,
                    Seller = new List<Seller> { 
                        new Seller
                        {
                            Name = "Кофейня №1",
                            CashBoxes = new List<CashBox>{
                                new CashBox{Number = "9994567890111156",Name = "Рабочее место 1"},
                                new CashBox{Number = "9996661224455660",Name = "Рабочее место 2"},
                                new CashBox{Number = "9996661334455889",Name = "Рабочее место 3"}
                            }
                        },
                        new Seller
                        {
                            Name = "Кофейня 2",
                            CashBoxes = new List<CashBox>{
                                new CashBox{Number = "8896661110123559",Name = "Рабочее место 1y"},
                                new CashBox{Number = "8896661220124566",Name = "Рабочее место 2y"},
                                new CashBox{Number = "8896661330877445",Name = "Рабочее место 3y"}
                            }
                        }
                    } 
            });

            ctx.Users.Add(new User { Name = "Иванов И.И.", Login = "Barista", Password = "123",Type = UserType.Salesman });
            ctx.Users.Add(new User { Name = "Петров П.П.", Login = "Admin", Password = "123",Type = UserType.Administrator });
            ctx.Users.Add(new User { Name = "Админ А.А.", Login = "Admin", Password = "321", Type = UserType.Administrator });
            
            ctx.SaveChanges();
            base.Seed(ctx);
        }
    }
}
