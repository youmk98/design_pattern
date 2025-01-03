using System;

public class AutomobileEssence : Automobile
{
  public AutomobileEssence(string modele, string couleur,
    int puissance, double espace) : base(modele, couleur,
    puissance, espace){}

  public override void afficheCaracteristiques()
  {
    Console.WriteLine("Automobile � essence de mod�le : "
      + modele + " de couleur : " + couleur + 
      " de puissance : " + puissance + " d'espace : " +
      espace);
  }
}
