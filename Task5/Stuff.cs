public class Stuff : Person{
    private string school;
    private double pay;

    public Stuff (string name , string address , string school ,  double pay) : base(name , address)
    {
        this.school = school;
        this.pay = pay;
    }
    public string getSchool(){
        return school;
    }
    public void setSchool(string school){
        this.school = school;
    }
    public double getPay(){
        return pay;
    }
    public void setPay(double pay){
        this.pay = pay;
    }
     public override string ToString()
    {
        return $"Name : {base.getName()} , Address : {base.getAddress()} , School : {getSchool()} , Pay : {getPay()}";
    }
}