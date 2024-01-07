using System;

namespace Spirzza.Interop.SpirvCross;

public readonly partial struct spvc_variable_id : IComparable, IComparable<spvc_variable_id>, IEquatable<spvc_variable_id>, IFormattable
{
    public readonly uint Value;

    public spvc_variable_id(uint value)
    {
        Value = value;
    }

    public static bool operator ==(spvc_variable_id left, spvc_variable_id right) => left.Value == right.Value;

    public static bool operator !=(spvc_variable_id left, spvc_variable_id right) => left.Value != right.Value;

    public static bool operator <(spvc_variable_id left, spvc_variable_id right) => left.Value < right.Value;

    public static bool operator <=(spvc_variable_id left, spvc_variable_id right) => left.Value <= right.Value;

    public static bool operator >(spvc_variable_id left, spvc_variable_id right) => left.Value > right.Value;

    public static bool operator >=(spvc_variable_id left, spvc_variable_id right) => left.Value >= right.Value;

    public static implicit operator spvc_variable_id(byte value) => new spvc_variable_id(value);

    public static explicit operator byte(spvc_variable_id value) => (byte)(value.Value);

    public static explicit operator spvc_variable_id(short value) => new spvc_variable_id(unchecked((uint)(value)));

    public static explicit operator short(spvc_variable_id value) => (short)(value.Value);

    public static explicit operator spvc_variable_id(int value) => new spvc_variable_id(unchecked((uint)(value)));

    public static explicit operator int(spvc_variable_id value) => (int)(value.Value);

    public static explicit operator spvc_variable_id(long value) => new spvc_variable_id(unchecked((uint)(value)));

    public static implicit operator long(spvc_variable_id value) => value.Value;

    public static explicit operator spvc_variable_id(nint value) => new spvc_variable_id(unchecked((uint)(value)));

    public static explicit operator nint(spvc_variable_id value) => (nint)(value.Value);

    public static explicit operator spvc_variable_id(sbyte value) => new spvc_variable_id(unchecked((uint)(value)));

    public static explicit operator sbyte(spvc_variable_id value) => (sbyte)(value.Value);

    public static implicit operator spvc_variable_id(ushort value) => new spvc_variable_id(value);

    public static explicit operator ushort(spvc_variable_id value) => (ushort)(value.Value);

    public static implicit operator spvc_variable_id(uint value) => new spvc_variable_id(value);

    public static implicit operator uint(spvc_variable_id value) => value.Value;

    public static explicit operator spvc_variable_id(ulong value) => new spvc_variable_id(unchecked((uint)(value)));

    public static implicit operator ulong(spvc_variable_id value) => value.Value;

    public static explicit operator spvc_variable_id(nuint value) => new spvc_variable_id(unchecked((uint)(value)));

    public static implicit operator nuint(spvc_variable_id value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is spvc_variable_id other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of spvc_variable_id.");
    }

    public int CompareTo(spvc_variable_id other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is spvc_variable_id other) && Equals(other);

    public bool Equals(spvc_variable_id other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
