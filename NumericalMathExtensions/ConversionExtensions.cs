using System.Numerics;
using System.Runtime.CompilerServices;

namespace NumericalMathExtensions;

public static class ConversionExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double ToRadians<T>(this T degrees) where T : INumber<T>
	{
		return degrees.Cast<T, double>() * (Math.PI/180);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double ToDegrees<T>(this T radians) where T : INumber<T>
	{
		return radians.Cast<T, double>() * (180/Math.PI);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TFloat ToRadians<T, TFloat>(this T degrees) where T : INumber<T> where TFloat : INumber<TFloat>
	{
		return degrees.Cast<T, TFloat>() * (Math.PI/180).Cast<double, TFloat>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TFloat ToDegrees<T, TFloat>(this T radians) where T : INumber<T> where TFloat : INumber<TFloat>
	{
		return radians.Cast<T, TFloat>() * (180/Math.PI).Cast<double, TFloat>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TCast Cast<TFrom, TCast>(this TFrom number) where TFrom : INumber<TFrom> where TCast : INumber<TCast>
	{
		return TCast.CreateChecked(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double ToDouble<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, double>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float ToFloat<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, float>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal ToDecimal<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, decimal>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte ToByte<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, byte>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte ToSByte<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, sbyte>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static short ToShort<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, short>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort ToUShort<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, ushort>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ToInt<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, int>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint ToUInt<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, uint>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long ToLong<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, long>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong ToULong<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, ulong>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static nint ToNInt<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, nint>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static nuint ToNUInt<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, nuint>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static BigInteger ToBigInt<T>(this T number) where T : INumber<T>
	{
		return number.Cast<T, BigInteger>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static char ToChar<T>(this T number) where T : INumber<T>
	{
		return (char) number.Cast<T, int>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T[] PlaceInArray<T>(this T number) where T : INumber<T>
	{
		return new T[] { number };
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static List<T> PlaceInList<T>(this T number) where T : INumber<T>
	{
		return new() { number };
	}
}
