// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop._wireVARIANT
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct _wireVARIANT
  {
    public uint clSize;
    public uint rpcReserved;
    public ushort vt;
    public ushort wReserved1;
    public ushort wReserved2;
    public ushort wReserved3;
    public __MIDL_IOleAutomationTypes_0004 __MIDL__IOleAutomationTypes0002;
  }
}
