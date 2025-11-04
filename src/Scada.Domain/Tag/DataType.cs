namespace Scada.Domain.Tag;

/// <summary>
/// Defines the data type of a tag value.
/// </summary>
public enum DataType
{
    /// <summary>
    /// Boolean value (true/false).
    /// </summary>
    Boolean,

    /// <summary>
    /// 8-bit signed integer.
    /// </summary>
    Byte,

    /// <summary>
    /// 16-bit signed integer.
    /// </summary>
    Int16,

    /// <summary>
    /// 32-bit signed integer.
    /// </summary>
    Int32,

    /// <summary>
    /// 64-bit signed integer.
    /// </summary>
    Int64,

    /// <summary>
    /// Single-precision floating point.
    /// </summary>
    Float,

    /// <summary>
    /// Double-precision floating point.
    /// </summary>
    Double,

    /// <summary>
    /// String value.
    /// </summary>
    String
}
