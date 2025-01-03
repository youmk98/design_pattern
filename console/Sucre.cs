using System;

// Décorateur concret : Ajout de sucre
public class Sucre : CafeDecorator
{
// Appelle le constructeur de CafeDecorator avc le café à décorer
    public Sucre(ICafe cafe) : base(cafe) { }

    // Ajoute le coût du sucre au coût du café de base
    public override double GetCost() => base.GetCost() + 0.2;

    // Ajoute la mention " + sucre" à la description du café
    public override string GetDescription() => base.GetDescription() + " + sucre";
}
