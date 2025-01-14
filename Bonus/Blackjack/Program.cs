/* Strategi
 * 
 * klasse for stokk
 * Klasse for card
 * Klasse for spillet
 * Klasse for spiller
 * Klasse for huset
 * klasse for hånd
 * 
 * 
 * 1. lage spillobjekt, stokk, cards, spiller og huset
 * 1.5. spiller får 1000kr
 * 2. Shuffle kort. Legge kortene inn i stokken på random plass.
 * 2.5 Bet
 * 3. dele ut kort - først ett kort til spiller, så ett til seg huset - kortet er et objekt som flyttes fra stokken til spiller eller huset. man ser kortet til spilleren, kortet til huset er synlig.
 * 4. dele ut kort - andre kort til spiller er synlig - andre kort til huset er skjult.
 * 4.5 hvis huset har ace synlig - spiller spurt om forsikring. etter dette er spillet ferdig hvis huset har blackjack.
 * 5 - spørre spiller hva den vil gjøre ? 1 - trekke kort 2: stå - 3: doble - 4: split hvis kortene er like.
 * 6. etter 3 kortet er trukket, kan ikke doble lenger. løkke på å trekke, til spiller velger stå eller har mer enn 21.
 * 7. sjekk vinn eller tap - spiller får eller taper penger.
 * 8. goto 2.5 eller punkt 2 dersom man skal shuffle på nytt etter 40 kort.
 * 
 */


using System.Reflection.Metadata.Ecma335;
using Blackjack;

var deck = new Deck();
var player  = new Player(1000);
var house  = new House();
var game = new Game(deck, player, house);
string bet = "";
char input;



void WriteInfo()
{
    Console.WriteLine("Huset har: " + house.GetStringCardsInHand(true) + "Du har: " + player.GetStringCardsInHand(0, false));
}


deck.ShuffleCards();
//deck.WriteAllCards();



do
{
    Console.WriteLine("Hvor mye vil du bette ? Du har: " + player.GetMoney() + " kroner");
    
    game.StartRound();
    // Todo: Feilhåndtering på feil input.
    bet = Console.ReadLine();
    player.SetBet(Int32.Parse(bet), 0);

    game.DealCardPlayer(0, false);
    game.DealCardHouse();
    game.DealCardPlayer(0, false);
    game.DealCardHouse();
    WriteInfo();
    RankEnum card1RankEnum = house.GetValueOfCard(0);
    if (card1RankEnum == RankEnum.Ace)
    {
        Console.WriteLine("Vil du ha forskikring ? J/N");
        input = Console.ReadKey().KeyChar;
        if (input == 'J' || input == 'j')
        {
            player.SetInsurance(true);
        }
        var card2RankEnum = house.GetValueOfCard(1);
        if (card2RankEnum == RankEnum.Ten)
        {
            Console.WriteLine("Huset har Blackjack");
            if (!player.HasInsurance())
                if (!player.HasBlackJack(0))
                    player.RemoveOrAddMoney(false, 1, 0);
                else
                {
                    Console.WriteLine("Det er likt.");
                }
            else
            {
                player.RemoveInsuranceMoney();
            }

            goto EndBecauseBlackjack;
        }
        else
        {
            Console.WriteLine("Huset har ikke Blackjack!");
            player.RemoveInsuranceMoney();
        }
    }

    //Todo split
    int Hands = 1;
    for (int i = 0; i < Hands; i++)
    {
        do
        {
            Console.WriteLine(game.GetWriteString(i));
            //Todo: input feilhåndtering.
            input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();
            if (input == '1')
            {
                game.DealCardPlayer(i, true);
                if (!player.CheckIfHandDone(i))
                    WriteInfo();

            }
            else if (input == '2')
            {
                player.HandDone(i);
            }
            else if (input == '3')
            {
                game.DealCardPlayer(i, true);
                player.DoubleBet(i);
                player.HandDone(i);
            }
            else if (input == '4')
            {
                player.SplitHand(i);
                game.DealCardPlayer(i, true);
                game.DealCardPlayer(Hands, true);
                Hands++;
            }

        } while (!player.CheckIfHandDone(i));
    }
    game.EndRound();
EndBecauseBlackjack:
    Console.WriteLine("Vil du fortsette å spille? J/N");
    input = Console.ReadKey().KeyChar;
    Console.WriteLine();
} while (input != 'N' && input != 'n');


