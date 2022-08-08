using RepositoryDesignPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Interface
{
  public interface IDepartmentRepository
  {
    IEnumerable<Department> GetDepartments();
    Department GetDepartmentById(int id); 
  }
}
