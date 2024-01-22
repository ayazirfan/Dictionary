//Dictionary uygulaması

Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10, "Ayşe Yılmaz");
kullanıcılar.Add(12, "Ahmet yılmaz");
// kullanıcılar.Add(12, "Ahmet yılmaz");
kullanıcılar.Add(18, "Deniz Arda");
kullanıcılar.Add(20, "Özcan KAşar");

//Dizinin Elemanlarına erişim
System.Console.WriteLine("***** Elemanlara Erişim ******");
System.Console.WriteLine(kullanıcılar[12]);
foreach (var item in kullanıcılar)
{
    System.Console.WriteLine(item);
}

//count **eleman sayısı
System.Console.WriteLine("***** Count ******");
System.Console.WriteLine(kullanıcılar.Count);

//Contains** değer-eleman sorgulama
System.Console.WriteLine(" ******* Countes *******");
System.Console.WriteLine(kullanıcılar.ContainsKey(12));
System.Console.WriteLine(kullanıcılar.ContainsValue("irfan ayaz"));

// Remove
System.Console.WriteLine("***** Remove ******");
kullanıcılar.Remove(20);

foreach (var item in kullanıcılar)
{
    System.Console.WriteLine(item.Value);
}

//Keys
System.Console.WriteLine("**** Keys *****");
foreach (var item in kullanıcılar.Keys)
{
    System.Console.WriteLine(item);
}
//Value 
System.Console.WriteLine("***** value ****");
foreach (var item in kullanıcılar.Values)
{
    System.Console.WriteLine(item);
}