using System;
using System.Collections.Generic;
class LiasseHtml : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Impression de la liasse HTML :");
        foreach (var document in documents)
        {
            Console.WriteLine(document);
        }
    }
}