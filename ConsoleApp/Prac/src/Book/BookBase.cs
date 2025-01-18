namespace Prac.Book;

/// <summary>
/// 本ベース
/// </summary>
public abstract class BookBase
{
    #region Abstract Members
    public abstract string Name { get; }
    public abstract string Author { get; }
    public abstract string Publisher { get; }
    public abstract BookType Type { get; }
    #endregion
    
    #region Virtual Members
    public virtual string Description { get; } = string.Empty;
    #endregion
}