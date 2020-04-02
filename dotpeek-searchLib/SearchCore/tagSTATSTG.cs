// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.tagSTATSTG
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  public struct tagSTATSTG
  {
    [MarshalAs(UnmanagedType.LPWStr)]
    public string pwcsName;
    public uint type;
    public _ULARGE_INTEGER cbSize;
    public _FILETIME mtime;
    public _FILETIME ctime;
    public _FILETIME atime;
    public uint grfMode;
    public uint grfLocksSupported;
    public Guid clsid;
    public uint grfStateBits;
    public uint reserved;
  }
}
