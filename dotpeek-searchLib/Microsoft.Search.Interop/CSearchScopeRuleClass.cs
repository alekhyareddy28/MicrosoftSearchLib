// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop.CSearchScopeRuleClass
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
{
  [Guid("E63DE750-3BD7-4BE5-9C84-6B4281988C44")]
  [ClassInterface((ClassInterfaceType)0)]
  [TypeLibType(2)]
  
  public class CSearchScopeRuleClass : ISearchScopeRule, CSearchScopeRule
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    public extern CSearchScopeRuleClass();

    [DispId(1610678272)]
    public virtual extern string PatternOrURL { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    public virtual extern int IsIncluded { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    public virtual extern int IsDefault { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    public virtual extern uint FollowFlags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
