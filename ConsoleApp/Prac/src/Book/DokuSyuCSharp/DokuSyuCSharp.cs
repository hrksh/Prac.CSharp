namespace Prac.DokuSyuCSharp;
using Resources;
using Book;

public class DokuSyuCSharp : BookBase
{
    public override string      Name => Strings_ja.TextDokusyuCSharp;
    public override string    Author => Strings_ja.AutherYamadaYoshihiro;
    public override string Publisher => Strings_ja.Shoeisha;
    public override BookType Type => BookType.Technical;
}