using System;
using System.Collections.Generic;
class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculeHtml()
    {
        liasse = new LiasseHtml();
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande HTML pour le client : {client}");
    }

    public override void ConstruitDemandeImmatriculation(string informations)
    {
        liasse.AjouteDocument($"Demande d'immatriculation HTML avec informations : {informations}");
    }
}
