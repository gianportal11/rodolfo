namespace TDD.App;

public class Funciones
{
    public int? ObtenerMayor(int[] numeros)
    {
        if (numeros.Length == 0)
        {
            return null; // Retorna null si el arreglo está vacío
        }

        int mayor = numeros[0];
        foreach (int num in numeros)
        {
            if (num > mayor)
            {
                mayor = num;
            }
        }
        return mayor;
    }
}
}
