// Decompiled with JetBrains decompiler
// Type: SearchAPI.ISearchPersistentItemsChangedSink
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("A2FFDF9B-4758-4F84-B729-DF81A1A0612F")]
  [ComImport]
  public interface ISearchPersistentItemsChangedSink
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StartedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void StoppedMonitoringScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnItemsChanged(
      [In] uint dwNumberOfChanges,
      [In] ref _SEARCH_ITEM_PERSISTENT_CHANGE DataChangeEntries,
      [MarshalAs(UnmanagedType.Error)] out int hrCompletionCodes);
  }
}
