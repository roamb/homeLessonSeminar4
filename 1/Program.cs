int A = ReadLine("Enter first number: ");
int B = ReadLine("Enter second number: ");
Console.WriteLine(Degre(A, B));
int ReadLine(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Degre(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
} 