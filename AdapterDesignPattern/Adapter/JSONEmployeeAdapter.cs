using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AdapterDesignPattern.Adapter
{
  public class JSONEmployeeAdapter: XMLEmployeeManager, IEmployeeManager
  {
    public override string GetEmployeeDetails()
    {
      string returnXml = base.GetEmployeeDetails();
      XmlDocument doc = new XmlDocument();
      doc.LoadXml(returnXml);
      return JsonConvert.SerializeObject(doc, Newtonsoft.Json.Formatting.Indented);
    }
  }
}
