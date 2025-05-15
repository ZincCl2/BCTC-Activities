using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Array;
using static System.String;
internal class Program
{

    static void Main(string[] args)
    {
        string[] deckOfCards = {"2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "King of Spades", "Queen of Spades", "Jack of Spades", "Ace of Spades",
                                    "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "King of Clubs", "Queen of Clubs", "Jack of Clubs", "Ace of Clubs",
                                    "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "King of Hearts", "Queen of Hearts", "Jack of Hearts", "Ace of Hearts",
                                    "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "King of Diamonds", "Queen of Diamonds", "Jack of Diamonds", "Ace of Diamonds"};

        string[] playerDeck = new string[26];
        string[] computerDeck = new string[26];
        Shuffle(deckOfCards);
        //FillDeck(deckOfCards, ref playerDeck, ref computerDeck);
        WriteLine("Shuffled Deck");
        SplitCards(playerDeck, computerDeck, deckOfCards);

        PlayRounds(playerDeck, computerDeck);
    }
    private static void Shuffle(string[] DeckArray)
    {
        Random random = new Random();
        int n = DeckArray.Length;
        while (n > 1)
        {
            int k = random.Next(n--);
            string temp = DeckArray[n];
            DeckArray[n] = DeckArray[k];
            DeckArray[k] = temp;
        }
    }

    private static void SplitCards(string[] playArray, string[] compArray, string[] shuffledDeck)
    {
        int compIndex = 0;
        int playIndex = 0;
        for (int i = 0; i < 52; i++)
        {
            int mod = i % 2;
            if (mod == 1)
            {
                playArray[playIndex] = shuffledDeck[i];
                playIndex += 1;
            }
            else
            {
                compArray[compIndex] = shuffledDeck[i];
                compIndex += 1;
            }
        }
    }
    private static void PlayRounds(string[] playerDeck, string[] computerDeck)
    {
        int playerScore = 0;
        int computerScore = 0;
        for (int i = 0; i < 26; i++)
        {
            int playCardValue = 0;
            int compCardValue = 0;
            WriteLine("Deal #" + (i + 1));
            WriteLine("   Computer has " + computerDeck[i]);
            WriteLine("   Player has " + playerDeck[i]);
            
            string PlayCard = playerDeck[i].Substring(0, 1);
            string CompCard = computerDeck[i].Substring(0, 1);

            //Player Card Value

            if (PlayCard == "A")
            {
                playCardValue = 1;
            }
            else if (PlayCard == "2")
            {
                playCardValue = 2;
            }
            else if (PlayCard == "3")
            {
                playCardValue = 3;
            }
            else if (PlayCard == "4")
            {
                playCardValue = 4;
            }
            else if (PlayCard == "5")
            {
                playCardValue = 5;
            }
            else if (PlayCard == "6")
            {
                playCardValue = 6;
            }
            else if (PlayCard == "7")
            {
                playCardValue = 7;
            }
            else if (PlayCard == "8")
            {
                playCardValue = 8;
            }
            else if (PlayCard == "9")
            {
                playCardValue = 9;
            }
            else if (PlayCard == "1")
            {
                playCardValue = 10;
            }
            else if (PlayCard == "J")
            {
                playCardValue = 11;
            }
            else if (PlayCard == "Q")
            {
                playCardValue = 12;
            }
            else
            {
                playCardValue = 13;
            }

            //Computer Card Value

            if (CompCard == "A")
            {
                compCardValue = 1;
            }
            else if (CompCard == "2")
            {
                compCardValue = 2;
            }
            else if (CompCard == "3")
            {
                compCardValue = 3;
            }
            else if (CompCard == "4")
            {
                compCardValue = 4;
            }
            else if (CompCard == "5")
            {
                compCardValue = 5;
            }
            else if (CompCard == "6")
            {
                compCardValue = 6;
            }
            else if (CompCard == "7")
            {
                compCardValue = 7;
            }
            else if (CompCard == "8")
            {
                compCardValue = 8;
            }
            else if (CompCard == "9")
            {
                compCardValue = 9;
            }
            else if (CompCard == "1")
            {
                compCardValue = 10;
            }
            else if (CompCard == "J")
            {
                compCardValue = 11;
            }
            else if (CompCard == "Q")
            {
                compCardValue = 12;
            }
            else
            {
                compCardValue = 13;
            }

            //Determine Score distribution

            if (playCardValue > compCardValue)
            {
                playerScore += 2;
            }
            else if (playCardValue < compCardValue)
            {
                computerScore += 2;
            }
            else
            {
                playerScore += 1;
                computerScore += 1;
            }
            WriteLine("Computer score is " + computerScore);
            WriteLine("Player score is " + playerScore);
            //substring first char | select case for card value | determine who wins | award score

            ReadLine();
        }
        if (playerScore > computerScore)
        {
            WriteLine("Player wins!");
        }
        else if (computerScore > playerScore)
        {
            WriteLine("Computer wins!");
        }
        else
        {
            WriteLine("It's a draw!");
        }
    }
}


