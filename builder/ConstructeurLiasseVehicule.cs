using System;

using System.Collections.Generic;

abstract class ConstructeurLiasseVehicule
{
    protected Liasse liasse;

    public Liasse Resultat()
    {
        return liasse;
    }

    public abstract void ConstruitBonDeCommande(string client);
    public abstract void ConstruitDemandeImmatriculation(string informations);
}