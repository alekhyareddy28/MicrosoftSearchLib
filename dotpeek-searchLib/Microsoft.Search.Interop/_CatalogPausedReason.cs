// Decompiled with JetBrains decompiler
// Type: Microsoft.Search.Interop._CatalogPausedReason
// Assembly: Microsoft.Search.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9f748985a6e9a7cb
// MVID: 2932D116-D57B-4975-999F-BA3D3EA50054
// Assembly location: F:\Microsoft.Search DLL\Microsoft.Search.Interop.dll

namespace Microsoft.Search.Interop
{
  public enum _CatalogPausedReason
  {
    CATALOG_PAUSED_REASON_NONE,
    CATALOG_PAUSED_REASON_HIGH_IO,
    CATALOG_PAUSED_REASON_HIGH_CPU,
    CATALOG_PAUSED_REASON_HIGH_NTF_RATE,
    CATALOG_PAUSED_REASON_LOW_BATTERY,
    CATALOG_PAUSED_REASON_LOW_MEMORY,
    CATALOG_PAUSED_REASON_LOW_DISK,
    CATALOG_PAUSED_REASON_DELAYED_RECOVERY,
    CATALOG_PAUSED_REASON_USER_ACTIVE,
    CATALOG_PAUSED_REASON_EXTERNAL,
    CATALOG_PAUSED_REASON_UPGRADING,
  }
}
