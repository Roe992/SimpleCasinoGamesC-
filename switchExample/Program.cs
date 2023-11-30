// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int playerTotal = 0;
int dealerTotal = 0;
string message = "";
int num = 0;
int numD = 0;

string switchControl = "menu";

//blackjack
while (true)
{
    switch (switchControl)
    {

        case "menu":
            Console.WriteLine("Welcome to C# A S I N O \n Para Blackjack ingrese 21");
            switchControl = Console.ReadLine();
            break;

        case "21":
            Console.WriteLine("Welcome to 21 Blackjack");
                System.Random random = new System.Random();
            numD = random.Next(1, 12);
            dealerTotal += numD;
            playerTotal = random.Next(1, 12);
            Console.WriteLine($"your first card is {playerTotal} \n Dealer´s hand: {dealerTotal} \n your total is: {playerTotal}");
            do
            {

                
                num = random.Next(1, 12);
                playerTotal = playerTotal + num;
                Console.WriteLine($"your new card is: {num} \n Dealer´s hand: {dealerTotal} \n your total is: {playerTotal}");
                if (playerTotal < 21) { Console.WriteLine("do you want to hit or stand"); }


            } while (playerTotal < 21 && Console.ReadLine() == "hit");

            while (dealerTotal < 17 && playerTotal <= 21)
            {
                numD = random.Next(1, 12);
                dealerTotal += numD;
                Console.WriteLine($"The dealer draws a card :{numD} \n Dealer´s total : {dealerTotal}");
            }
                        
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
            playerTotal = 0;
            dealerTotal = 0;
            switchControl = "menu";
            break;

        default:
            Console.WriteLine("valor no admitido");
            switchControl = "menu";
            break;
    }
}