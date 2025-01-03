using System;

public class ServeurWeb
{
    public static void Main(string[] args)
    {
        Document documentHtml = new DocumentHtml();
        documentHtml.SetContenu("Document HTML");
        documentHtml.dessine();
        documentHtml.imprime();

        Document documentPdf = new DocumentPdf();
        documentPdf.SetContenu("Document PDF");
        documentPdf.dessine();
        documentPdf.imprime();
    }
}

