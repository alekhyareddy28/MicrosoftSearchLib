// Decompiled with JetBrains decompiler
// Type: SearchAPI.ILoadFilterWithPrivateComActivation
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("40BDBD34-780B-48D3-9BB6-12EBD4AD2E75")]
  [ComImport]
  public interface ILoadFilterWithPrivateComActivation : ILoadFilter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LoadIFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsPath,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LoadIFilterFromStorage(
      [MarshalAs(UnmanagedType.Interface), In] IStorage pStg,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsOverride,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void LoadIFilterFromStream(
      [MarshalAs(UnmanagedType.Interface), In] IStream pstm,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LoadIFilterWithPrivateComActivation(
      [In] ref _FILTERED_DATA_SOURCES filteredSources,
      [In] int useDefault,
      out Guid filterClsid,
      out int isFilterPrivateComActivated,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter filterObj);
  }
}
