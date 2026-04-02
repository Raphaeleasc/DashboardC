
using System;
using System.Windows.Forms;
class Switch{
    private string HasNic = "";
    private string HasMacAdresse = "";

    public Switch(string hasNic,string hasMacAdresse )
    {
        HasNic = hasNic;
        HasMacAdresse = hasMacAdresse;
    }
    public Switch()
    {
        
    }

    public void printswitch()
    {
        Console.Write(HasNic);
        Console.Write(" : ",HasMacAdresse);
    }
    public string GetMacAdresse(){
        return HasMacAdresse;
    }
    public string GetNic(){
        return HasNic;
    }
}

class Programmain{
    public static void Main(){
    string nom = "Raphael";
    int age = 22;
    Console.WriteLine($"Bonjour {nom}, vous avez {age} ans");
    Switch swit = new Switch("bananz","banana");
    Switch swit1 = new Switch("banane","banane");
    Switch swit2 = new Switch("banano","banano");
    Switch[] switches = [swit,swit1,swit2];
    foreach(Switch swat in switches){
        swat.printswitch();
    }
    Application.Run(new MyWindow());
   }
}