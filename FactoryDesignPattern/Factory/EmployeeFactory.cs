using FactoryDesignPattern.Interface;
using FactoryDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern.Factory
{
  public class EmployeeFactory
  {
    public IEmployee CreateFactory(IEmployee emp) {
      IEmployee employee = null;
      if(emp.EmployeeType == 1)
      {
        return new PartTimeEmployee();
      }
      else if (emp.EmployeeType == 2)
      {
        return new FullTimeEmployee();
      }
      return employee;  
    }
  }
}
