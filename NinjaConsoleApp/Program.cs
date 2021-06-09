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
            //InsertNinja();
            //InsertMultipleNinjas();
            //InsertNinjaWithEquipment();
            SimpleNinjaQueries();
        }

        private static void SimpleNinjaQueries()
        {

           using( var ctx = new NinjaContext())
            {

                ctx.Database.Log = Console.WriteLine;
                //Enumerate the query variable
                var query2 = ctx.Ninjas;
                foreach (var item in query2)
                {
                    //Avoid this because the database connection will be open during this process and remains open 
                    //So store it in List and numerate later - IMPORTANT

                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("------------------------------");

                var query = ctx.Ninjas.ToList();
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name + " was born on " + item.DOB);
                }

                //Not Parameterized
                var q2 = ctx.Ninjas.Where(n => n.Name == "Sasuke").ToList();
                //Parameterized
                var name = "Sasuke";
                var q3 = ctx.Ninjas.Where(n => n.Name == name).ToList();

                foreach (var item in q3)
                {
                    Console.WriteLine(item.Name + " " + item.DOB + " " + item.ServedInOniwaban);
                }

                //Use this only if First or default is last peace of query as anything after that 
                //happens in memory
                var q4 = ctx.Ninjas.FirstOrDefault(n => n.Name == name);

                var q5 = ctx.Ninjas.Where(n => n.DOB > new DateTime(1950, 1, 1)).OrderBy(n => n.Name).Skip(1).Take(1).FirstOrDefault();

                Console.WriteLine(q5.Name);
            }
         

        }

        private static void InsertNinjaWithEquipment()
        {
            throw new NotImplementedException();
        }

        private static void InsertMultipleNinjas()
        {
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
                //adding multiple object n a single connection session
                
                ctx.Ninjas.AddRange(new List<Ninja> { ninja1, ninja2 });
                ctx.SaveChanges();
            }
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja()
            {
                Name = "Naruto",
                ServedInOniwaban = false,
                ClanId = 1,
                DOB = new DateTime(1993, 4, 29)
            };

            using (var ctx = new NinjaContext())
            {
                ctx.Database.Log = Console.WriteLine;
                //adding single object
                ctx.Ninjas.Add(ninja);
               
                ctx.SaveChanges();
            }
        }
    }
}
