Console.Write("How many numbers you want to input: ");
int amountOfNumbers = 1;
float result = 0;
bool invalidinput = true;
while (!int.TryParse(Console.ReadLine(), out amountOfNumbers))
{
    Console.Write("Invalid input. Please enter one more time: ");
}
float[] arr = new float[amountOfNumbers];
for (int i = 0; i < amountOfNumbers; i++)
{
    while (invalidinput == true)
    {
        try
        {
            Console.Write("Input your " + (i + 1) + " number ");
            arr[i] = float.Parse(Console.ReadLine());
            result += arr[i];
            break;
        }
        catch
        {
            Console.Write("Invalid input. ");
        }
    }
}
result /= amountOfNumbers;
Console.WriteLine("Your number is " + result);
Console.ReadLine();