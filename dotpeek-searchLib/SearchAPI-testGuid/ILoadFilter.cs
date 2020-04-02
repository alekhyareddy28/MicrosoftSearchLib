// Decompiled with JetBrains decompiler
// Type: SearchAPI.ILoadFilter
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [Guid("C7310722-AC80-11D1-8DF3-00C04FB6EF4F")]
  [ComConversionLoss]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ILoadFilter
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LoadIFilter(
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsPath,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LoadIFilterFromStorage(
      [MarshalAs(UnmanagedType.Interface), In] IStorage pStg,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [MarshalAs(UnmanagedType.LPWStr), In] string pwcsOverride,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void LoadIFilterFromStream(
      [MarshalAs(UnmanagedType.Interface), In] IStream pstm,
      [In] ref _FILTERED_DATA_SOURCES pFilteredSources,
      [MarshalAs(UnmanagedType.IUnknown), In] object pUnkOuter,
      [In] int fUseDefault,
      [In, Out] ref Guid pFilterClsid,
      [In, Out] ref int SearchDecSize,
      [In, Out] IntPtr pwcsSearchDesc,
      [MarshalAs(UnmanagedType.Interface), In, Out] ref IFilter ppIFilt);
  }
}
