#addin Cake.Wyam
#addin Cake.Incubator
#addin Cake.Figlet

public static class Foo
{
  public static void Bar()
  {
    Console.WriteLine("yo");
  }
}

var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Hello World!");

  Foo.Bar();

  Figlet("foo");

  

  Information(new WyamSettings().Dump());
  Wyam(new WyamSettings {

  });
});

RunTarget(target);