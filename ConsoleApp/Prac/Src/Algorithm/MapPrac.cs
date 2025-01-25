using System.Runtime.CompilerServices;

namespace Prac.Algorithm;

public class MapPrac
{
    private int _n = 0;
    public int N { get { return this._n; } }
    public MapPrac(int n)
    {
        this._n = n;
        this.baseMap = new int[this._n, this._n];
        this.inputMap = new int[this._n, this._n];
        this.cntCenter = (this._n) / 2;
        this.cIdx = this._n / 2;
        this.MakeBaseMap(this._n);
        this.MakeInputMap(this._n);
        Console.WriteLine(this.GetMoveOutCount());
    }
    
    
    // 中心は (N+1) / 2 個おかれる
    private int cntCenter = 0;
    // 中心の座標は必ず真ん中になるので、
    private int cIdx = 0;
    
    // NxN のMapデータを作成する（本来おくべき数）
    private int[,]  baseMap = null;
    private int[,] inputMap = null;
    
    private void MakeBaseMap(int n)
    {
        for (int i = 0; i < this._n; i++)
        {
            for (int j = 0; j < this._n; j++)
            {
                int x = Math.Abs(this.cntCenter - i);
                int y = Math.Abs(this.cntCenter - j);
                this.baseMap[i, j] = (x > y) ? this.cntCenter - (x - 1) : this.cntCenter - (y - 1);
            }
        }
    }
    private int[] line = null;
    private void MakeInputMap(int n)
    {
        for (int i = 0; i < this._n; i++)
        {
            line = new int[n];
            line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < this._n; j++)
            {
                this.inputMap[i, j] = line[j];
            }
        }
    }
    private int GetMoveOutCount()
    {
        int result = 0;
        for (int i = 0; i < this._n; i++)
        {
            for (int j = 0; j < this._n; j++)
            {
                result += this.inputMap[i, j] - this.baseMap[i, j];
            }
        }
        return result;
    }
}