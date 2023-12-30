public  class Dog : Animal{
    public Dog(string name) : base(name){}
    public override void greets()
    {
        System.Console.WriteLine("Woof");
    }

   
}