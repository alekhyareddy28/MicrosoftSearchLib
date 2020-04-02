namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid("C188CDBA-53E5-4767-9FFB-FAFBD8017DF0"), ClassInterface((short) 0)]
    public class CEnumSearchRootsClass : IEnumSearchRoots, CEnumSearchRoots
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CEnumSearchRoots Clone();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out CSearchRoot rgelt, [In, Out] ref uint pceltFetched);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Skip([In] uint celt);
    }
}

