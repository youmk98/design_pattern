using System;

public class FormulaireImmatriculationLuc : FormulaireMultiLang {

    FormulaireImmatriculation implementation;
    public FormulaireImmatriculationLuc(FormulaireImmatriculation implementation) : base(implementation)
        {
            this.implementation = implementation;
        }

    string message ="LUX";    
    public void afficher(string message){
        implementation.afficher(message);
    }    
    
}