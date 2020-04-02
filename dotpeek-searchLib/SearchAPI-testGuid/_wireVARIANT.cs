// Decompiled with JetBrains decompiler
// Type: SearchAPI._wireVARIANT
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.InteropServices;

namespace SearchAPI
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
    public __MIDL_IOleAutomationTypes_0004 DUMMYUNIONNAME;
  }
}
