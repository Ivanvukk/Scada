namespace Scada.Domain.Tag;

/// <summary>
/// Defines the quality of a tag value (based on OPC UA standard).
/// </summary>
public enum Quality
{
    /// <summary>
    /// Good quality - value is reliable.
    /// </summary>
    Good,

    /// <summary>
    /// Bad quality - value is not reliable or device is not communicating.
    /// </summary>
    Bad,

    /// <summary>
    /// Uncertain quality - value may not be accurate.
    /// </summary>
    Uncertain
}
