// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("I love my shoes!");
}

void HereIsAFunction()
{
    Console.WriteLine("Function");
}

HereIsAFunction();

int a = 4;
int b = 5;
Console.WriteLine(a+b);

static float calculateTheAverage(int [] arr )
{
    float counter = 1; //started from 1
    for (int i =0; i<arr.Length; i++)
    {
        counter += arr[i];
    }
    counter =counter/ arr.Length;
    
    return counter;
}

static int calculateTheMax(int[] arr)
{
    return arr.Max();
}

int[] arr = [1,2,3,4,5,6,7,8,21,9,10,11,14];
Console.WriteLine(calculateTheAverage(arr));
Console.WriteLine(calculateTheMax(arr));