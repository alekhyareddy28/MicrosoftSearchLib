// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.CSearchPersistentItemsChangedSinkClass
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("D0F268B5-EA7A-4B35-BF2F-E1A091B80D51")]
  [ClassInterface((ClassInterfaceType)0)]

  public class CSearchPersistentItemsChangedSinkClass : ISearchPersistentItemsChangedSink, CSearchPersistentItemsChangedSink
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    internal extern CSearchPersistentItemsChangedSinkClass();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StartedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void StoppedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void OnItemsChanged(
      [In] uint dwNumberOfChanges,
      [In] ref _SEARCH_ITEM_PERSISTENT_CHANGE DataChangeEntries,
      [MarshalAs(UnmanagedType.Error)] out int hrCompletionCodes);
  }
}
