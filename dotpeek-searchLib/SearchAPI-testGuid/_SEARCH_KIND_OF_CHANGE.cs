// Decompiled with JetBrains decompiler
// Type: SearchAPI._SEARCH_KIND_OF_CHANGE
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

namespace SearchAPI
{
  public enum _SEARCH_KIND_OF_CHANGE
  {
    SEARCH_CHANGE_ADD = 0,
    SEARCH_CHANGE_DELETE = 1,
    SEARCH_CHANGE_MODIFY = 2,
    SEARCH_CHANGE_MOVE_RENAME = 3,
    SEARCH_CHANGE_SEMANTICS_DIRECTORY = 262144, // 0x00040000
    SEARCH_CHANGE_SEMANTICS_SHALLOW = 524288, // 0x00080000
    SEARCH_CHANGE_SEMANTICS_UPDATE_SECURITY = 4194304, // 0x00400000
  }
}
