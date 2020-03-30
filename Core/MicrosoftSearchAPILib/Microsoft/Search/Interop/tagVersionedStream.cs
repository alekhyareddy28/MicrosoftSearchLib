﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct tagVersionedStream
    {
        public Guid guidVersion;
        [MarshalAs(UnmanagedType.Interface)]
        public IStream pStream;
    }
}

