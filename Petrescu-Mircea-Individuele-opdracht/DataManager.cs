using System.Collections.Generic;
using System.Linq;

namespace Petrescu_Mircea_Individuele_opdracht
{
    class DataManager
    {

        //Product
        public static List<Product> GetProducts()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Products.ToList();
            }
        }
        public static List<Product> GetProductByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Product in FinalDBEntities.Products
                            where Product.ProductID == id
                            select Product;

                return query.ToList();
            }

        }

        public static int InsertProduct(Product p)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Products.Add(p);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return p.ProductID;
                }
            }
            return 0;
        }
        public static int DeleteProduct(Product ProductDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Product in FinalDBEntities.Products
                            where Product.ProductID == ProductDelete.ProductID
                            select Product;
                Product p = query.FirstOrDefault();

                FinalDBEntities.Products.Remove(p);

                return FinalDBEntities.SaveChanges();
            }
        }



        //Klant

        public static List<Klant> GetClients()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Klants.ToList();
            }
        }

        public static List<Klant> GetClientByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Klant in FinalDBEntities.Klants
                            where Klant.KlantID == id
                            select Klant;

                return query.ToList();
            }

        }

        public static int InsertClient(Klant k)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Klants.Add(k);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return k.KlantID;
                }
            }
            return 0;
        }
        public static int DeleteClient(Klant ClientDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Klant in FinalDBEntities.Klants
                            where Klant.KlantID == ClientDelete.KlantID
                            select Klant;

                Klant k = query.FirstOrDefault();
                FinalDBEntities.Klants.Remove(k);

                return FinalDBEntities.SaveChanges();
            }
        }


        //Bestelling

        public static List<Bestelling> GetOrders()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Bestellings.ToList();
            }
        }
        public static List<int> GetAllClientsDistinct()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Klant in FinalDBEntities.Klants
                            select Klant.KlantID;

                return query.Distinct().ToList();

            }

        }
        public static List<Bestelling> GetOrderByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Bestelling in FinalDBEntities.Bestellings
                            where Bestelling.BestellingID == id
                            select Bestelling;

                return query.ToList();
            }
        }

        public static int InsertOrder(Bestelling b)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Bestellings.Add(b);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return b.BestellingID;
                }
            }
            return 0;
        }

        public static int DeleteOrder(Bestelling OrderDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Bestelling in FinalDBEntities.Bestellings
                            where Bestelling.BestellingID == OrderDelete.BestellingID
                            select Bestelling;
                Bestelling bestelling = query.FirstOrDefault();
                FinalDBEntities.Bestellings.Remove(bestelling);

                return FinalDBEntities.SaveChanges();
            }
        }



        //Categorie

        public static List<Categorie> GetCategories()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Categories.ToList();
            }
        }
        public static Categorie GetCategoryByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Categorie in FinalDBEntities.Categories
                            where Categorie.CategorieID == id
                            select Categorie;

                return query.FirstOrDefault();
            }

        }
        public static int InsertCategory(Categorie c)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Categories.Add(c);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return c.CategorieID;
                }
            }
            return 0;
        }
        public static int DeleteCatergory(Categorie CategoryDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Categorie in FinalDBEntities.Categories
                            where Categorie.CategorieID == CategoryDelete.CategorieID
                            select Categorie;
                Categorie categorie = query.FirstOrDefault();
                FinalDBEntities.Categories.Remove(categorie);

                return FinalDBEntities.SaveChanges();
            }
        }


        //Leverancier
        public static List<Leverancier> GetSuppliers()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Leveranciers.ToList();
            }
        }
        public static List<int> GetAllSuppliersDistinct()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Leverancier in FinalDBEntities.Leveranciers
                            select Leverancier.LeverancierID;

                return query.Distinct().ToList();

            }

        }


        public static List<Leverancier> GetSupplierByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Leverancier in FinalDBEntities.Leveranciers
                            where Leverancier.LeverancierID == id
                            select Leverancier;

                return query.ToList();
            }

        }
        public static int InsertSupplier(Leverancier l)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Leveranciers.Add(l);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return l.LeverancierID;
                }
            }
            return 0;
        }
        public static int DeleteSupplier(Leverancier SupplierDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Leverancier in FinalDBEntities.Leveranciers
                            where Leverancier.LeverancierID == SupplierDelete.LeverancierID
                            select Leverancier;
                Leverancier leverancier = query.FirstOrDefault();
                FinalDBEntities.Leveranciers.Remove(leverancier);

                return FinalDBEntities.SaveChanges();
            }
        }




        //Personeelslid

        public static List<Personeelslid> GetEmployees()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                return FinalDBEntities.Personeelslids.ToList();
            }
        }

        public static List<int> GetAllEmployeesDistinct()
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Personeelslid in FinalDBEntities.Personeelslids
                            select Personeelslid.PersoneelslidID;

                return query.Distinct().ToList();

            }

        }
        public static Personeelslid GetEmployeeByID(int id)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Personeelslid in FinalDBEntities.Personeelslids
                            where Personeelslid.PersoneelslidID == id
                            select Personeelslid;

                return query.FirstOrDefault();
            }

        }
        public static int InsertEmployee(Personeelslid pl)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                FinalDBEntities.Personeelslids.Add(pl);
                if (0 < FinalDBEntities.SaveChanges())
                {
                    return pl.PersoneelslidID;
                }
            }
            return 0;
        }
        public static int DeleteEmployee(Personeelslid EmployeeDelete)
        {
            using (var FinalDBEntities = new FinalDBEntities())
            {
                var query = from Personeelslid in FinalDBEntities.Personeelslids
                            where Personeelslid.PersoneelslidID == EmployeeDelete.PersoneelslidID
                            select Personeelslid;
                Personeelslid personeelslid = query.FirstOrDefault();
                FinalDBEntities.Personeelslids.Remove(personeelslid);

                return FinalDBEntities.SaveChanges();
            }
        }
    }
}

