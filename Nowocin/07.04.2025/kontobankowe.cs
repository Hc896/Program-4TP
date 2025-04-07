using System;

class KontoBankowe
{
    private string wlasciciel;
    private double saldo;

    public KontoBankowe(string wlasciciel, double saldo)
    {
        this.wlasciciel = wlasciciel;
        this.saldo = saldo;
    }

    public double PokazSaldo()
    {
        return saldo;
    }

    public void WplataSaldo(double kwota)
    {
        if (kwota > 0)
            saldo += kwota;
    }

    public bool WyplataSaldo(double kwota)
    {
        if (kwota > 0 && kwota <= saldo)
        {
            saldo -= kwota;
            return true;
        }
        return false;
    }
}
KontoBankowe konto = new KontoBankowe("Anna", 1000);
konto.WplataSaldo(500);
konto.WyplataSaldo(200);
Console.WriteLine(konto.PokazSaldo());
