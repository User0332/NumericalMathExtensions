using System.Numerics;
using System.Runtime.CompilerServices;

namespace NumericalMathExtensions;

public static class OperationExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Max<T>(this T number, T other) where T : INumber<T>
	{
		return T.Max(number, other);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Min<T>(this T number, T other) where T : INumber<T>
	{
		return T.Min(number, other);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Double<T>(this T number) where T : INumber<T>
	{
		return number*2.Cast<int, T>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Halve<T>(this T number) where T : INumber<T>
	{
		return number/2.Cast<int, T>();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Increment<T>(this T number) where T : INumber<T>
	{
		return number++;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static T Decrement<T>(this T number) where T : INumber<T>
	{
		return number++;
	}
}