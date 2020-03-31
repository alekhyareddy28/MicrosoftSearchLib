﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.ISearchCrawlScopeManager
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF55")]
  [InterfaceType(1)]
  [ComImport]
  public interface ISearchCrawlScopeManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddDefaultScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl, [In] int fInclude, [In] uint fFollowFlags);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddRoot([MarshalAs(UnmanagedType.Interface), In] CSearchRoot pSearchRoot);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveRoot([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    CEnumSearchRoots EnumerateRoots();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddHierarchicalScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl, [In] int fInclude, [In] int fDefault, [In] int fOverrideChildren);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddUserScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl, [In] int fInclude, [In] int fOverrideChildren, [In] uint fFollowFlags);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszRule);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    CEnumSearchScopeRules EnumerateScopeRules();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int HasParentScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int HasChildScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int IncludedInCrawlScope([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void IncludedInCrawlScopeEx([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl, out int pfIsIncluded, [ComAliasName("Microsoft.Search.Interop.CLUSION_REASON")] out CLUSION_REASON pReason);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RevertToDefaultScopes();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SaveAll();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int GetParentScopeVersionId([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveDefaultScopeRule([MarshalAs(UnmanagedType.LPWStr), In] string pszUrl);
  }
}
