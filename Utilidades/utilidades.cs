using System.Net;

namespace Utilidades
{
    public class utilidades
    {
        public List<int> CalcularPrimos(int inicio, int cantidad)
        {
            List<int> primos = new List<int>();
            int numeroActual = inicio;

            while (primos.Count < cantidad)
            {
                if (EsPrimo(numeroActual))
                {
                    primos.Add(numeroActual);
                }
                numeroActual++;
            }

            return primos;
        }

        public bool EsPrimo(int num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true; // El 2 es primo

            // Verificar divisibilidad desde 2 hasta la raíz cuadrada de num
            int limite = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 2; i <= limite; i++)
            {
                if (num % i == 0)
                    return false; // Encontramos un divisor, no es primo
            }

            return true; // No encontramos divisores, es primo
        }

        public string ObtenerIP()
        {
            try
            {
                string LocalHostName = Dns.GetHostName();
                string LocalIP = "";
                int cont = 0;
                System.Net.IPHostEntry hostInfo = Dns.GetHostEntry(LocalHostName);

                foreach (System.Net.IPAddress ip in hostInfo.AddressList)
                {
                    LocalIP = ip.ToString();
                    for (int i = 0; i < LocalIP.Length; i++)
                    {
                        if (LocalIP[i] == '.')
                        {
                            cont++;
                        }
                    }
                    if (cont == 3)
                    {
                        break;
                    }
                }
                return LocalIP;
            }
            catch
            {
                return "";
            }
        }


    }
}
