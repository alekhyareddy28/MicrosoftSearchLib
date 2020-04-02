// Decompiled with JetBrains decompiler
// Type: SearchAPI.ISearchNotifyInlineSite
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [Guid("B5702E61-E75C-4B64-82A1-6CB4F832FCCF")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ISearchNotifyInlineSite
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnItemIndexedStatusChange(
      [In] _SEARCH_INDEXING_PHASE sipStatus,
      [In] uint dwNumEntries,
      [In] ref _SEARCH_ITEM_INDEXING_STATUS rgItemStatusEntries);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void OnCatalogStatusChange(
      [In] ref Guid guidCatalogResetSignature,
      [In] ref Guid guidCheckPointSignature,
      [In] uint dwLastCheckPointNumber);
  }
}
