using System;

// Décorateur concret : Ajout de lait
public class Lait : CafeDecorator
{
    // Appelle le constructeur de CafeDecorator avec le café à décorer
    public Lait(ICafe cafe) : base(cafe) { }

    // Ajoute le coût du lait au coût du café de base
    public override double GetCost() => base.GetCost() + 0.5;

    // Ajoute " + lait" à la description du café
    public override string GetDescription() => base.GetDescription() + " + lait";
}