using System;
using System.Collections.Generic;
class Vendeur
{
    private ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string client, string informations)
    {
        constructeur.ConstruitBonDeCommande(client);
        constructeur.ConstruitDemandeImmatriculation(informations);
        Console.WriteLine(constructeur.Resultat());
        return constructeur.Resultat();
    }
}