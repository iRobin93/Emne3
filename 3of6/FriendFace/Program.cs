/*
 * Oppgave FriendFace:
 * 1. Lage nødvendige klasser: user
 * 2. lage metodene AddFriend og RemoveFriend
 * 3. Lage meny
 * 4. lage brukere.
 * 
 * 
 */


using System.Reflection.Metadata;
using FriendFace;



ConsoleKeyInfo input;
User MyUser = new User("Robin", "Test1@hotmail.no", "1234", "Hei, jeg heter Robin");
void WriteMenu()
{
    Console.WriteLine("Hei og velkommen til FriendFace");
    Console.WriteLine("Tast 1 for å legge til en venn");
    Console.WriteLine("Tast 2 for å fjerne en venn");
    Console.WriteLine("Tast 3 for å vise alle dine venner");
    Console.WriteLine("Tast 4 for å velge en venn og å printe ut infoen deres");
    Console.WriteLine("Tast 5 for å avslutte");

}


User.Users.Add(MyUser);
User.Users.Add(new User("Ole Morten", "Test2@hotmail.no", "1234", "Hei, jeg heter Ole Morten"));
User.Users.Add(new User("Mona", "Test3@hotmail.no", "1234", "Hei, jeg heter Mona"));
User.Users.Add(new User("Charlotte", "Test4@hotmail.no", "1234", "Hei, jeg heter Charlotte1"));
User.Users.Add(new User("Charlotte", "Test5@hotmail.no", "1234", "Hei, jeg heter Charlotte2"));


while (true)
{
    
    WriteMenu();
     input = Console.ReadKey();


    switch (input.KeyChar)
    {
        case '1':
            MyUser.AddFriend();
            break;
        case '2':
            MyUser.RemoveFriend();
            break;
        case '3':
            MyUser.ShowFriends();
            break;
        case '4':
            MyUser.WriteFriendInfo();
            break;
        case '5': goto EndWhile;
            break;
    }
    Console.Clear();
}
EndWhile:
Console.WriteLine("");
Console.WriteLine("Press enter to exit");
Console.ReadLine();