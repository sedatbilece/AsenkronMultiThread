
var mytask =  new HttpClient().GetStringAsync("https://www.google.com")
    .ContinueWith((data) =>
    {
        Console.WriteLine(data.Result.Length);
    });



Console.WriteLine("ara işlemler");

await mytask;
