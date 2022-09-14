// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] array = new string[]{"hello","2","world","(-:"};
//Console.WriteLine(array[0] + array[1] + array[2] + array[3]);
int count = 0;
for (int i=0;i<array.Length;i++)
{
//Console.WriteLine(array[i]);
//string text = array[i];
if(array[i].Length<4)
    {
        count += 1;
    }
}
//Console.WriteLine(count);
string[] array2 = new string[count];

count = 0;
for (int i=0;i<array.Length;i++)
{
    if(array[i].Length<4)
    {
        array2[count] = array[i];
        Console.WriteLine(array2[count]);
        count += 1;
    }
}