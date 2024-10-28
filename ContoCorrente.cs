// See https://aka.ms/new-console-template for more information
namespace OOP;

public class ContoCorrente { 
    
    public double saldo {get; set;} = 1000;

    public string Saldo() {
        return saldo.ToString();
    }

    public void Deposito(double x) {
        Console.WriteLine("Saldo antico: " + Saldo());
        saldo += x;
        Console.WriteLine("Saldo nuovo: " + Saldo());
    }

    public void Prelievo(double x) {
        Console.WriteLine("Saldo antico: " + Saldo());
        saldo -= x;
        Console.WriteLine("Saldo nuovo: " + Saldo());
    }
}

