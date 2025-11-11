class Program
{
    static void Main(string[] args)
    {
        const double ratioOfWater = 1.5;
        const double ratioOfGas = 2.3;
        const double ratioOfElectricity = 2.4;
            
        Console.Write("Введите объем газа, который вы потратили: ");
        double gas = double.Parse(Console.ReadLine());
        
        Console.Write("Введите, сколько литров воды вы потратили: "); 
        double water = double.Parse(Console.ReadLine());
            
        Console.Write("Введите, сколько электричества вы потратили: "); 
        double electricity = double.Parse(Console.ReadLine());
        
        double totalWater = water * ratioOfWater;
        double totalElectricity = electricity * ratioOfElectricity;
        double totalGas = gas * ratioOfGas;
        double allUtilities = totalGas + totalWater + totalElectricity;
        
        Console.WriteLine($"Сумма за воду: {Math.Round(totalWater, 2)} руб.");
        Console.WriteLine($"Сумма за газ: {Math.Round(totalGas, 2)} руб.");
        Console.WriteLine($"Сумма за электричество: {Math.Round(totalElectricity, 2)} руб.");
        
        Console.WriteLine($"Ваша полная сумма: {Math.Round(allUtilities, 2)} руб.");
    }
}  
