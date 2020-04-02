// Decompiled with JetBrains decompiler
// Type: SearchAPI._FILTERED_DATA_SOURCES
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [ComConversionLoss]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _FILTERED_DATA_SOURCES
  {
    [ComConversionLoss]
    public IntPtr pwcsExtension;
    [ComConversionLoss]
    public IntPtr pwcsMime;
    [ComConversionLoss]
    public IntPtr pClsid;
    [ComConversionLoss]
    public IntPtr pwcsOverride;
  }
}
