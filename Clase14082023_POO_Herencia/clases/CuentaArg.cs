namespace Clase14082023_POO_Herencia.clases;

public class CuentaArg : ACuenta
{
    public CuentaArg(int saldo)
    {
        this.saldo = saldo;
    }

    public void retirar(int monto){

        double impuesto;

        //impuesto = (monto * 2 )/100;
        impuesto = monto * 0.025;
        this.saldo -= (int)(monto + impuesto);
        
        Console.WriteLine($"Retiros desde Argentina");
        Console.WriteLine($"usted retiro {monto} y su saldo es de {this.saldo} y El impuesto del retiro es de {impuesto}");
    }
}