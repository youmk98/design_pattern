using System;

public abstract class Document
{
    protected string contenu;

    public void SetContenu(string contenu){
        this.contenu = contenu;
    }
    public abstract void dessine();
    public abstract void imprime();


}
