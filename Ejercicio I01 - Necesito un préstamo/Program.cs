using ClassLibrary1;
using System.Text;

namespace Ejercicio_I01___Necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            string historial;
            decimal monto;

            Cuenta cuenta1 = new Cuenta("Juan Pérez", 15_000_000);
            Console.WriteLine(cuenta1.Mostrar());

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Saldo inicial");
            sb.AppendLine($"Titular: {cuenta1.Titular} - Saldo: {cuenta1.Cantidad:C2}");
            sb.AppendLine("----------------------------------------------------------");


            do
            {
                Console.Write("Ingrese una opción: (s) salir - (m) mostar saldo - (h) mostrar historial - (d) depositar - (r) retirar: ");
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "m":
                        LimpiarPantalla();
                        Console.WriteLine(cuenta1.Mostrar());

                        break;

                    case "h":
                        LimpiarPantalla();
                        historial = sb.ToString();
                        Console.WriteLine(historial);
                        break;

                    case "d":
                        LimpiarPantalla();
                        monto = RealizarOperacion("depositar", cuenta1.Ingresar);

                        sb.AppendLine($"Deposito: {monto:C2}");
                        sb.AppendLine(cuenta1.Mostrar());
                        sb.AppendLine("----------------------------------------------------------");
                        break;

                    case "r":
                        LimpiarPantalla();
                        monto = RealizarOperacion("retirar", cuenta1.Retirar);
                        
                        sb.AppendLine($"Retiro: {monto:C2}");
                        sb.AppendLine(cuenta1.Mostrar());
                        sb.AppendLine("--------------------------------------");
                        break;

                    case "s":
                        Console.WriteLine("Gracias por elegirnos!!!");
                        break;

                    default:
                        Console.WriteLine("Error: Opción incorrecta");
                        break;
                }

            } while (opcion != "s");
        }

        internal static decimal RealizarOperacion(string tipoOperacion, Action<decimal> operacion)
        {
            do
            {
                Console.Write($"Ingrese monto a {tipoOperacion}: ");
                string strMonto = Console.ReadLine();
                if (Validador.ValidarMonto(strMonto))
                {
                    decimal monto = decimal.Parse(strMonto);
                    operacion(monto);
                    return monto;
                }
                Console.WriteLine("Error: Error: El monto ingresado debe ser un número no negativo");
            } while (true);
        }

        internal static void LimpiarPantalla()
        {
            Console.Clear();
        }
    }
}
