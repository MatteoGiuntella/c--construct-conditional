// See https://aka.ms/new-console-template for more information

        Console.WriteLine("Inserisci la tua età:");
        string ageString = Console.ReadLine();
        int age;

        // Utilizza TryParse per convertire la stringa in un numero intero
        if (int.TryParse(ageString, out age))
        {
            if (age >= 18)
            {
                Console.WriteLine("Benvenuto nel sito Web");
            }
            else
            {
                Console.WriteLine("Sei troppo giovane per accedere a questo sito web.");
            }
        }
        else
        {
            Console.WriteLine("Errore: inserisci un numero valido per l'età.");
        }
