
namespace PuntoParcial.Clases;

public class PagoTarjeta : ITipoDePago
{
    protected double monto;

    /*     public PagoTarjeta(double monto)
        {
            this.monto = monto;

        } */

    public void TipoDePago(double monto)
    {
        Console.WriteLine($"Procesando pago de {monto} con Tarjeta... ¡Pago realizado exitosamente!");
    }
}


public class PagoPayPal : ITipoDePago
{
    protected double monto;

    /*     public PagoPayPal(double monto)
        {
            this.monto = monto;
        } */



    public void TipoDePago(double monto)
    {
        Console.WriteLine($"Procesando pago de {monto} con PayPal... ¡Pago realizado exitosamente!");
    }
}