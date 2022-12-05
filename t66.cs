int Summ(int M, int N)
{
    if (N == M) return N;
    return N + Summ(M,N - 1);
}


int[][] data = new int[][]
{
    new int[] {1,15},
    new int[] {4,8}
};
foreach (int[] item in data)
{
    Console.WriteLine($"M = {item[0],2}; N = {item[1],2}  ->  {Summ(item[0], item[1]),3}");
}