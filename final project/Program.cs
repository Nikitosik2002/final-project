System.Console.WriteLine("Введите длинну массива");
int r = Convert.ToInt32(Console.ReadLine());
int[] array = new int[r];
string[] arrString = new string[r];

void feelArr (string[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        System.Console.WriteLine($"Введите {i} эллемент");
        ar[i] = Console.ReadLine();
    }

}

void printArr(string[] ar)
{
    System.Console.WriteLine();
    for (int i = 0; i < ar.Length; i++)
    {
        System.Console.Write(ar[i] + " ");
    }
}

feelArr(arrString);
printArr(arrString);



int count = 0;
for (int i = 0; i < arrString.Length; i++)
{
    if(arrString[i].Length <= 3)
    {
        count += 1;
    }
   
}
string[] arrString2 = new string[count];

int count2 = 0;
string box = string.Empty;
for (int i = 0; i < arrString.Length; i++)
{
    if(arrString[i].Length <= 3)
    {
        box = arrString[i];
        arrString2[count2] = box;
        count2 += 1;
    }
}

printArr(arrString2);
