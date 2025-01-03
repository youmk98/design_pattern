using System;

public class FormulaireImmatriculationApplet : FormulaireImmatriculation {

    
    
    string message;
    
    public override void afficher(string message){
        Console.WriteLine("Applet : " +message );
    }
    
}