Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}
