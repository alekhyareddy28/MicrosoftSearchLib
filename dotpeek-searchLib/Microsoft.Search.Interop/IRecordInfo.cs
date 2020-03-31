// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.IRecordInfo
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

namespace Microsoft.Search.Interop
{
  [Guid("0000002F-0000-0000-C000-000000000046")]
  [InterfaceType(1)]
  [ComImport]
  public interface IRecordInfo
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecordInit([Out] IntPtr pvNew);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecordClear([In] IntPtr pvExisting);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecordCopy([In] IntPtr pvExisting, [Out] IntPtr pvNew);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetGuid(out Guid pguid);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetName([MarshalAs(UnmanagedType.BStr)] out string pbstrName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetSize(out uint pcbSize);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetTypeInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (TypeToTypeInfoMarshaler))] out Type ppTypeInfo);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetField([In] IntPtr pvData, [MarshalAs(UnmanagedType.LPWStr), In] string szFieldName, [MarshalAs(UnmanagedType.Struct)] out object pvarField);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetFieldNoCopy(
      [In] IntPtr pvData,
      [MarshalAs(UnmanagedType.LPWStr), In] string szFieldName,
      [MarshalAs(UnmanagedType.Struct)] out object pvarField,
      out IntPtr ppvDataCArray);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PutField([In] uint wFlags, [In, Out] IntPtr pvData, [MarshalAs(UnmanagedType.LPWStr), In] string szFieldName, [MarshalAs(UnmanagedType.Struct), In] ref object pvarField);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PutFieldNoCopy([In] uint wFlags, [In, Out] IntPtr pvData, [MarshalAs(UnmanagedType.LPWStr), In] string szFieldName, [MarshalAs(UnmanagedType.Struct), In] ref object pvarField);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetFieldNames([In, Out] ref uint pcNames, [MarshalAs(UnmanagedType.BStr)] out string rgBstrNames);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IsMatchingType([MarshalAs(UnmanagedType.Interface), In] IRecordInfo pRecordInfo);

    [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    IntPtr RecordCreate();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecordCreateCopy([In] IntPtr pvSource, out IntPtr ppvDest);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RecordDestroy([In] IntPtr pvRecord);
  }
}
