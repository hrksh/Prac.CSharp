namespace Prac.Common;

// シングルトンを強制させたい

// where T : SingletonBase<T>
// ジェネリック型　T に対して条件

public abstract class AbstSingletonBase<T> where T : class, new()
{
    
}