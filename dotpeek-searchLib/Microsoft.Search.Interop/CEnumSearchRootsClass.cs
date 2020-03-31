// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.CEnumSearchRootsClass
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("C188CDBA-53E5-4767-9FFB-FAFBD8017DF0")]
  [ClassInterface(0)]
  [ComImport]
  public class CEnumSearchRootsClass : IEnumSearchRoots, CEnumSearchRoots
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    internal extern CEnumSearchRootsClass();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out CSearchRoot rgelt, [In, Out] ref uint pceltFetched);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Skip([In] uint celt);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public virtual extern void Reset();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    public virtual extern CEnumSearchRoots Clone();
  }
}
