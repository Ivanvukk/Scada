using Scada.Domain.Data;

namespace Scada.Domain.Tag;

/// <summary>
/// Represents a SCADA tag that monitors or controls a process variable.
/// </summary>
public class Tag : Entity
{
    // Core Identification

    /// <summary>
    /// Unique tag identifier (e.g., "TANK_01_LEVEL").
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Human-readable description of the tag.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Type of tag (Input, Output, Calculated, Virtual).
    /// </summary>
    public TagType TagType { get; set; }

    /// <summary>
    /// Access mode for the tag (ReadOnly, WriteOnly, ReadWrite).
    /// </summary>
    public DataAccess DataAccess { get; set; } = DataAccess.ReadWrite;

    // Data Properties

    /// <summary>
    /// Data type of the tag value.
    /// </summary>
    public DataType DataType { get; set; }

    /// <summary>
    /// Current value of the tag.
    /// </summary>
    public string? CurrentValue { get; set; }

    /// <summary>
    /// Previous value for change detection.
    /// </summary>
    public string? PreviousValue { get; set; }

    /// <summary>
    /// Quality of the current value (Good, Bad, Uncertain).
    /// </summary>
    public Quality Quality { get; set; } = Quality.Bad;

    /// <summary>
    /// Timestamp when the value was last updated.
    /// </summary>
    public DateTime ValueTimestamp { get; set; }

    // Device Association

    /// <summary>
    /// Reference to the device this tag belongs to.
    /// </summary>
    public Guid DeviceId { get; set; }

    /// <summary>
    /// Device address or register (e.g., "40001" for Modbus).
    /// </summary>
    public string Address { get; set; } = string.Empty;

    // Engineering & Scaling

    /// <summary>
    /// Engineering unit of measurement (e.g., "�C", "PSI", "L/min").
    /// </summary>
    public string EngineeringUnit { get; set; } = string.Empty;

    /// <summary>
    /// Minimum raw value from the device.
    /// </summary>
    public double? RawMin { get; set; }

    /// <summary>
    /// Maximum raw value from the device.
    /// </summary>
    public double? RawMax { get; set; }

    /// <summary>
    /// Minimum scaled engineering value.
    /// </summary>
    public double? ScaledMin { get; set; }

    /// <summary>
    /// Maximum scaled engineering value.
    /// </summary>
    public double? ScaledMax { get; set; }

    /// <summary>
    /// Number of decimal places for display precision.
    /// </summary>
    public int DecimalPlaces { get; set; } = 2;

    // Scanning & Performance

    /// <summary>
    /// Poll interval in milliseconds.
    /// </summary>
    public int ScanRate { get; set; } = 1000;

    /// <summary>
    /// Change threshold to trigger an update (prevents noise).
    /// </summary>
    public double Deadband { get; set; } = 0.0;

    /// <summary>
    /// Whether the tag is actively being scanned.
    /// </summary>
    public bool IsEnabled { get; set; } = true;

    // Alarm Integration

    /// <summary>
    /// Whether alarms are enabled for this tag.
    /// </summary>
    public bool AlarmEnabled { get; set; } = false;

    /// <summary>
    /// High alarm threshold limit.
    /// </summary>
    public double? HighAlarmLimit { get; set; }

    /// <summary>
    /// Low alarm threshold limit.
    /// </summary>
    public double? LowAlarmLimit { get; set; }

    public Tag()
    {

    }
}
