// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.ISequentialStream
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [InterfaceType(1)]
  [Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
  [ComImport]
  public interface ISequentialStream
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);
  }
}
