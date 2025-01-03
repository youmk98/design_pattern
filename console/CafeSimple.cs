using System;

// Classe de base pour un café simple (implémentation par défaut de ICafe)
public class CafeSimple : ICafe
{
    // Retourne le coût d'un café simple
    public double GetCost() => 2.0;

    // Retourne la description d'un café simple
    public string GetDescription() => "Café simple";
}