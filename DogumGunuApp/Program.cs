// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int[] a = { 1995, 2023 };
int ayCounter = 1;
int gunCounter = 1;

int i = 0;
int AliAbiYas = 0;

while(i < a.Length)
{
    if (a[i] == 2023 && ayCounter == 9 && gunCounter == 22)
    {
        AliAbiYas++;
        Console.WriteLine("Ali abi " + AliAbiYas + ".yaşın kutlu olsun.");
        Thread.Sleep(4000);
        i = a.Length;
        continue;
    }
    if (ayCounter == 9 && gunCounter == 22)
    {
        AliAbiYas++;
        Console.WriteLine("Ali abi " + AliAbiYas +".yaşın kutlu olsun.");
        Thread.Sleep(4000);
    }
    if (ayCounter == 12)
    {
        ayCounter = 1;
        a[0] += 1;
    }
    if (gunCounter == 30)
    {
        ayCounter++;
        gunCounter = 1;
    }

    Console.WriteLine(gunCounter + "/" + ayCounter + "/" + a[0]);
    gunCounter++;
}


