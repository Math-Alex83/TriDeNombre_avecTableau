internal class Program
{
    private static void Main(string[] args)
    {
        // TEST AVEC TABLEAU
        /*
        int[] monTableau2 = new int[5];
        string userInput;
        Console.WriteLine("Veuillez entrer vos 5 valeurs (entier positif séparé par un espace vide ' ') s'il vous plaît");
        userInput = Console.ReadLine();
        Console.WriteLine(userInput);
        monTableau2=StringToArray(userInput);
        AfficheLeTableauCroissant(monTableau2);
        //AfficheLeTableauDecroissant(monTableau2);
        */

        /*
         *********************************************************************************************************************
         * RODY & GATIEN sont passés par là :'( 
         *********************************************************************************************************************
        List<int> nbrs = new List<int>(){ 0, 4, 2, 5, 1, 15, 62, 62, 32, 01, 21 };
        foreach (int i in nbrs.FindAll(c => c%2==0))   //<-- pour afficher les nbrs paires de la liste 
            Console.WriteLine(i);
         *********************************************************************************************************************
        */

        // TEST AVEC LISTE.
        List<int> valeur = new List<int>();
        string userInput;
        //string userInput2;
        //string quitte = "q";
        //do
        //{
        Console.WriteLine("blablabla rentre tes valeurs, faire ok après chaque valeur.");
        userInput = Console.ReadLine();
        int[] tab = StringToArray(userInput);
        AfficheLeTableauCroissant(tab);

        //if (!userInput.Equals(quitte))
        //{
        //    userInput2 = userInput;
        //    valeur.Add(int.Parse(userInput2));
        //}
        //else
        //{
        //    int[] tab = valeur.ToArray();
        //    AfficheLeTableauCroissant(tab);
        //}
        //}
        //while (!userInput.Equals(quitte));

    }  // MES FONCTIONS ! 
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