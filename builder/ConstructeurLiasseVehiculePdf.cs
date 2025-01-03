using System;
using System.Collections.Generic;
class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
{
    public ConstructeurLiasseVehiculePdf()
    {
        liasse = new LiassePdf();
    }

    public override void ConstruitBonDeCommande(string client)
    {
        liasse.AjouteDocument($"Bon de commande PDF pour le client : {client}");
    }

    public override void ConstruitDemandeImmatriculation(string informations)
    {
        liasse.AjouteDocument($"Demande d'immatriculation PDF avec informations : {informations}");
    }
}