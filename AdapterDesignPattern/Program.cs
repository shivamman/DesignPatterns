using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Adapter;
using AdapterDesignPattern.Interface;
using System;

namespace AdapterDesignPattern
{
  internal class Program
  {
    static void Main(string[] args)
    {
      XMLEmployeeManager xmlReader = new XMLEmployeeManager();
      //IEmployeeManager adapter = new JSONEmployeeAdapter();
      //Console.WriteLine(adapter.GetEmployeeDetails()); ;
      Console.WriteLine(xmlReader.GetEmployeeDetails()); ;
    }
  }
}
