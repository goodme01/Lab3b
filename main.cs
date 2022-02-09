using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine("Enter Salesperson name:");

    var Sp = Console.ReadLine();
    
    Console.WriteLine("Enter Sales Amount"); 

    var Sa = Console.ReadLine();

    int x1 = Convert.ToInt32(Sa);
    int x2 = Convert.ToInt32(200);
    int x3 = Convert.ToInt32(0.09);
    int sum = (x3*x1+x2);

    Console.WriteLine(Sp);
    Console.WriteLine("Sales commission is");

    Console.WriteLine(sum);

    
    if (sum >= 0 && sum <= 2999)
    {
      Console.WriteLine("Performace is poor");  
    }

    if (sum >= 3000 && sum <= 4999)
    {
      Console.WriteLine("Performace is Average");
    }

    if (sum >= 5000 && sum <= 9999)
    {
      Console.WriteLine("Performace is Good");
    }

    if (sum >= 10000 && sum <= 14999)
    {
      Console.WriteLine("Performace is Excellent");
    }

    if (sum > 15000)
    {
      Console.WriteLine("Performace is Outstanding");
    }
    
  }
}