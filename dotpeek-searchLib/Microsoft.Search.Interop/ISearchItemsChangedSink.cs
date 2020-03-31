// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.ISearchItemsChangedSink
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF58")]
  [InterfaceType(1)]
  [ComImport]
  public interface ISearchItemsChangedSink
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StartedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StoppedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnItemsChanged(
      [In] uint dwNumberOfChanges,
      [In] ref _SEARCH_ITEM_CHANGE rgDataChangeEntries,
      out uint rgdwDocIds,
      [MarshalAs(UnmanagedType.Error)] out int rghrCompletionCodes);
  }
}
