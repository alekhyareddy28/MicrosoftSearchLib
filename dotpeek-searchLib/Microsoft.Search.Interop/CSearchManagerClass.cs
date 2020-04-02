﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.CSearchManagerClass
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("7D096C5F-AC08-4F1F-BEB7-5C22C517CE39")]
  [TypeLibType(2)]
  [ClassInterface((ClassInterfaceType)0)]
  [ComConversionLoss]
  public class CSearchManagerClass : ISearchManager, CSearchManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern CSearchManagerClass();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetIndexerVersionStr([MarshalAs(UnmanagedType.LPWStr)] out string ppszVersionString);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void GetIndexerVersion(out uint pdwMajor, out uint pdwMinor);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern IntPtr GetParameter([MarshalAs(UnmanagedType.LPWStr), In] string pszName);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetParameter([MarshalAs(UnmanagedType.LPWStr), In] string pszName, [In] ref tag_inner_PROPVARIANT pValue);

    [DispId(1610678276)]
    public virtual extern string ProxyName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678277)]
    public virtual extern string BypassList { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void SetProxy(
      [In] _PROXY_ACCESS sUseProxy,
      [In] int fLocalByPassProxy,
      [In] uint dwPortNumber,
      [MarshalAs(UnmanagedType.LPWStr), In] string pszProxyName,
      [MarshalAs(UnmanagedType.LPWStr), In] string pszByPassList);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    public virtual extern CSearchCatalogManager GetCatalog([MarshalAs(UnmanagedType.LPWStr), In] string pszCatalog);

    [DispId(1610678280)]
    public virtual extern string UserAgent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.LPWStr), In] set; }

    [DispId(1610678282)]
    public virtual extern _PROXY_ACCESS UseProxy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678283)]
    public virtual extern int LocalBypass { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678284)]
    public virtual extern uint PortNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
