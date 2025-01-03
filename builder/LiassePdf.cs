using System;
using System.Collections.Generic;
class LiassePdf : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Impression de la liasse PDF :");
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }
}