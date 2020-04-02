// Decompiled with JetBrains decompiler
// Type: SearchAPI.FilterRegistrationClass
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [TypeLibType(TypeLibTypeFlags.FCanCreate)]
  [ComConversionLoss]
  [Guid("9E175B8D-F52A-11D8-B9A5-505054503030")]
  [ClassInterface(ClassInterfaceType.None)]
  [ComImport]
  public class FilterRegistrationClass : ILoadFilter, FilterRegistration, ILoadFilterWithPrivateComActivation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern FilterRegistrationClass();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LoadIFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsPath,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LoadIFilterFromStorage(
      [MarshalAs(UnmanagedType.Interface), In] IStorage pStg,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsOverride,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LoadIFilterFromStream(
      [MarshalAs(UnmanagedType.Interface), In] IStream pstm,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ILoadFilterWithPrivateComActivation_LoadIFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsPath,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ILoadFilterWithPrivateComActivation_LoadIFilterFromStorage(
      [MarshalAs(UnmanagedType.Interface), In] IStorage pStg,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsOverride,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void ILoadFilterWithPrivateComActivation_LoadIFilterFromStream(
      [MarshalAs(UnmanagedType.Interface), In] IStream pstm,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void LoadIFilterWithPrivateComActivation(
      [In] ref _FILTERED_DATA_SOURCES filteredSources,
      [In] int useDefault,
      out Guid filterClsid,
      out int isFilterPrivateComActivated,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter filterObj);
  }
}
