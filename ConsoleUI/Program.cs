// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var item in carManager.GetDetailDto().Data)
{
   Console.WriteLine(item.CarName);
   Console.WriteLine(item.BrandName);
   Console.WriteLine(item.ColorName);
   Console.WriteLine(item.DailyPrice);
   Console.WriteLine("******************");
}