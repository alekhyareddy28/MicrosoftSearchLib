// Decompiled with JetBrains decompiler
// Type: SearchAPI._CatalogStatus
// Assembly: SearchAPI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1110C9F-F722-4F50-BC4B-2730E6C67441
// Assembly location: F:\Microsoft.Search DLL\generateDLL\SearchAPI.dll

namespace SearchAPI
{
  public enum _CatalogStatus
  {
    CATALOG_STATUS_IDLE,
    CATALOG_STATUS_PAUSED,
    CATALOG_STATUS_RECOVERING,
    CATALOG_STATUS_FULL_CRAWL,
    CATALOG_STATUS_INCREMENTAL_CRAWL,
    CATALOG_STATUS_PROCESSING_NOTIFICATIONS,
    CATALOG_STATUS_SHUTTING_DOWN,
  }
}
