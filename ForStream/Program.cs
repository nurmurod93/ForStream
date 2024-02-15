using ForStream.Models;
using System.Linq;
using System.Threading.Channels;
namespace ForStream
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User() { Id = 1, FirstName ="Sherhon", LastName = "Xolmo'monov", CarId = 1, Age = 25,  Phone = "+998975689475"},
                new User() { Id = 2, FirstName = "Sherali", LastName = "Xolmatov", CarId = 3, Age = 28, Phone = "+998882586545" },
                new User() { Id = 3, FirstName = "Nilufar", LastName = "Negmatova", CarId = 3, Age = 18, Phone = "+998856988877"},
                new User() { Id = 3, FirstName = "Nilufar", LastName = "Negmatova", CarId = 4, Age = 18, Phone = "+998856988877"}
            };

            //IList<Car> cars = new List<Car>()
            //{
            //    new Car(){ Id = 1, Marke = "Chevrolet", Color = "Black", Model = "Monza"},
            //    new Car(){ Id = 2, Marke = "BYD", Color = "White", Model = "Han"},
            //    new Car(){ Id = 3, Marke = "Chery", Color = "Red", Model = "Arizzo6Pro"},
            //    new Car(){ Id = 4, Marke = "Jetour", Color = "DodgeBlue", Model = "X70"}
            //};

            //var result = users.Join(cars, u => u.CarId, c => c.Id, (user, car) => new { UserName = user.FirstName, CarName = car.Marke }).ToList();

            //result.ForEach(p => Console.WriteLine($"{p.UserName} - {p.CarName}"));



            var result = users.GroupBy(p => p.Phone).Select(p => p.First()).ToList();
            result.ForEach(p => Console.WriteLine(p.LastName));

            //var result = users.GroupBy(p => p.Phone).Select(p => p.First()).ToList();
            //result.ForEach(p => Console.WriteLine(p.FirstName));

            //var result = users.Distinct().ToList();
            //result.ForEach(p => Console.WriteLine(p.FirstName));
            //IList<User> users = new List<User>()
            //{
            //    new User(){ Id = 1, FirstName = "Nurmurod", LastName = "Rasulov", Age = 30, CarId= new List<int>{ 1, 2, 3},  Phone = "+998973848462"},
            //    new User(){ Id = 2, FirstName = "Lazizbek", LastName = "Xoshimov", Age= 18, CarId = new List<int>{ 2, 3, 4}, Phone = "+998977777777"},
            //    new User(){ Id = 3, FirstName = "Humoyun", LastName = "Ochilov", Age = 27, CarId = new List<int>{ 2}, Phone = "+998998782142"}
            //};

            ////var result = users.OrderBy(p => p.Age).ToList();
            ////result.ForEach(p => Console.WriteLine(p.FirstName));

            ////Console.WriteLine();
            ////Console.WriteLine("Mashinalar:  \n");


            //foreach(var user in users)
            //{
            //    Console.WriteLine($"Id: {user.Id}, Familiyasi: {user.LastName}, Yoshi: {user.Age}");
            //    Console.Write($"{user.FirstName}ga tegishli moshinalar: ");
            //    foreach(var idUser in user.CarId)
            //    {
            //        foreach(var idCar in users1)
            //        {
            //            if(idUser ==  idCar.Id)
            //            {
            //                Console.Write($"{idCar.Marke} ");
            //            }
            //        }
            //    }
            //    Console.WriteLine("\n");

            //}


            //IList<int> list = new List<int>() { 5,7,2,8,10,6,24};


            /// tanlab beradi
            //var result = list.Select(p => p).ToList();
            //result.ForEach(p => Console.WriteLine(p));

            /// Toplamni teskarisiga chiqarib beradi
            //var result = list.Reverse().ToList();
            //result.ForEach(p => Console.WriteLine(p));

            ///Eng oxirgi elementni olib beradi
            //var result = list.Last(p => p >=0);
            //Console.WriteLine(result);

            /// birinchidagi elementni chiqaradi
            //var result = list.First();
            //Console.WriteLine(result);

            /// elementlar ichidan bittadan olib beradi masalan {5,7,2,8,10,6,24,5,7} dan oladi {5,7,2,8,10,6,24} consolga chiqaradi
            // var result = list.Distinct().ToList();            
            //result.ForEach(p => Console.WriteLine(p));

            //static void Sanagich()
            //{
            //    for (int i = 0; i<10; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Thread thread = new Thread(Sanagich) ;
            //thread.Start();

        }
    }
}


