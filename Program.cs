using System;

class Program
{
    static void Main(string[] args)
    {
        string nomeDoPlayer = "PVP FM";
        int level = 4000;
        string elo = "";

        Console.WriteLine("Coloque seu nickname");
        nomeDoPlayer = Console.ReadLine();

        Console.WriteLine("Coloque qual é seu Level");
        level = int.Parse(Console.ReadLine());

        if (level < 1000){
            elo = "Ferro";
        }

        else if (level <= 2000){
            elo = "Bronze";
        }

        else if (level <= 5000){
            elo = "Prata";
        }

        else if (level <= 7000){
            elo = "Ouro";
        }

        else if (level <= 8000){
            elo = "Platina";
        }

        else if (level <= 9000){
            elo = "Ascendente";
        }

        else if (level <= 10000){
            elo = "Imortal";
        }

        else {
            elo = "Radiante";
        }

            
        Console.WriteLine($"O Player de nick {nomeDoPlayer} está no ranking atual {elo}");
    }
}