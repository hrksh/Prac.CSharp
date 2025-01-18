namespace Prac.Algorithm;

class Map()
{
    private int _x = 0;
    private int _y = 0;
    public int X => this._x;
    public int Y => this._y;
    // TODO:Warning 後で直す
    private Dot[,] DotMap = null;
    public Map(int x, int y) : this()
    {
        this._x = x;
        this._y = y;
        this.DotMap = new Dot[this._x, this._y];
    }
    public void Show()
    {
        for (int i = 0; i < this._x; i++)
        {
            for (int j = 0; j < this._y; j++)
            {
                this.DotMap[i,j] = new Dot(DotStat.None);
                Console.Write(this.DotMap[i, j].GetVal());
            }
            Console.WriteLine();
        }
    }
}
enum DotStat { None, Maru, Batsu }
class Dot()
{
    DotStat _stat = DotStat.Batsu;
    public Dot(DotStat stat) : this() { this.SetStat(stat); }
    public void SetStat(DotStat stat) { _stat = stat; }
    public string GetVal()
    {
        string result = string.Empty;
        switch(this._stat) {
            case DotStat.None  : result = "-" ; break;
            case DotStat.Batsu : result = "❌"; break;
            case DotStat.Maru  : result = "⭕️"; break;
        }
        return result;
    }
}

abstract class Player
{
    // どうしようかな
}
