using System;

namespace Spirzza.Interop.Shaderc;

public readonly partial struct shaderc_env_version : IComparable, IComparable<shaderc_env_version>, IEquatable<shaderc_env_version>, IFormattable
{
    public readonly uint Value;

    public shaderc_env_version(uint value)
    {
        Value = value;
    }

    public static bool operator ==(shaderc_env_version left, shaderc_env_version right) => left.Value == right.Value;

    public static bool operator !=(shaderc_env_version left, shaderc_env_version right) => left.Value != right.Value;

    public static bool operator <(shaderc_env_version left, shaderc_env_version right) => left.Value < right.Value;

    public static bool operator <=(shaderc_env_version left, shaderc_env_version right) => left.Value <= right.Value;

    public static bool operator >(shaderc_env_version left, shaderc_env_version right) => left.Value > right.Value;

    public static bool operator >=(shaderc_env_version left, shaderc_env_version right) => left.Value >= right.Value;

    public static implicit operator shaderc_env_version(byte value) => new shaderc_env_version(value);

    public static explicit operator byte(shaderc_env_version value) => (byte)(value.Value);

    public static explicit operator shaderc_env_version(short value) => new shaderc_env_version(unchecked((uint)(value)));

    public static explicit operator short(shaderc_env_version value) => (short)(value.Value);

    public static explicit operator shaderc_env_version(int value) => new shaderc_env_version(unchecked((uint)(value)));

    public static explicit operator int(shaderc_env_version value) => (int)(value.Value);

    public static explicit operator shaderc_env_version(long value) => new shaderc_env_version(unchecked((uint)(value)));

    public static implicit operator long(shaderc_env_version value) => value.Value;

    public static explicit operator shaderc_env_version(nint value) => new shaderc_env_version(unchecked((uint)(value)));

    public static explicit operator nint(shaderc_env_version value) => (nint)(value.Value);

    public static explicit operator shaderc_env_version(sbyte value) => new shaderc_env_version(unchecked((uint)(value)));

    public static explicit operator sbyte(shaderc_env_version value) => (sbyte)(value.Value);

    public static implicit operator shaderc_env_version(ushort value) => new shaderc_env_version(value);

    public static explicit operator ushort(shaderc_env_version value) => (ushort)(value.Value);

    public static implicit operator shaderc_env_version(uint value) => new shaderc_env_version(value);

    public static implicit operator uint(shaderc_env_version value) => value.Value;

    public static explicit operator shaderc_env_version(ulong value) => new shaderc_env_version(unchecked((uint)(value)));

    public static implicit operator ulong(shaderc_env_version value) => value.Value;

    public static explicit operator shaderc_env_version(nuint value) => new shaderc_env_version(unchecked((uint)(value)));

    public static implicit operator nuint(shaderc_env_version value) => value.Value;

    public int CompareTo(object? obj)
    {
            if (obj is shaderc_env_version other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of shaderc_env_version.");
    }

    public int CompareTo(shaderc_env_version other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is shaderc_env_version other) && Equals(other);

    public bool Equals(shaderc_env_version other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
