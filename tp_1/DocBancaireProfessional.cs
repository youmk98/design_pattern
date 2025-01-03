using System;

public class DocBancaireProfessional: IDocBancaire{

    public  IRib getrib(){
        return new RibProfessional();
    }
    public  IAts getats(){
        return new AtsProfessional();
    }
}