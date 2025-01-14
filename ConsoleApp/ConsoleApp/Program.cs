
// コンソールで 3目並べを作ってみる
// 考え中
// 一旦マップ表示だけする

Map baseMap = new Map(3, 3);
baseMap.Show();

class Map()
{
    private int _x = 0;
    public int X => this._x;
    private int _y = 0;
    public int Y => this._y;
    public Map(int x, int y) : this()
    {
        this._x = x;
        this._y = y;
    }
    
    
    // 明日これをDotクラス利用して置き換える
    public void Show()
    {
        for (int i = 0; i < this._x; i++)
        {
            for (int j = 0; j < this._y; j++)
            {
                Console.Write ("#");
            }
            Console.WriteLine();
        }
    }
}

enum DotStat { Maru, Batsu }
class Dot()
{
    DotStat _stat = DotStat.Batsu;
    public void SetStat(DotStat stat)
    {
        _stat = stat;
    }
    public string Val => (DotStat.Batsu == this._stat ? "❌" : "⭕️");
}