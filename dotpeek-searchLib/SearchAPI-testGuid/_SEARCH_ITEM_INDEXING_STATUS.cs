// Decompiled with JetBrains decompiler
// Type: SearchAPI._SEARCH_ITEM_INDEXING_STATUS
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.InteropServices;

namespace SearchAPI
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _SEARCH_ITEM_INDEXING_STATUS
  {
    public uint dwDocID;
    [MarshalAs(UnmanagedType.Error)]
    public int hrIndexingStatus;
  }
}
