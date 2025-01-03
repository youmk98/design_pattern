// professionnels
IDocBancaire doc_pro = new DocBancaireProfessional();
IRib rib_pro = doc_pro.getrib();
IAts ats_pro = doc_pro.getats();

Console.WriteLine(rib_pro.rib());
Console.WriteLine(ats_pro.ats());
// particuliers
IDocBancaire doc_part = new DocBancaireParticulier();
IRib rib_part = doc_part.getrib();
IAts ats_part = doc_part.getats();

Console.WriteLine(rib_part.rib());
Console.WriteLine(ats_part.ats());