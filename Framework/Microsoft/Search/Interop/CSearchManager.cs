﻿namespace Microsoft.Search.Interop
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(CSearchManagerClass)), Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF69")]
    public interface CSearchManager : ISearchManager
    {
    }
}

