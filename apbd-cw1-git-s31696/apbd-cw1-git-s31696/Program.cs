// See https://aka.ms/new-console-template for more information
int[] newtab = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write("i:" + i);
    Console.Write(" i % 2? ");
    Console.WriteLine(i % 2 == 0 ? "tak" : "nie");
    newtab[i] = i;
}
