// Solicitar los caracteres al usuario
Console.WriteLine("Ingrese los caracteres para la figura de la cara humana:");

Console.Write("Caracter para los ojos: ");
char ojos = Console.ReadLine()[0];

Console.Write("Caracter para las cejas: ");
char cejas = Console.ReadLine()[0];

Console.Write("Caracter para la nariz: ");
char nariz = Console.ReadLine()[0];

Console.Write("Caracteres para la boca (tres caracteres): ");
string boca = Console.ReadLine().Substring(0, 3);

Console.Write("Caracter para el cabello: ");
char cabello = Console.ReadLine()[0];

Console.Write("Caracteres para las orejas (dos caracteres: izquierda y derecha): ");
string? orejas = Console.ReadLine().Substring(0, 2);

Console.Write("Caracter para delinear la cara o el contorno: ");
char contorno = Console.ReadLine()[0];

Console.Write("Caracteres para el mentón (tres caracteres): ");
string menton = Console.ReadLine().Substring(0, 3);

// Generar la figura
Console.WriteLine("");
Console.WriteLine("Resultado:");
Console.WriteLine("");
Console.WriteLine($" {new string(cabello, 5)}");
Console.WriteLine($"{contorno} {cejas} {cejas} {contorno}");
Console.WriteLine($"{orejas[0]} {ojos} {ojos} {orejas[1]}");
Console.WriteLine($"{contorno}  {nariz}  {contorno}");
Console.WriteLine($"{contorno} {boca} {contorno}");
Console.WriteLine($"{contorno} {new string(' ', 3)} {contorno}");
Console.WriteLine($"  {menton}");
Console.ReadLine();