using RepositoryDesignPattern.Data;
using RepositoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryDesignPattern.Repository
{
  public class DepartmentRepository : IDepartmentRepository
  {
    private readonly AppDbContext _appContext;
    public DepartmentRepository(AppDbContext appContext)
    {
      _appContext = appContext;
    }

    public Department GetDepartmentById(int id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Department> GetDepartments()
    {
      throw new NotImplementedException();
    }
  }
}
