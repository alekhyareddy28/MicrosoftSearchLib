﻿namespace Microsoft.Search.Interop
{
    using System;

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
        CATALOG_PAUSED_REASON_UPGRADING
    }
}

