/* Oppskrift
 * 1. Lage nødvendige klasser
 * bruker
 * 2. Lage metodene
 * Addfriend og RemoveFriend
 * 3. Lage konsoll menyen
 * Legge til forskjellige brukere som venn (på den som er innlogget)
 * Fjerne brukere som venn
 * Printe ut en liste av alle man har lagt til som venn
 * Velge en av vennene og printe ut profilinformasjonen deres.
 * 4. Implementere meny valgene
 *  
 * 
 */


void WriteMenu(){
    Console.Clear();
    Console.WriteLine("Tast 1 for å legge til en venn");
    Console.WriteLine("Tast 2 for å fjerne en venn");
    Console.WriteLine("Tast 3 for å printe ut alle vennene dine");
    Console.WriteLine("Tast 4 for å hente ut profil info om en venn");
}


WriteMenu();
Console.ReadKey();