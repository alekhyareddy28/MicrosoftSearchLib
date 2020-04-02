﻿// Decompiled with JetBrains decompiler
// Type: SearchAPI.ISearchCatalogManager
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF50")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComConversionLoss]
  [ComImport]
  public interface ISearchCatalogManager
  {
    [DispId(1610678272)]
    string Name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    IntPtr GetParameter([MarshalAs(UnmanagedType.LPWStr), In] string pszName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetParameter([MarshalAs(UnmanagedType.LPWStr), In] string pszName, [In] ref tag_inner_PROPVARIANT pValue);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetCatalogStatus(out _CatalogStatus pStatus, out _CatalogPausedReason pPausedReason);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Reset();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Reindex();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ReindexMatchingURLs([MarshalAs(UnmanagedType.LPWStr), In] string pszPattern);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ReindexSearchRoot([MarshalAs(UnmanagedType.LPWStr), In] string pszRootURL);

    [DispId(1610678280)]
    uint ConnectTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678282)]
    uint DataTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int NumberOfItems();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void NumberOfItemsToIndex(
      out int plIncrementalCount,
      out int plNotificationQueue,
      out int plHighPriorityQueue);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string URLBeingIndexed();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    uint GetURLIndexingState([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ISearchPersistentItemsChangedSink GetPersistentItemsChangedSink();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RegisterViewForNotification(
      [MarshalAs(UnmanagedType.LPWStr), In] string pszView,
      [MarshalAs(UnmanagedType.Interface), In] ISearchViewChangedSink pViewChangedSink,
      out uint pdwCookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetItemsChangedSink(
      [MarshalAs(UnmanagedType.Interface), In] ISearchNotifyInlineSite pISearchNotifyInlineSite,
      [In] ref Guid riid,
      out IntPtr ppv,
      out Guid pGUIDCatalogResetSignature,
      out Guid pGUIDCheckPointSignature,
      out uint pdwLastCheckPointNumber);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void UnregisterViewForNotification([In] uint dwCookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetExtensionClusion([MarshalAs(UnmanagedType.LPWStr), In] string pszExtension, [In] int fExclude);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    IEnumString EnumerateExcludedExtensions();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ISearchQueryHelper GetQueryHelper();

    [DispId(1610678295)]
    int DiacriticSensitivity { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ISearchCrawlScopeManager GetCrawlScopeManager();
  }
}
