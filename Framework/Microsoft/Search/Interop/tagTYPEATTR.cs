﻿namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
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

