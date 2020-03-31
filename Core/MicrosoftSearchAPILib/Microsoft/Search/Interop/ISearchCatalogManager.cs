namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

      [ComImport, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF50"), ComConversionLoss, InterfaceType((short) 1)]
    public interface ISearchCatalogManager
    {
        [DispId(0x60010000)]
        string Name { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        IntPtr GetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void SetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName, [In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetCatalogStatus(out _CatalogStatus pStatus, out _CatalogPausedReason pPausedReason);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void Reindex();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void ReindexMatchingURLs([In, MarshalAs(UnmanagedType.LPWStr)] string pszPattern);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void ReindexSearchRoot([In, MarshalAs(UnmanagedType.LPWStr)] string pszRootURL);
        [DispId(0x60010008)]
        uint ConnectTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x6001000a)]
        uint DataTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int NumberOfItems();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void NumberOfItemsToIndex(out int plIncrementalCount, out int plNotificationQueue, out int plHighPriorityQueue);
        [return: MarshalAs(UnmanagedType.LPWStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        string URLBeingIndexed();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        uint GetURLIndexingState([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CSearchPersistentItemsChangedSink GetPersistentItemsChangedSink();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RegisterViewForNotification([In, MarshalAs(UnmanagedType.LPWStr)] string pszView, [In, MarshalAs(UnmanagedType.Interface)] ISearchViewChangedSink pViewChangedSink, out uint pdwCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetItemsChangedSink([In, MarshalAs(UnmanagedType.Interface)] ISearchNotifyInlineSite pISearchNotifyInlineSite, [In] ref Guid riid, out IntPtr ppv, out Guid pGUIDCatalogResetSignature, out Guid pGUIDCheckPointSignature, out uint pdwLastCheckPointNumber);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void UnregisterViewForNotification([In] uint dwCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void SetExtensionClusion([In, MarshalAs(UnmanagedType.LPWStr)] string pszExtension, [In] int fExclude);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        IEnumString EnumerateExcludedExtensions();
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CSearchQueryHelper GetQueryHelper();
        [DispId(0x60010017)]
        int DiacriticSensitivity { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CSearchCrawlScopeManager GetCrawlScopeManager();
    }
}

