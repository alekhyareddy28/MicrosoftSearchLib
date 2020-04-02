﻿// Decompiled with JetBrains decompiler
// Type: SearchAPI.ISearchItemsChangedSink
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF58")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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