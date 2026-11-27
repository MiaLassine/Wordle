//Programme : Braquage de train
//Creator : Mia Lassine 107B
//Date : 27/11/2026

/* 
Premièrement tu dois me faire un jeu (console (Sur invite de commande en gros)) 
Qui sera exactement comme le wordle sauf que pour un début, le mot à trouver sera TOUJOURS : "carte"
mais le joueur aura 6 essais comme dans le wordle
*/

namespace Wordle;

class Program
{
    static string HiddenWord(string hiddenWord)
    {
        hiddenWord = "carte";
        return hiddenWord;
    }

    static void Main(string[] args)
    {
        string hiddenWord = HiddenWord("carte");
        char[] hiddenWordTable = {'c', 'a', 'r', 't', 'e'};
        string? playerAnswer = "";


        for(int i = 0;i == 6 || playerAnswer == hiddenWord; i++)
        {
            if(playerAnswer == hiddenWord)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.Write("Vous avez trouvé le mot !");
                Console.Write("Le mot était " + hiddenWord + " !");
                break;
            }
            Console.WriteLine("----------------------------------------------------------------------\n\n");

            for (int j = 0; j == 5; j++)
            {

            }

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Veuillez saisir un mot français de 5 lettre");
            Console.WriteLine("----------------------------------------------------------------------");
            playerAnswer = Console.ReadLine();
        }
        if(playerAnswer =!hiddenWord)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Vous n'avez pas trouvé le mot !");
            Console.Write("Le mot était " + hiddenWord + " !");
        }
        Console.WriteLine("----------------------------------------------------------------------");
    }
}

