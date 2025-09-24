using IMC;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BIENVENIDO A LA CALCULADORA DE IMC");


        Persona p = new Persona();
        Console.WriteLine("Ingrese su nombre: ");
        p.nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        p.edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su peso: ");
        p.peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su altura: ");
        p.altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese su sexo: ");
        p.sexo = Console.ReadLine();
        Console.WriteLine("Ingrese su correo: ");
        p.correo = Console.ReadLine();
        Console.WriteLine("Ingrese su direccion: ");
        p.direccion = Console.ReadLine();
        Console.WriteLine("Ingrese su telefono: ");
        p.telefono = int.Parse(Console.ReadLine());
    }
}