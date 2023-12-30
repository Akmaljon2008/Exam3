public class Cat : Animal {
    public Cat(string name) : base(name){}
    public override void greets()
    {
        System.Console.WriteLine("Meow");
    }
}