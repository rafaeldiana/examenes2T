namespace simulacroexamne;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculador de IVA ");

        Console.WriteLine("Dime el precio del producto que has comprado");
        string precioproducto = Console.ReadLine();

        Console.WriteLine("El precio del producto es de " + precioproducto + " euros");

        float preciocompleto = Int32.Parse(precioproducto);

        float IVA = 21;

        float totalIVA = preciocompleto * (IVA / 100);

        Console.WriteLine("El IVA general de tu producto es un " + IVA + "%");

        Console.WriteLine("El total del producto contando el IVA es de " + totalIVA + "euros");

        float factura = preciocompleto + totalIVA;

        Console.WriteLine("El total de la factura es de " + factura + "euros");
    }
}
