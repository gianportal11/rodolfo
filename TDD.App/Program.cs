// See https://aka.ms/new-console-template for more information


using TDD.App;

class Program
{
  class Program
{
    static void Main()
    {
        Funciones f = new Funciones();

        // Caso 1: Números positivos
        Console.WriteLine("Caso 1: " + f.ObtenerMayor(new int[] { 1, 5, 3, 9, 2 }));  // Esperado: 9

        // Caso 2: Números negativos
        Console.WriteLine("Caso 2: " + f.ObtenerMayor(new int[] { -10, -3, -50, -1 }));  // Esperado: -1

        // Caso 3: Mixtos
        Console.WriteLine("Caso 3: " + f.ObtenerMayor(new int[] { -2, 0, 4, -10, 3 }));  // Esperado: 4

        // Caso 4: Elementos iguales
        Console.WriteLine("Caso 4: " + f.ObtenerMayor(new int[] { 7, 7, 7, 7 }));  // Esperado: 7

        // Caso 5: Arreglo vacío
        var resultado = f.ObtenerMayor(new int[] { });
        Console.WriteLine("Caso 5: " + (resultado.HasValue ? resultado.ToString() : "null"));  // Esperado: null
    }
}
}
