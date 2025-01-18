using Prac.Book;

namespace Prac.DokuSyuCSharp;

/// <summary>
/// 基本関連 (Chapter 2)
/// </summary>
public class Basics
{
    /// <summary>
    /// 変数 P34
    /// </summary>
    private class Variable
    {
        // 初期値を必ず設定する。書けてしまうがそれはNG, 初期化忘れを防止したい為。
        // 最近のIDEは勝手に書いてくれるのかもしれない。
        private int number = 0;
        
        // @逐語的識別子 verbatim identifier
        // キーワードと被った時、@を付けることで利用できるが、使うかは別。一般的には避ける・・・
        private int @private = 999; // マ？
    }

    /// <summary>
    /// 定数　P39
    /// 後から変更しない・したくない変数
    /// </summary>
    private class Constant
    {
        // 使えば分かるけど、初期値が必須。数値, bool, string, enum, null のみ
        // 定数はパスカル記法が推奨されるらしい。
        private const int number = 0;
        private const double TaxRate = 1.08;
        private const long num = 0;
        private const decimal @private = 999;
        private const bool flag = false;
        private const BookType hoge = BookType.Novel;
        // null ?? をどうやって定義？　初期値の話？
        
        /*
          税率とか、主に共通で使う変動しない値に使うことで、メンテナンス性を意識した実装ができる。
          リソース定義との目的の違いは主に型 (数値 <=> 文字列)
          リソースはテキストオンリーだが、定数は文字列の他、数値、計算値で保持できる。
          リソースは多言語対応等が魅力だが定数は不可能
          リソースは後からの変更やプログラム外からの変更を受け付けることが可能だが、
          固定値はそれはさせないように作られている。
        */
    }
    
    // 感想：型を強制できるのが強みらしいが、じゃあvarをなんで追加したんだ・・・
}