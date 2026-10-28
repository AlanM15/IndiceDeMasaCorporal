
        Console.WriteLine("Aplicación que calcula el Índice de masa corporal de una persona ");

        decimal peso = ReadDecimal("Proporcione el peso en kilogramos de la persona: ");
        decimal estatura = ReadDecimal("Proporcione la estatura en metros de la persona: ");

        decimal imc = Imc.Console.Models.CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
        var estadoNutricional = Imc.Console.Models.CalculadoraImc.EstadoNutricional(imc);
        Console.WriteLine($"El indice de masa corporal de la personaes: {imc:F4}");
        Console.WriteLine($"El estado nutricional de la persona es: {estadoNutricional}");


static decimal ReadDecimal(string indicacion)
{
    decimal valor;
    string entrada;
    bool entradaEsValida;

    do
    {
        Console.WriteLine(indicacion);
        entrada = Console.ReadLine();
        entradaEsValida = decimal.TryParse(entrada, out valor);
        if (!entradaEsValida)
        {
            Console.WriteLine("Entrada inválida: La entrada debe ser numérica");
        }
    }
    while (!entradaEsValida);

    return valor;
}