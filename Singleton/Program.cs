// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Main();
Console.ReadLine();

static void Main()
{
  OtherClass otherClass = new OtherClass();
  otherClass.Print();
  OtherClass otherClass2 = new OtherClass();
  otherClass2.Print();

  Parallel.Invoke(
      () => FirstInstance(),
      () => SecondInstance()
   );
  //SingletonClass singletonClass = new SingletonClass();
}

static void FirstInstance()
{
  var singleton = SingletonClass.GetInstance;
  singleton.Print();
}

static void SecondInstance()
{
  var singleton2 = SingletonClass.GetInstance;
  singleton2.Print();
}

