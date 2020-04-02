// Decompiled with JetBrains decompiler
// Type: SearchAPI.ITypeComp
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.CustomMarshalers;

namespace SearchAPI
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComConversionLoss]
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
      [ComAliasName("SearchAPI.DWORD")] out uint pDummy);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoteBindType([MarshalAs(UnmanagedType.LPWStr), In] string szName, [In] uint lHashVal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (TypeToTypeInfoMarshaler))] out Type ppTInfo);
  }
}
