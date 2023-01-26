var rand = new Random();

var listNumbers = new List<int>();
var number = 0;

    do {
        number = rand.Next(1, 29);
    } while (listNumbers.Contains(number));
    listNumbers.Add(number);

Console.WriteLine(number);
    


