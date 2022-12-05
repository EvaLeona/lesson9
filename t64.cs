String NaturalNumbers(int N)
{
    if (N == 1) return N.ToString();
    return $"{N}, {NaturalNumbers(N - 1)}";
}


int[] data = new int[] { 5, 8 };
foreach (int item in data)
{
    Console.WriteLine($"N = {item,2} ->  \"{NaturalNumbers(item)}\"");
}