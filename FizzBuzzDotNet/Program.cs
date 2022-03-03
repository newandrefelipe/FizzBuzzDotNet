using FizzBuzzDotNet;

var fizzBuzz = new FizzBuzz();

for (var i = 0; i <= 100; i++)
{
    Console.WriteLine(fizzBuzz.Exec(i));
}