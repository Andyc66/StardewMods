﻿namespace Common.Integrations.ProducerFrameworkMod;

using StardewModdingAPI;

/// <inheritdoc />
internal class ProducerFrameworkModIntegration : ModIntegration<IProducerFrameworkModApi>
{
    private const string ModUniqueId = "Digus.ProducerFrameworkMod";

    /// <summary>
    ///     Initializes a new instance of the <see cref="ProducerFrameworkModIntegration" /> class.
    /// </summary>
    /// <param name="modRegistry">SMAPI's mod registry.</param>
    public ProducerFrameworkModIntegration(IModRegistry modRegistry)
        : base(modRegistry, ProducerFrameworkModIntegration.ModUniqueId)
    {
    }
}