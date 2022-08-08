using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Model;
using System;

namespace FactoryDesignPattern
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      var factory = new EmployeeFactory();
      var model = factory.CreateFactory(GetEmployee());
      Console.WriteLine(model.Name);
      Console.WriteLine(model.GetPay());
      Console.WriteLine(model.GetBonus());
    }

    static IEmployee GetEmployee()
    {
      return new PartTimeEmployee()
      {
        Name = "Krishna",
        EmployeeType = 1,
        WorkingHour = 8
      };
    }
  }
}
