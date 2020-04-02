// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.CSearchItemsChangedSinkClass
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [ClassInterface((ClassInterfaceType)0)]
  [Guid("A5270F6C-19EC-4E17-9EA1-A7074276B9B9")]
  [ComImport]
  public class CSearchItemsChangedSinkClass : ISearchItemsChangedSink, CSearchItemsChangedSink
  {
    /*[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    internal extern CSearchItemsChangedSinkClass();*/

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StartedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StoppedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OnItemsChanged(
      [In] uint dwNumberOfChanges,
      [In] ref _SEARCH_ITEM_CHANGE rgDataChangeEntries,
      out uint rgdwDocIds,
      [MarshalAs(UnmanagedType.Error)] out int rghrCompletionCodes);
  }
}
