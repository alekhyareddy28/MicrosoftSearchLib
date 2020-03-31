namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("0000002F-0000-0000-C000-000000000046"), InterfaceType((short) 1)]
    public interface IRecordInfo
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RecordInit([Out] IntPtr pvNew);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RecordClear([In] IntPtr pvExisting);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RecordCopy([In] IntPtr pvExisting, [Out] IntPtr pvNew);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetGuid(out Guid pguid);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetName([MarshalAs(UnmanagedType.BStr)] out string pbstrName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetSize(out uint pcbSize);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetField([In] IntPtr pvData, [In, MarshalAs(UnmanagedType.LPWStr)] string szFieldName, [MarshalAs(UnmanagedType.Struct)] out object pvarField);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetFieldNoCopy([In] IntPtr pvData, [In, MarshalAs(UnmanagedType.LPWStr)] string szFieldName, [MarshalAs(UnmanagedType.Struct)] out object pvarField, out IntPtr ppvDataCArray);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void PutField([In] uint wFlags, [In, Out] IntPtr pvData, [In, MarshalAs(UnmanagedType.LPWStr)] string szFieldName, [In, MarshalAs(UnmanagedType.Struct)] ref object pvarField);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void PutFieldNoCopy([In] uint wFlags, [In, Out] IntPtr pvData, [In, MarshalAs(UnmanagedType.LPWStr)] string szFieldName, [In, MarshalAs(UnmanagedType.Struct)] ref object pvarField);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetFieldNames([In, Out] ref uint pcNames, [MarshalAs(UnmanagedType.BStr)] out string rgBstrNames);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        int IsMatchingType([In, MarshalAs(UnmanagedType.Interface)] IRecordInfo pRecordInfo);
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        IntPtr RecordCreate();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RecordCreateCopy([In] IntPtr pvSource, out IntPtr ppvDest);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RecordDestroy([In] IntPtr pvRecord);
    }
}

