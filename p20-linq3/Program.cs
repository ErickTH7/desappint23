List<string> frutas = new() {"xoconostle","pera","melon","sandia","durazno","manzana","platano","kiwi","naranja","jicama","papaya","limas","moras","lichis","guamuchiles"};

Console.Clear();

var mfrutas = (from f in frutas where f.StartsWith('m') select f).ToList();
Console.WriteLine("\nfrutas que empiecen con la letra m " + mfrutas.Count());
mfrutas.ForEach(f => Console.Write(f + " "));

var anfrutas = (from f in frutas where f.Contains("an") select f).ToList();
Console.WriteLine("\nfrutas que empiecen con la letra an " + anfrutas.Count());
anfrutas.ForEach(f => Console.Write(f + " ")); 

var xz = (from f in frutas where (f.Contains("x") || f.Contains("z")) select f).ToList();
Console.WriteLine("\nfrutas que empiecen con la letra xz " + xz.Count());
xz.ForEach(f => Console.Write(f + " ")); 