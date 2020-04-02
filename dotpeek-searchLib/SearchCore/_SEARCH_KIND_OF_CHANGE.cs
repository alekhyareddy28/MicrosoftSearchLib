// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop._SEARCH_KIND_OF_CHANGE
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

namespace Microsoft.Search.Interop
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
