namespace Clase14082023_POO_Herencia.clases;

public abstract class ACuenta:ICuenta{

    protected int saldo;
    public void retirar(int monto){

        double impuesto;

        //impuesto = (monto * 2 )/100;
        impuesto = monto * 0.02;
        this.saldo -= (int)(monto + impuesto);
        
        Console.WriteLine($"Retirar {monto}");
        Console.WriteLine($"usted retiro {monto} y su saldo es de {this.saldo} y El impuesto del retiro es de {impuesto}");
    }
}