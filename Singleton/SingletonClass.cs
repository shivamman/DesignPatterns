// See https://aka.ms/new-console-template for more information




public sealed class SingletonClass
{
  //Eager Loading
  //private static SingletonClass instance = new SingletonClass();

  //Lazy Loading
  private static Lazy<SingletonClass> instance = new Lazy<SingletonClass>(()=> new SingletonClass());
  public static int Counter { get; set; }

  private static object instanceLock = new object();

  private SingletonClass()
  {
    Counter++;
  }

  public static SingletonClass GetInstance { get {
      //if(instance == null)
      //{
      //  lock(instanceLock)
      //  {
      //    instance = new SingletonClass();
      //  }
      //}
      return instance.Value;
    }
  }
  public void Print()
  {
    Console.WriteLine("Counter: " + Counter.ToString());
  }
}

