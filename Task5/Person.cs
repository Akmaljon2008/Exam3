public class Person{
    private string name;
    private string address;

    public Person(string name , string address){
        this.name = name;
        this.address = address;
    }
    public string getName(){
        return name;
    }
    public string getAddress(){
        return address;
    }
    
    public void setAddress(string address){
        this.address = address;
    }

    public override string ToString()
    {
        return $"Name : {name}, Address : {address}";
    }


}