// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.ITypeComp
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

namespace Microsoft.Search.Interop
{
  [ComConversionLoss]
  [InterfaceType(1)]
  [Guid("00020403-0000-0000-C000-000000000046")]
  [ComImport]
  public interface ITypeComp
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoteBind(
      [MarshalAs(UnmanagedType.LPWStr), In] string szName,
      [In] uint lHashVal,
      [In] ushort wFlags,
      [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (TypeToTypeInfoMarshaler))] out Type ppTInfo,
      out tagDESCKIND pDescKind,
      [Out] IntPtr ppFuncDesc,
      [Out] IntPtr ppVarDesc,
      [MarshalAs(UnmanagedType.Interface)] out ITypeComp ppTypeComp,
      [ComAliasName("Microsoft.Search.Interop.DWORD")] out uint pDummy);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoteBindType([MarshalAs(UnmanagedType.LPWStr), In] string szName, [In] uint lHashVal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (TypeToTypeInfoMarshaler))] out Type ppTInfo);
  }
}
