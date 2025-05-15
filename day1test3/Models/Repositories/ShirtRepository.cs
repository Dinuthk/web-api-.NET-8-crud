namespace day1test3.Models.Repositories
{
    public class ShirtRepository
    {
        //  Temporary in-memory data store
        private static List<Shirts> shirts = new List<Shirts>
        {
            new Shirts { ShirtId = 1, Brand = "Nike", Color = "Black", size = 7, Gender = "Men", Price = 100 },
            new Shirts { ShirtId = 2, Brand = "Adidas", Color = "White", size = 8, Gender = "Women", Price = 120 },
            new Shirts { ShirtId = 3, Brand = "Puma", Color = "Blue", size = 6, Gender = "Men", Price = 95 },
            new Shirts { ShirtId = 4, Brand = "Levis", Color = "Red", size = 9, Gender = "Unisex", Price = 150 },
            new Shirts { ShirtId = 5, Brand = "Reebok", Color = "Green", size = 7, Gender = "Men", Price = 110 }
        };

        //public static bool ShirtExists(int id)
        //{
        //    return shirts.Any(x => x.ShirtId == id);
        //}

        //public static Shirts? GetShirtsById(int id)
        //{
        //    return shirts.FirstOrDefault(x => x.ShirtId == id);
        //}
        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

        public static Shirts? GetShirtsById(int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
