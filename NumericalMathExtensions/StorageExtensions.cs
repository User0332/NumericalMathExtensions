using System.Numerics;
using System.Runtime.CompilerServices;

namespace NumericalMathExtensions;

public static class StorageExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static object Box<T>(this T val) where T : INumber<T>
	{
		return val;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static INumber<T> UnBoxNum<T>(this object val) where T : INumber<T>
	{
		return (INumber<T>) val;
	}
}