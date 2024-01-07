using System;

namespace Spirzza.Interop.SpirvCross;

public readonly partial struct spvc_constant_id : IComparable, IComparable<spvc_constant_id>, IEquatable<spvc_constant_id>, IFormattable
{
    public readonly uint Value;

    public spvc_constant_id(uint value)
    {
        Value = value;
    }

    public static bool operator ==(spvc_constant_id left, spvc_constant_id right) => left.Value == right.Value;

    public static bool operator !=(spvc_constant_id left, spvc_constant_id right) => left.Value != right.Value;

    public static bool operator <(spvc_constant_id left, spvc_constant_id right) => left.Value < right.Value;

    public static bool operator <=(spvc_constant_id left, spvc_constant_id right) => left.Value <= right.Value;

    public static bool operator >(spvc_constant_id left, spvc_constant_id right) => left.Value > right.Value;

    public static bool operator >=(spvc_constant_id left, spvc_constant_id right) => left.Value >= right.Value;

    public static implicit operator spvc_constant_id(byte value) => new spvc_constant_id(value);

    public static explicit operator byte(spvc_constant_id value) => (byte)(value.Value);

    public static explicit operator spvc_constant_id(short value) => new spvc_constant_id(unchecked((uint)(value)));

    public static explicit operator short(spvc_constant_id value) => (short)(value.Value);

    public static explicit operator spvc_constant_id(int value) => new spvc_constant_id(unchecked((uint)(value)));

    public static explicit operator int(spvc_constant_id value) => (int)(value.Value);

    public static explicit operator spvc_constant_id(long value) => new spvc_constant_id(unchecked((uint)(value)));

    public static implicit operator long(spvc_constant_id value) => value.Value;

    public static explicit operator spvc_constant_id(nint value) => new spvc_constant_id(unchecked((uint)(value)));

    public static explicit operator nint(spvc_constant_id value) => (nint)(value.Value);

    public static explicit operator spvc_constant_id(sbyte value) => new spvc_constant_id(unchecked((uint)(value)));

    public static explicit operator sbyte(spvc_constant_id value) => (sbyte)(value.Value);

    public static implicit operator spvc_constant_id(ushort value) => new spvc_constant_id(value);

    public static explicit operator ushort(spvc_constant_id value) => (ushort)(value.Value);

    public static implicit operator spvc_constant_id(uint value) => new spvc_constant_id(value);

    public static implicit operator uint(spvc_constant_id value) => value.Value;

    public static explicit operator spvc_constant_id(ulong value) => new spvc_constant_id(unchecked((uint)(value)));

    public static implicit operator ulong(spvc_constant_id value) => value.Value;

    public static explicit operator spvc_constant_id(nuint value) => new spvc_constant_id(unchecked((uint)(value)));

    public static implicit operator nuint(spvc_constant_id value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is spvc_constant_id other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of spvc_constant_id.");
    }

    public int CompareTo(spvc_constant_id other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is spvc_constant_id other) && Equals(other);

    public bool Equals(spvc_constant_id other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
