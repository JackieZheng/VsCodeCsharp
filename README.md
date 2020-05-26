# VsCodeCsharp

```
    /// <summary>
    /// 从父类到子类转换
    /// </summary>
    /// <typeparam name="TP">父类</typeparam>
    /// <typeparam name="TC">子类</typeparam>
    /// <param name="parent"></param>
    /// <returns></returns>
    public static TC CopyFromParent<TP, TC> (TP parent) where TC : TP, new () where TP : new () {
        if (parent == null) return default (TC);
        var child = new TC ();
        typeof (TP).GetProperties ().Where (p => p.CanRead && p.CanWrite).ToList ()
            .ForEach (p => p.SetValue (child, p.GetValue (parent, null), null));
        return child;
    }

    /// <summary>
    /// 从子类到父类
    /// </summary>
    /// <typeparam name="TP">父类</typeparam>
    /// <typeparam name="TC">子类</typeparam>
    /// <param name="child"></param>
    /// <returns></returns>
    public static TP CopyToParent<TP, TC> (TC child) where TC : TP, new () where TP : new () {
        if (child == null) return default (TP);
        var parent = new TP ();
        typeof (TP).GetProperties ().Where (p => p.CanRead && p.CanWrite).ToList ()
            .ForEach (p => p.SetValue (parent, p.GetValue (child, null), null));
        return parent;
    }
```
