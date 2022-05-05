int[] numbers = { 1, -4, 5, 10, -100, 5, -56, 1};

var result1 = numbers.Where(i => i > 0);

foreach(var e in result1)
    Console.Write($"{e}  ");

