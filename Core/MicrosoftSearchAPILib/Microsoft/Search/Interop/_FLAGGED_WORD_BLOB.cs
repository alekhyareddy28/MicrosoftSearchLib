﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4), ComConversionLoss]
    public struct _FLAGGED_WORD_BLOB
    {
        public uint fFlags;
        public uint clSize;
        [ComConversionLoss]
        public IntPtr asData;
    }
}

