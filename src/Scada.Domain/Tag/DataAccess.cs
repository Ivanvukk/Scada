namespace Scada.Domain.Tag;

/// <summary>
/// Defines the access mode for a tag.
/// </summary>
public enum DataAccess
{
  /// <summary>
  /// Tag can only be read from.
  /// </summary>
  ReadOnly,

  /// <summary>
  /// Tag can only be written to.
  /// </summary>
  WriteOnly,

  /// <summary>
  /// Tag supports both read and write operations.
  /// </summary>
  ReadWrite
}