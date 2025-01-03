using System;
// Classe abstraite pour les décorateurs de café
// Elle implémente également ICafe pour garantir qu'elle peut être utilisée comme un café
public abstract class CafeDecorator : ICafe
{
    protected ICafe cafe; // Référence au café "de base" ou à un autre décorateur

    // Constructeur recevant un objet ICafe
    public CafeDecorator(ICafe cafe)
    {
        this.cafe = cafe;
    }

    // Implémente les méthodes de l'interface en déléguant au café de base
    public virtual double GetCost() => cafe.GetCost();
    public virtual string GetDescription() => cafe.GetDescription();
}