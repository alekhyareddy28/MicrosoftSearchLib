// Decompiled with JetBrains decompiler
// Type: SearchAPI.tagTYPEATTR
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct tagTYPEATTR
  {
    public Guid guid;
    public uint lcid;
    public uint dwReserved;
    public int memidConstructor;
    public int memidDestructor;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string lpstrSchema;
    public uint cbSizeInstance;
    public tagTYPEKIND typekind;
    public ushort cFuncs;
    public ushort cVars;
    public ushort cImplTypes;
    public ushort cbSizeVft;
    public ushort cbAlignment;
    public ushort wTypeFlags;
    public ushort wMajorVerNum;
    public ushort wMinorVerNum;
    public tagTYPEDESC tdescAlias;
    public tagIDLDESC idldescType;
  }
}
