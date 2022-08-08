using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Model
{
  public class PartTimeEmployee : IEmployee
  {
    public string Name { get; set; }
    public decimal EmployeeType { get; set; }
    public int WorkingHour { get; set; }
    public int HourlyScale { get; set; }
    public PartTimeEmployee()
    {
    }
    public decimal GetBonus()
    {
      return 100;
    }

    public decimal GetPay()
    {
      var payScale = this.WorkingHour * 100;
      return payScale;
    }
  }
  public class FullTimeEmployee : IEmployee
  {
    public string Name { get; set; }
    public decimal EmployeeType { get; set; }
    public decimal MonthlySalary { get; set; }
    public int WorkingHour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public decimal GetBonus()
    {
      return 200;
    }

    public decimal GetPay()
    {
      return MonthlySalary;
    }
  }

}
