using System;

public class DocumentPdf : Document
{
    private ComposantPdf outilPdf = new ComposantPdf();

    public void SetContenu(string contenu){
        outilPdf.PdfFixeContenu(contenu);
    }

   public override void dessine()
    {
        outilPdf.PdfPrepareAffichage();
        outilPdf.PdfRafraichit();
        outilPdf.PdfTermineAffichage();
    }

    public override void imprime()
    {
        outilPdf.PdfEnvoieImprimante();
    }

}
