
Console.ReadLine();
// Linq で複数入力された文字列を辞書へ変換
var dict = Console.ReadLine().Trim().Split()
    .Select(int.Parse)
    .GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
for (int i = 0; i <= 9; i++)
{
    if (!dict.ContainsKey(i))
    {
        dict[i] = 0;
    }
}
Console.WriteLine(
    string.Join(" ", dict.OrderBy(x => x.Key)
        .Select(b => b.Value)
        .ToArray()));