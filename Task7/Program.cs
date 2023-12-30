List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
int max = -99999999;
foreach (var item in list)
{
    if (item > max)max = item;
}
System.Console.WriteLine(max);
System.Console.WriteLine("-------------------------------------");
foreach (var i in list)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("-------------------------------------");
list.Sort();
foreach (var i in list)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("-------------------------------------");
foreach (var i in list)
{
    if(i < 0) i = 0;
}
foreach (var i in list)
{
    System.Console.WriteLine(i);
}
System.Console.WriteLine("-------------------------------------");