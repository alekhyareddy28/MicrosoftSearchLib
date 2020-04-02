// Decompiled with JetBrains decompiler
// Type: SearchAPI.ISearchViewChangedSink
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF65")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ISearchViewChangedSink
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnChange([In] ref int pdwDocID, [In] ref _SEARCH_ITEM_CHANGE pChange, [In] ref int pfInView);
  }
}
