using System;
using System.Linq;

public class MaBlibliothèque
{
    static int[] StringToArray(string valeurs)
    {
        string[] arrayString = valeurs.Split(" ");
        int[] arrayToReturn = new int[arrayString.Length];

        for (int i = 0; i < arrayString.Length; i++)
        {
            arrayToReturn[i] = int.Parse(arrayString[i]);
        }

        return arrayToReturn;
    }
    static void AfficheLeTableauCroissant(int[] array)
    {
        Array.Sort(array);

        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

    }
    static void AfficheLeTableauDecroissant(int[] array)
    {
        array = array.OrderByDescending(i => i).ToArray();
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();

    }

}
