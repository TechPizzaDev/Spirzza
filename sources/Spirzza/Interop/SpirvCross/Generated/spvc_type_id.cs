using System;

namespace Spirzza.Interop.SpirvCross;

public readonly partial struct spvc_type_id : IComparable, IComparable<spvc_type_id>, IEquatable<spvc_type_id>, IFormattable
{
    public readonly uint Value;

    public spvc_type_id(uint value)
    {
        Value = value;
    }

    public static bool operator ==(spvc_type_id left, spvc_type_id right) => left.Value == right.Value;

    public static bool operator !=(spvc_type_id left, spvc_type_id right) => left.Value != right.Value;

    public static bool operator <(spvc_type_id left, spvc_type_id right) => left.Value < right.Value;

    public static bool operator <=(spvc_type_id left, spvc_type_id right) => left.Value <= right.Value;

    public static bool operator >(spvc_type_id left, spvc_type_id right) => left.Value > right.Value;

    public static bool operator >=(spvc_type_id left, spvc_type_id right) => left.Value >= right.Value;

    public static implicit operator spvc_type_id(byte value) => new spvc_type_id(value);

    public static explicit operator byte(spvc_type_id value) => (byte)(value.Value);

    public static explicit operator spvc_type_id(short value) => new spvc_type_id(unchecked((uint)(value)));

    public static explicit operator short(spvc_type_id value) => (short)(value.Value);

    public static explicit operator spvc_type_id(int value) => new spvc_type_id(unchecked((uint)(value)));

    public static explicit operator int(spvc_type_id value) => (int)(value.Value);

    public static explicit operator spvc_type_id(long value) => new spvc_type_id(unchecked((uint)(value)));

    public static implicit operator long(spvc_type_id value) => value.Value;

    public static explicit operator spvc_type_id(nint value) => new spvc_type_id(unchecked((uint)(value)));

    public static explicit operator nint(spvc_type_id value) => (nint)(value.Value);

    public static explicit operator spvc_type_id(sbyte value) => new spvc_type_id(unchecked((uint)(value)));

    public static explicit operator sbyte(spvc_type_id value) => (sbyte)(value.Value);

    public static implicit operator spvc_type_id(ushort value) => new spvc_type_id(value);

    public static explicit operator ushort(spvc_type_id value) => (ushort)(value.Value);

    public static implicit operator spvc_type_id(uint value) => new spvc_type_id(value);

    public static implicit operator uint(spvc_type_id value) => value.Value;

    public static explicit operator spvc_type_id(ulong value) => new spvc_type_id(unchecked((uint)(value)));

    public static implicit operator ulong(spvc_type_id value) => value.Value;

    public static explicit operator spvc_type_id(nuint value) => new spvc_type_id(unchecked((uint)(value)));

    public static implicit operator nuint(spvc_type_id value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is spvc_type_id other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of spvc_type_id.");
    }

    public int CompareTo(spvc_type_id other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is spvc_type_id other) && Equals(other);

    public bool Equals(spvc_type_id other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
