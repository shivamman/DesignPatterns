using AdapterDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace AdapterDesignPattern.Adaptee
{
  public class XMLEmployeeManager
  {
    List<Employee> employees = new List<Employee>();
    public XMLEmployeeManager()
    {
      employees.Add(new Employee { Id = 1, Name = "Pawan", Address = "Ktm" });
      employees.Add(new Employee { Id = 2, Name = "Sabin", Address = "Ktm" });
      employees.Add(new Employee { Id = 3, Name = "Smriti", Address = "Ktm" });
    }

    public virtual string GetEmployeeDetails()
    {
      var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
      var serializer = new XmlSerializer(employees.GetType());

      var settings = new XmlWriterSettings(); settings.Indent = true;
      settings.OmitXmlDeclaration = true;
      using (var stream = new StringWriter())
      using (var writer = XmlWriter.Create(stream, settings))
      {
        serializer.Serialize(writer, employees, emptyNamepsaces);
        return stream.ToString();
      }
    }
  }
}
