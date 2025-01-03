using System;
using System.Collections.Generic;
class ClientVehicule
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choisissez le type de liasse (HTML ou PDF) :");
        string choix = Console.ReadLine();

        ConstructeurLiasseVehicule constructeur;

        if (choix?.ToUpper() == "HTML")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }
        Console.WriteLine(constructeur);
        Vendeur vendeur = new Vendeur(constructeur);
        Liasse liasse = vendeur.Construit("Client ABC", "Informations XYZ");

        liasse.Imprime();
    }
}