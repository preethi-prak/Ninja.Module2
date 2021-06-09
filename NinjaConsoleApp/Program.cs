using NinjaDomain.Classes;
using NinjaDomain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            InsertNinja();
            //InsertMultipleNinjas();
            //InsertNinjaWithEquipment();
        }

        private static void InsertNinjaWithEquipment()
        {
            throw new NotImplementedException();
        }

        private static void InsertMultipleNinjas()
        {
          
        }

        private static void InsertNinja()
        {
            //var ninja = new Ninja()
            //{
            //    Name = "Naruto",
            //    ServedInOniwaban = false,
            //    ClanId = 1,
            //    DOB = new DateTime(1993, 4, 29)
            //};

            var ninja1 = new Ninja()
            {
                Name = "Obito",
                ServedInOniwaban = false,
                ClanId = 1,
                DOB = new DateTime(1933, 4, 20)
            };
            var ninja2 = new Ninja()
            {
                Name = "Sasuke",
                ServedInOniwaban = false,
                ClanId = 1,
                DOB = new DateTime(1994, 9, 17)
            };
            using (var ctx = new NinjaContext())
            {
                ctx.Database.Log = Console.WriteLine;
                //adding single object
                //ctx.Ninjas.Add(ninja);
                ctx.Ninjas.AddRange(new List<Ninja> { ninja1, ninja2 });
                ctx.SaveChanges();
            }
        }
    }
}
