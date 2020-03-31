// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.ISearchNotifyInlineSite
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [InterfaceType(1)]
  [Guid("B5702E61-E75C-4B64-82A1-6CB4F832FCCF")]
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
