// FOR EACH

//string phrase = "the quick brown fox jumped over the lazy dog";

//Parallel.ForEach(phrase.Split(), words =>
//{
//    char[] arr = words.ToCharArray();
//    Array.Reverse(arr);
//    Console.WriteLine(new String(arr));
//});


// FOR ALL 
//string phrase = "the quick brown fox jumped over the lazy dog";

//phrase.Split(' ').AsParallel().ForAll(x =>
//{
//    char[] arr = x.ToCharArray();
//    Array.Reverse(arr);
//    Console.WriteLine(arr);
//});

//Avec pleins de mots 
string phrase = "the quick brown fox jumped over the lazy dog";

var phrases = Enumerable.Range(1, 1000).Select(i => phrase).Aggregate("", (t, s) => t + s);

Console.WriteLine(phrases);