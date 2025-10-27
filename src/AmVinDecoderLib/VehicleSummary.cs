// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib;

/// <summary>
/// Represents a summary of key information about a vehicle, including its model, year, body type, engine, transmission,
/// and identification details.
/// </summary>
/// <remarks>This record provides a concise set of properties describing a vehicle's essential attributes for
/// identification and classification purposes. It is typically used in scenarios where a high-level overview of a
/// vehicle is required, such as inventory listings, search results, or summary reports. Some properties may be set
/// internally and are not intended to be modified by consumers of the API.</remarks>
public record VehicleSummary
{
    /// <summary>
    /// Gets the type of the message body content.
    /// </summary>
    required public BodyType BodyType { get; init; }

    /// <summary>
    /// Gets the engine instance associated with this object.
    /// </summary>
    /// <remarks>This property is set internally and cannot be modified directly by consumers of the API. Use
    /// this property to access engine-specific functionality or configuration as exposed by the Engine type.</remarks>
    public Engine Engine { get; internal set; }

    /// <summary>
    /// Gets the factory instance used to create objects or services for this component.
    /// </summary>
    public Factory Factory { get; init; }

    /// <summary>
    /// Gets the model associated with this instance.
    /// </summary>
    public Model Model { get; init; }

    /// <summary>
    /// Gets the model year associated with this instance.
    /// </summary>
    public ModelYear ModelYear { get; init; }

    /// <summary>
    /// Gets the restraint system information associated with the vehicle.
    /// </summary>
    public RestraintSystem RestraintSystem { get; internal set; }

    /// <summary>
    /// Gets the transmission information associated with this instance.
    /// </summary>
    public Transmission Transmisson { get; internal set; }

    /// <summary>
    /// Gets the unique serial number assigned to the device or item.
    /// </summary>
    public string SerialNumber { get; init; }

    /// <summary>
    /// Gets the vehicle identification number (VIN) associated with this instance.
    /// </summary>
    public string Vin { get; init; }
}
