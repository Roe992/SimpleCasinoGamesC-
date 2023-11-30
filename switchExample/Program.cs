// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int playerTotal = 22;
int dealerTotal = 25;
string message = "";

string switchControl = "21"; 

//blackjack

switch (switchControl)
{

    case "menu":
        Console.WriteLine( "Welcome to C# A S I N O \n Para Blackjack ingrese 21");
        break;

    case "21":
        Console.WriteLine("Welcome to 21 Blackjack");
        

        if (playerTotal < 22 && dealerTotal < 22 && playerTotal > dealerTotal)
        {
            message = $"you beat the dealer, congratulations.\n  player:{playerTotal} dealer: {dealerTotal}";

        }
        else if (playerTotal < 22 && dealerTotal < 22 && playerTotal < dealerTotal)
        {
            message = $"the dealer won.\n  player:{playerTotal} dealer: {dealerTotal}";
        }
        else if (playerTotal < 22 && dealerTotal > 21)
        {
            message = $"the dealer exceeded 21 and you didn't, congratulations you won.\n " +
                $"you: {playerTotal} dealer: {dealerTotal}";
        }
        else if (playerTotal > 21)
        {
            message = $"player excedeed 21 \n player:{playerTotal} dealer: {dealerTotal}";
        }
        else
        {
            message = $"Draw \n player:{playerTotal} dealer: {dealerTotal}";
        }

    Console.WriteLine(message);
        break;

    default:
        Console.WriteLine( "valor no admitido" );
        break;
}