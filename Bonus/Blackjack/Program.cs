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
 * 
 * 
 * 
 */

using Blackjack;

var game = new Game();
var deck = new Deck();
var player  = new Player(1000);
var house  = new House();

