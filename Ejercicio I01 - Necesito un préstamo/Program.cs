using ClassLibrary1;

namespace Ejercicio_I01___Necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            Cuenta cuenta1 = new Cuenta("Juan Pérez", 15_000_000);
            Console.WriteLine(cuenta1.Mostrar());
            
            do
            {
                Console.Write("Ingrese una opción: (s) salir - (m) mostar saldo - (d) depositar - (r) retirar: ");
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "m":
                        LimpiarPantalla();
                        Console.WriteLine(cuenta1.Mostrar());
                        break;

                    case "d":
                        LimpiarPantalla();
                        RealizarOperacion("depositar", cuenta1.Ingresar);
                        break;

                    case "r":
                        LimpiarPantalla();
                        RealizarOperacion("retirar", cuenta1.Retirar);
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

        internal static void RealizarOperacion(string tipoOperacion, Action<decimal> operacion)
        {
            do
            {
                Console.Write($"Ingrese monto a {tipoOperacion}: ");
                string strMonto = Console.ReadLine();
                if (Validador.ValidarMonto(strMonto))
                {
                    decimal monto = decimal.Parse(strMonto);
                    operacion(monto);
                    break;
                }
                Console.WriteLine("Error: El monto ingresado tiene un formato incorrecto");
            } while (true);
        }

        internal static void LimpiarPantalla()
        {
            Console.Clear();
        }
    }
}
