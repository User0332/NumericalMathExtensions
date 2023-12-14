using System.Numerics;
using System.Runtime.CompilerServices;

namespace NumericalMathExtensions;

public static class IdentityExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsZero<T>(this T number) where T : INumber<T>
	{
		return T.IsZero(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsOdd<T>(this T number) where T : INumber<T>
	{
		return T.IsOddInteger(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsEven<T>(this T number) where T : INumber<T>
	{
		return !number.IsOdd();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsGreaterThan<T>(this T number, T other) where T : INumber<T>
	{
		return number > other;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsGreaterThanOrEqualTo<T>(this T number, T other) where T : INumber<T>
	{
		return number >= other;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsLessThan<T>(this T number, T other) where T : INumber<T>
	{
		return number < other;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsLessThanOrEqualTo<T>(this T number, T other) where T : INumber<T>
	{
		return number <= other;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsIntegral<T>(this T number) where T : INumber<T>
	{
		return T.IsInteger(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsFloating<T>(this T number) where T : INumber<T>
	{
		return !number.IsIntegral();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsNaN<T>(this T number) where T : INumber<T>
	{
		return T.IsNaN(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsInfinity<T>(this T number) where T : INumber<T>
	{
		return T.IsInfinity(number);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool IsFinite<T>(this T number) where T : INumber<T>
	{
		return T.IsFinite(number);
	}
}