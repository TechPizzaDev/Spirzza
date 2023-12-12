using System;

namespace Spirzza.Interop.SpirvCross
{
    public readonly partial struct SpvId : IComparable, IComparable<SpvId>, IEquatable<SpvId>, IFormattable
    {
        public readonly uint Value;

        public SpvId(uint value)
        {
            Value = value;
        }

        public static bool operator ==(SpvId left, SpvId right) => left.Value == right.Value;

        public static bool operator !=(SpvId left, SpvId right) => left.Value != right.Value;

        public static bool operator <(SpvId left, SpvId right) => left.Value < right.Value;

        public static bool operator <=(SpvId left, SpvId right) => left.Value <= right.Value;

        public static bool operator >(SpvId left, SpvId right) => left.Value > right.Value;

        public static bool operator >=(SpvId left, SpvId right) => left.Value >= right.Value;

        public static implicit operator SpvId(byte value) => new SpvId(value);

        public static explicit operator byte(SpvId value) => (byte)(value.Value);

        public static explicit operator SpvId(short value) => new SpvId(unchecked((uint)(value)));

        public static explicit operator short(SpvId value) => (short)(value.Value);

        public static explicit operator SpvId(int value) => new SpvId(unchecked((uint)(value)));

        public static explicit operator int(SpvId value) => (int)(value.Value);

        public static explicit operator SpvId(long value) => new SpvId(unchecked((uint)(value)));

        public static implicit operator long(SpvId value) => value.Value;

        public static explicit operator SpvId(nint value) => new SpvId(unchecked((uint)(value)));

        public static explicit operator nint(SpvId value) => (nint)(value.Value);

        public static explicit operator SpvId(sbyte value) => new SpvId(unchecked((uint)(value)));

        public static explicit operator sbyte(SpvId value) => (sbyte)(value.Value);

        public static implicit operator SpvId(ushort value) => new SpvId(value);

        public static explicit operator ushort(SpvId value) => (ushort)(value.Value);

        public static implicit operator SpvId(uint value) => new SpvId(value);

        public static implicit operator uint(SpvId value) => value.Value;

        public static explicit operator SpvId(ulong value) => new SpvId(unchecked((uint)(value)));

        public static implicit operator ulong(SpvId value) => value.Value;

        public static explicit operator SpvId(nuint value) => new SpvId(unchecked((uint)(value)));

        public static implicit operator nuint(SpvId value) => value.Value;

        public int CompareTo(object? obj)
        {
                if (obj is SpvId other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SpvId.");
        }

        public int CompareTo(SpvId other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is SpvId other) && Equals(other);

        public bool Equals(SpvId other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
