﻿using DSharpPlus.AsyncEvents;
using DSharpPlus.Entities;

namespace DSharpPlus.EventArgs;

/// <summary>
/// Represents arguments for EntitlementDeleted event.
/// </summary>
public class EntitlementDeletedEventArgs : AsyncEventArgs
{
    public DiscordEntitlement Entitlement { get; internal set; }
}
