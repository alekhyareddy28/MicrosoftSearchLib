// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop._SEARCH_ITEM_PERSISTENT_CHANGE
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

using System.Runtime.InteropServices;

namespace Microsoft.Search.Interop
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
