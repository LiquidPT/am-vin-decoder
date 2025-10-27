// -------------------------------------------------------------------------------------------------
// Copyright (c) Matt Fraser. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace AmVinDecoderLib.VinComponents.Enums;

/// <summary>
/// Specifies the available model types for vehicles, including various coupe, roadster, and special edition variants.
/// </summary>
/// <remarks>Use this enumeration to identify or categorize vehicle models in applications that require
/// distinction between different types, such as inventory management, configuration, or reporting. The values represent
/// specific models and body styles, including both legacy and current options. The Unknown value indicates that the
/// model type has not been specified.</remarks>
public enum ModelType
{
    /// <summary>
    /// Default value. The value has not been set.
    /// </summary>
    Unknown,

    /// <summary>
    /// DB9 Coupe
    /// </summary>
    Db9Coupe,

    /// <summary>
    /// DB9 Volante
    /// </summary>
    Db9Volante,

    /// <summary>
    /// V8/V8S Coupe
    /// </summary>
    V8VantageCoupe,

    /// <summary>
    /// V8/V8S Roadster
    /// </summary>
    V8VantageRoadster,

    /// <summary>
    /// DBS
    /// </summary>
    Dbs,

    /// <summary>
    /// DBS Coupe
    /// </summary>
    DbsCoupe,

    /// <summary>
    /// DBS Volante
    /// </summary>
    DbsVolante,

    /// <summary>
    /// Rapide
    /// </summary>
    Rapide,

    /// <summary>
    /// Virage Coupe
    /// </summary>
    VirageCoupe,

    /// <summary>
    /// Virage Volante
    /// </summary>
    VirageVolante,

    /// <summary>
    /// Vanquish Coupe
    /// </summary>
    VanquishCoupe,

    /// <summary>
    /// Vanquish Volante
    /// </summary>
    VanquishVolante,

    /// <summary>
    /// Vanquish Zagato Coupe
    /// </summary>
    VanquishZagatoCoupe,

    /// <summary>
    /// Vanquish Zagato Volante
    /// </summary>
    VanquishZagatoVolante,

    /// <summary>
    /// DB11 Coupe
    /// </summary>
    Db11Coupe,

    /// <summary>
    /// DB11 Volante
    /// </summary>
    Db11Volante,

    /// <summary>
    /// DB11 AMR
    /// </summary>
    Db11Amr,

    /// <summary>
    /// New Vantage Coupe
    /// </summary>
    NewVantageCoupe,

    /// <summary>
    /// New DBS Coupe
    /// </summary>
    NewDbsCoupe,

    /// <summary>
    /// New DBS Volante
    /// </summary>
    NewDbsVolante,

    /// <summary>
    /// V12 Vantage Coupe
    /// </summary>
    V12VantageCoupe,

    /// <summary>
    /// V12 Vantage Roadster
    /// </summary>
    V12VantageRoadster,

    /// <summary>
    /// V12 Vantage S Coupe
    /// </summary>
    V12VantageSCoupe,

    /// <summary>
    /// V12 Vantage S Roadster
    /// </summary>
    V12VantageSRoadster,

    /// <summary>
    /// Cygnet
    /// </summary>
    Cygnet,

    /// <summary>
    /// DBX
    /// </summary>
    Dbx,
}
