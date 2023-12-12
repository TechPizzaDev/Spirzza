using System;

namespace Spirzza.Interop.SpirvCross
{
    public readonly partial struct spvc_bool : IComparable, IComparable<spvc_bool>, IEquatable<spvc_bool>, IFormattable
    {
        public readonly byte Value;

        public spvc_bool(byte value)
        {
            Value = value;
        }

        public static bool operator ==(spvc_bool left, spvc_bool right) => left.Value == right.Value;

        public static bool operator !=(spvc_bool left, spvc_bool right) => left.Value != right.Value;

        public static bool operator <(spvc_bool left, spvc_bool right) => left.Value < right.Value;

        public static bool operator <=(spvc_bool left, spvc_bool right) => left.Value <= right.Value;

        public static bool operator >(spvc_bool left, spvc_bool right) => left.Value > right.Value;

        public static bool operator >=(spvc_bool left, spvc_bool right) => left.Value >= right.Value;

        public static implicit operator spvc_bool(byte value) => new spvc_bool(value);

        public static implicit operator byte(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(short value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator short(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(int value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator int(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(long value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator long(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(nint value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator nint(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(sbyte value) => new spvc_bool(unchecked((byte)(value)));

        public static explicit operator sbyte(spvc_bool value) => (sbyte)(value.Value);

        public static explicit operator spvc_bool(ushort value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator ushort(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(uint value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator uint(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(ulong value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator ulong(spvc_bool value) => value.Value;

        public static explicit operator spvc_bool(nuint value) => new spvc_bool(unchecked((byte)(value)));

        public static implicit operator nuint(spvc_bool value) => value.Value;

        public int CompareTo(object? obj)
        {
                if (obj is spvc_bool other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of spvc_bool.");
        }

        public int CompareTo(spvc_bool other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is spvc_bool other) && Equals(other);

        public bool Equals(spvc_bool other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
