using System;

public class ComposantPdf
{
    private string contenu;

    public void PdfFixeContenu(string contenu)
    {
        this.contenu = contenu;
    }

    public void PdfPrepareAffichage()
    {
        Console.WriteLine("Préparation de l'affichage du PDF.");
    }

    public void PdfRafraichit()
    {
        Console.WriteLine($"Affichage du PDF : {contenu}");
    }

    public void PdfTermineAffichage()
    {
        Console.WriteLine("Fin de l'affichage du PDF.");
    }

    public void PdfEnvoieImprimante()
    {
        Console.WriteLine("Impression du PDF.");
    }
}