using System;

public class DocumentHtml : Document
{
    protected string contenu;

    public void SetContenu(string contenu){
        this.contenu = contenu;
    }

    public override void dessine(){
        Console.WriteLine("Déssiner doc html");
    }
    public override void imprime(){
        Console.WriteLine("Imlprimer doc html");
    }
    

}
