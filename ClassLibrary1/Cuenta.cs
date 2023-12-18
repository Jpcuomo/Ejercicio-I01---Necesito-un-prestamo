namespace ClassLibrary1 
{
    public class Cuenta
    {
        private string _titular;
        private decimal _cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public string Titular
        {
            get 
            { 
                return _titular; 
            }
            private set 
            { 
                _titular = value; 
            }   
        }

        public decimal Cantidad
        {
            get 
            { 
            return _cantidad;
            }
            private set
            {
                _cantidad = value;
            }
        }

        /// <summary>
        /// Muestra titular de cuenta y su saldo
        /// </summary>
        /// <param name="titular">Nombre del titular de la cuenta</param>
        /// <param name="cantidad">Saldo actual de la cuenta</param>
        /// <returns>String con info del titular y el saldo de la cuenta</returns>
        public string Mostrar()
        {
            string mensaje = $"Titular: {Titular} - Saldo: {Cantidad:C2}";
            return mensaje;
        }

        public void Ingresar(decimal monto)
        {
            if(monto >= 0)
            {
                Cantidad += monto;
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero");
            }
        }

        public void Retirar(decimal monto)
        {
            if (monto >= 0)
            {
                Cantidad -= monto;
            }
            else
            {
                Console.WriteLine("El monto a retirar debe ser mayor a cero");
            }
        }
    }
}
