System.Console.WriteLine("Введите длинну массива");
int r = Convert.ToInt32(Console.ReadLine());
int[] array = new int[r];
string[] arrString = new string[r];

void feelPrintArr (string[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        System.Console.WriteLine($"Введите {i} эллемент");
        ar[i] = Console.ReadLine();
    }

    System.Console.WriteLine();
for (int i = 0; i < arrString.Length; i++)
    {
        System.Console.Write(arrString[i] + " ");
    }
}

feelPrintArr(arrString);


