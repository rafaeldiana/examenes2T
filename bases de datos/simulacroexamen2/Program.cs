namespace simulacroexamen2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa de calculadora de velocidad del sonido v.0.1");

        Console.WriteLine("Indica cuántos segundos ha tardado en llegar el sónido");

        string secs = Console.ReadLine();

        int segundos = Int32.Parse(secs);

        Console.WriteLine("El sonido ha tardado " + segundos + " segundos en llegar");

        int velson = 343;

        int dist = velson * segundos;

        Console.WriteLine("La velocidad del sonido es " + velson + " metros por segundo");

        Console.WriteLine("La tormenta se encuentra a una distancia de " + dist + " metros");
    }
}
