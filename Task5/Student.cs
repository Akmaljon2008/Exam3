public class Student : Person{
    private string program;
    private int year;
    private double fee;

    public Student(string name , string address , string program , int year , double fee) : base(name , address)
    {
        this.program = program;
        this.year = year;
        this.fee = fee;
    }
    public string getProgram(){
        return program;
    }
    public void setProgram(string program){
        this.program = program;
    }
    public int getYear(){
        return year;
    }
    public void setyear(int year){
        this.year = year;
    }
    
    public double getFee(){
        return fee;
    }
    public void setFee(double fee){
        this.fee = fee;
    }

    public override string ToString()
    {
        return $"Name : {base.getName()} , Address : {base.getAddress()} , Program : {getProgram()} , Year : {getYear()} , Fee : {getFee()}";
    }

}