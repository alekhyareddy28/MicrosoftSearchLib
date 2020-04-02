namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [Guid("7D096C5F-AC08-4F1F-BEB7-5C22C517CE39"), TypeLibType((short) 2), ClassInterface((short) 0), ComConversionLoss]
    public class CSearchManagerClass : ISearchManager, CSearchManager
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CSearchCatalogManager GetCatalog([In, MarshalAs(UnmanagedType.LPWStr)] string pszCatalog);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetIndexerVersion(out uint pdwMajor, out uint pdwMinor);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void GetIndexerVersionStr([MarshalAs(UnmanagedType.LPWStr)] out string ppszVersionString);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern IntPtr GetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void SetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName, [In] ref tag_inner_PROPVARIANT pValue);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void SetProxy([In] _PROXY_ACCESS sUseProxy, [In] int fLocalByPassProxy, [In] uint dwPortNumber, [In, MarshalAs(UnmanagedType.LPWStr)] string pszProxyName, [In, MarshalAs(UnmanagedType.LPWStr)] string pszByPassList);

        [DispId(0x60010004)]
        public virtual extern string ProxyName { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010005)]
        public virtual extern string BypassList { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010008)]
        public virtual extern string UserAgent { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        public virtual extern _PROXY_ACCESS UseProxy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x6001000b)]
        public virtual extern int LocalBypass { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x6001000c)]
        public virtual extern uint PortNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

/*        [DispId(0x60010004)]
        extern string Microsoft.Search.Interop.ISearchManager.ProxyName { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010005)]
        extern string Microsoft.Search.Interop.ISearchManager.BypassList { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010008)]
        extern string Microsoft.Search.Interop.ISearchManager.UserAgent { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }

        [DispId(0x6001000a)]
        extern _PROXY_ACCESS Microsoft.Search.Interop.ISearchManager.UseProxy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x6001000b)]
        extern int Microsoft.Search.Interop.ISearchManager.LocalBypass { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x6001000c)]
        extern uint Microsoft.Search.Interop.ISearchManager.PortNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }*/
        //public extern CSearchManagerClass();

    }
}

