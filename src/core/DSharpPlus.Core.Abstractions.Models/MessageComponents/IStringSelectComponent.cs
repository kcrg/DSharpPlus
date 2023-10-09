// This Source Code form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Collections.Generic;

using DSharpPlus.Entities;

namespace DSharpPlus.Core.Abstractions.Models;

/// <summary>
/// Represents a dropdown menu from where users can select dev-supplied strings.
/// </summary>
public interface IStringSelectComponent : IInteractiveComponent
{
    /// <summary>
    /// The type of this component.
    /// </summary>
    public DiscordMessageComponentType Type { get; }

    /// <summary>
    /// The developer-defined ID for this select menu, up to 100 characters.
    /// </summary>
    public string CustomId { get; }

    /// <summary>
    /// Up to 25 specified choices for this select menu.
    /// </summary>
    public IReadOnlyList<ISelectOption> Options { get; }

    /// <summary>
    /// Placeholder text if nothing is selected, up to 150 characters.
    /// </summary>
    public Optional<string> Placeholder { get; }

    /// <summary>
    /// The minimum number of items that must be chosen, between 0 and 25.
    /// </summary>
    public Optional<int> MinValues { get; }

    /// <summary>
    /// The maximum number of items that can be chosen, between 1 and 25.
    /// </summary>
    public Optional<int> MaxValues { get; }

    /// <summary>
    /// Indicates whether this select menu is disabled.
    /// </summary>
    public Optional<bool> Disabled { get; }
}
