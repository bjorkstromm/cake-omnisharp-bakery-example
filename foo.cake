/// <summary>
/// This is a class
/// </summary>
public class Foo
{
    public static Foo Create()
    {
        return new Foo();
    }

    public void Bar()
    {
        return;
    }
}

var foo = Foo.Create();

foo.Bar();