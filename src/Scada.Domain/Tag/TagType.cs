namespace Scada.Domain.Tag;

/// <summary>
/// Defines the type of tag in the SCADA system.
/// </summary>
public enum TagType
{
    /// <summary>
    /// Input tag - reads data from a device.
    /// </summary>
    Input,

    /// <summary>
    /// Output tag - writes data to a device.
    /// </summary>
    Output,

    /// <summary>
    /// Calculated tag - value is computed from other tags.
    /// </summary>
    Calculated,

    /// <summary>
    /// Virtual tag - internal system tag not tied to physical I/O.
    /// </summary>
    Virtual
}
