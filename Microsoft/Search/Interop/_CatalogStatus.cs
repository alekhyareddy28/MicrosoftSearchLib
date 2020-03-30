﻿namespace Microsoft.Search.Interop
{
    using System;

    public enum _CatalogStatus
    {
        CATALOG_STATUS_IDLE,
        CATALOG_STATUS_PAUSED,
        CATALOG_STATUS_RECOVERING,
        CATALOG_STATUS_FULL_CRAWL,
        CATALOG_STATUS_INCREMENTAL_CRAWL,
        CATALOG_STATUS_PROCESSING_NOTIFICATIONS,
        CATALOG_STATUS_SHUTTING_DOWN
    }
}

