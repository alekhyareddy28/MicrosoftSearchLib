// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.tagFUNCDESC
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
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
