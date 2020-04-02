// Decompiled with JetBrains decompiler
// Type: SearchAPI.CSearchScopeRuleClass
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SearchAPI
{
  [ClassInterface(ClassInterfaceType.None)]
  [Guid("E63DE750-3BD7-4BE5-9C84-6B4281988C44")]
  [TypeLibType(TypeLibTypeFlags.FCanCreate)]
  [ComImport]
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
