// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nombre_Del_Titular = "Norbey";
int pin = 1234;

CuentaBancaria cuenta_Bancaria = new CuentaBancaria(nombre_Del_Titular,pin);

Console.WriteLine($"El Balance de su cuenta es: ${cuenta_Bancaria.verBalance()}");

cuenta_Bancaria.depositarMonto(2000);

Console.WriteLine($"El Balance de su cuenta es: ${cuenta_Bancaria.verBalance()}");

cuenta_Bancaria.retirar(2000,1234);
Console.WriteLine($"El Balance de su cuenta es: ${cuenta_Bancaria.verBalance()}");

class CuentaBancaria
{
    public string nombre_Del_Titular { get; set; }
    public int balance;
    private int numero_De_Cuenta;
    private int pin { get; set; }

    public CuentaBancaria(string nombre_Del_Titular, int pin){
        this.nombre_Del_Titular = nombre_Del_Titular;
        this.balance = 0;
        this.pin = pin;
        this.numero_De_Cuenta = 100000;
    }

    public void depositarMonto(int monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine($"El monto no puede ser {monto}");
        }
        else
        {
            this.balance += monto;
        }

    }

    public void retirar(int monto, int pin)
    {
        if (this.pin != pin)
        {
            Console.WriteLine("Pin Incorrecto");
            return;
        }

        if (monto <= 0 || monto > this.balance)
        {
            Console.WriteLine($"No tiene fondos suficientes para retirar {monto}");
        }
        else
        {
            this.balance -= monto;
            Console.WriteLine("Retiro Exitoso!!");
        }

    }

    public int verBalance()
    {
        return this.balance;
    }


    public bool cambiarPing(int ping_Actual, int nuevo_Pin)
    {
        if (this.pin != ping_Actual)
        {
            Console.WriteLine("Retiro Exitoso!!");
            return false;
        }
        this.pin = nuevo_Pin;
        return true;
    }
}