using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Interface
{
  public interface IEmployee
  {
    //1= PartTime Employee
    //2 = FullTime Employee
    public string Name { get; set; }
    public decimal EmployeeType { get; set; }
    public int WorkingHour { get; set; }
    decimal GetPay();
    decimal GetBonus();
  }
}
