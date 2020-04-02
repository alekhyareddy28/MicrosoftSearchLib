// Decompiled with JetBrains decompiler
// Type: SearchAPI.tagFUNCDESC
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [ComConversionLoss]
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct tagFUNCDESC
  {
    public int memid;
    [ComConversionLoss]
    public IntPtr lprgscode;
    [ComConversionLoss]
    public IntPtr lprgelemdescParam;
    public tagFUNCKIND funckind;
    public tagINVOKEKIND invkind;
    public tagCALLCONV callconv;
    public short cParams;
    public short cParamsOpt;
    public short oVft;
    public short cScodes;
    public tagELEMDESC elemdescFunc;
    public ushort wFuncFlags;
  }
}
