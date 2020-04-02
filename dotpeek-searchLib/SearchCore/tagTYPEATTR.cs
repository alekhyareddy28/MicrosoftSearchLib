// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.tagTYPEATTR
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
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
