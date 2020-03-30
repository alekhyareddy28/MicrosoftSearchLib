﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ComConversionLoss, Guid("AAB49DD5-AD0B-40AE-B654-AE8976BF6BD2"), ClassInterface((short) 0)]
    public class CSearchCatalogManagerClass : ISearchCatalogManager, CSearchCatalogManager
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern IEnumString EnumerateExcludedExtensions();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetCatalogStatus(out _CatalogStatus pStatus, out _CatalogPausedReason pPausedReason);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CSearchCrawlScopeManager GetCrawlScopeManager();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetItemsChangedSink([In, MarshalAs(UnmanagedType.Interface)] ISearchNotifyInlineSite pISearchNotifyInlineSite, [In] ref Guid riid, out IntPtr ppv, out Guid pGUIDCatalogResetSignature, out Guid pGUIDCheckPointSignature, out uint pdwLastCheckPointNumber);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern IntPtr GetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CSearchPersistentItemsChangedSink GetPersistentItemsChangedSink();
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CSearchQueryHelper GetQueryHelper();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern uint GetURLIndexingState([In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern int NumberOfItems();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void NumberOfItemsToIndex(out int plIncrementalCount, out int plNotificationQueue, out int plHighPriorityQueue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void RegisterViewForNotification([In, MarshalAs(UnmanagedType.LPWStr)] string pszView, [In, MarshalAs(UnmanagedType.Interface)] ISearchViewChangedSink pViewChangedSink, out uint pdwCookie);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Reindex();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void ReindexMatchingURLs([In, MarshalAs(UnmanagedType.LPWStr)] string pszPattern);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void ReindexSearchRoot([In, MarshalAs(UnmanagedType.LPWStr)] string pszRootURL);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void SetExtensionClusion([In, MarshalAs(UnmanagedType.LPWStr)] string pszExtension, [In] int fExclude);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void SetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName, [In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void UnregisterViewForNotification([In] uint dwCookie);
        [return: MarshalAs(UnmanagedType.LPWStr)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern string URLBeingIndexed();

        [DispId(0x60010000)]
        public virtual string Name { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010008)]
        public virtual uint ConnectTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        public virtual uint DataTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010017)]
        public virtual int DiacriticSensitivity { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010000)]
        public virtual string Microsoft.Search.Interop.ISearchCatalogManager.Name { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010008)]
        public virtual uint Microsoft.Search.Interop.ISearchCatalogManager.ConnectTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        public virtual uint Microsoft.Search.Interop.ISearchCatalogManager.DataTimeout { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x60010017)]
        public virtual int Microsoft.Search.Interop.ISearchCatalogManager.DiacriticSensitivity { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
    }
}

