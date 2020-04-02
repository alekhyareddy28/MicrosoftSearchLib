// Decompiled with JetBrains decompiler
// Type: SearchAPI.IRecordInfo
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

namespace SearchAPI
{
  [Guid("0000002F-0000-0000-C000-000000000046")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
