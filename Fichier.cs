using System;


class Calcul
{
    private int lastcalcul;
    public int Getlastcalcul()
    {
        return this.lastcalcul;
    }
    public int Addition(int a,int b)
    {
        lastcalcul = a+b;
        return lastcalcul;
    }
}
class Fichier
{
   public static void Main()
    {
        Console.WriteLine("Gotta live");
        int a = 5;
        int b =25;
        Calcul calcul = new Calcul();
        int c = calcul.Addition(a,b);
        Console.WriteLine($"{a}+{b} = {calcul.Getlastcalcul()}");
    }
}