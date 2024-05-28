namespace Composite_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Folder directory = new Folder("MNS");
            Folder directory1 = new Folder("Blizzard");
            Folder directory2 = new Folder("World Of Warcraft");

            File file1 = new File("projet.txt", 13.82);
            File file2 = new File("REAC.pdf", 152.34);
            File file3 = new File("WoW.exe", 400.72);
            File file4 = new File("BattleNetClient.exe", 340.14);
            File file5 = new File("LeroyJenkin.txt", 1023.72);


            directory.Components.Add(file1);
            directory.Components.Add(file2);

            directory1.Components.Add(directory2);
            directory1.Components.Add(file4);
            directory2.Components.Add(file3);
            directory2.Components.Add(file5);



            Console.WriteLine($"La taille du dossier \"{directory.Name}\" est de {directory.GetSize()} MB.");

            Console.WriteLine($"La taille du dossier \"{directory1.Name}\" est de {directory1.GetSize()} MB.");

            Console.WriteLine($"La taille du dossier \"{directory2.Name}\" est de {directory2.GetSize()} MB.");
        }
    }
}