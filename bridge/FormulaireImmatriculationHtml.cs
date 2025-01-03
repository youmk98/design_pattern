using System;

public class FormulaireImmatriculationHtml : FormulaireImmatriculation {

    string message;
    
    public override void afficher(string message){
        Console.WriteLine(message);
    }
    
}