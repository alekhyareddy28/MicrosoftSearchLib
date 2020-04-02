// Decompiled with JetBrains decompiler
// Type: SearchAPI.__MIDL_IOleAutomationTypes_0001
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.InteropServices;

namespace SearchAPI
{
  [ComConversionLoss]
  [StructLayout(LayoutKind.Explicit, Size = 24, Pack = 4)]
  public struct __MIDL_IOleAutomationTypes_0001
  {
    [FieldOffset(0)]
    public _BYTE_SIZEDARR ByteStr;
    [FieldOffset(0)]
    public _SHORT_SIZEDARR WordStr;
    [FieldOffset(0)]
    public _LONG_SIZEDARR LongStr;
    [FieldOffset(0)]
    public _HYPER_SIZEDARR HyperStr;
  }
}
