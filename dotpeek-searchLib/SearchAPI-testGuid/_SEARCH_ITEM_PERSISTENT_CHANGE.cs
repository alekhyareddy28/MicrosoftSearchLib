// Decompiled with JetBrains decompiler
// Type: SearchAPI._SEARCH_ITEM_PERSISTENT_CHANGE
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

using System.Runtime.InteropServices;

namespace SearchAPI
{
  [StructLayout(LayoutKind.Sequential, Pack = 4)]
  public struct _SEARCH_ITEM_PERSISTENT_CHANGE
  {
    public _SEARCH_KIND_OF_CHANGE Change;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string URL;
    [MarshalAs(UnmanagedType.LPWStr)]
    public string OldURL;
    public _SEARCH_NOTIFICATION_PRIORITY Priority;
  }
}
