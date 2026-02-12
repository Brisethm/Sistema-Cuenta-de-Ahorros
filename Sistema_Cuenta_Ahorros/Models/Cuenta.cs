namespace Sistema_Cuenta_Ahorros.Models
{
    public class Cuenta
    {
        public decimal Saldo { get; set; } = 0;

       public void Depositar(decimal monto)
        {
            if (monto > 0)
                Saldo += monto;
        }
        public bool Retirar(decimal monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }
    }
}
