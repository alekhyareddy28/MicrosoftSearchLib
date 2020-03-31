namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ComConversionLoss, Guid("00020402-0000-0000-C000-000000000046"), InterfaceType((short) 1)]
    public interface ITypeLib
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteGetTypeInfoCount(out uint pcTInfo);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetTypeInfoType([In] uint index, out tagTYPEKIND pTKind);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteGetLibAttr([Out] IntPtr ppTLibAttr, [ComAliasName("Microsoft.Search.Interop.DWORD")] out uint pDummy);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetTypeComp([MarshalAs(UnmanagedType.Interface)] out ITypeComp ppTComp);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteGetDocumentation([In] int index, [In] uint refPtrFlags, [MarshalAs(UnmanagedType.BStr)] out string pbstrName, [MarshalAs(UnmanagedType.BStr)] out string pBstrDocString, out uint pdwHelpContext, [MarshalAs(UnmanagedType.BStr)] out string pBstrHelpFile);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteIsName([In, MarshalAs(UnmanagedType.LPWStr)] string szNameBuf, [In] uint lHashVal, out int pfName, [MarshalAs(UnmanagedType.BStr)] out string pBstrLibName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void LocalReleaseTLibAttr();
    }
}

