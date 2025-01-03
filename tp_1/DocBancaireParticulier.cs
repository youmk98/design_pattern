using System;

public class DocBancaireParticulier: IDocBancaire{

    public  IRib getrib(){
        return new RibParticulier();
    }
    public  IAts getats(){
        return new AtsParticulier();
    }
}