Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberSum(int number){
    int numberSum = 0;
    while (number != 0)
    {
        numberSum += number % 10;
        number /= 10;
    }
    return numberSum;
}
int result = numberSum(number);
Console.WriteLine($"Sum {result}");