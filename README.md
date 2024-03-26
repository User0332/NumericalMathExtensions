# NumericalMathExtensions

A collection of generic math extension methods for all number types that make them more natural and easier to work with. Not yet published as a NuGet package.

Currently the extensions include:

```cs
public double INumber<T>.ToRadians<T>();
public double INumber<T>.ToDegrees<T>();
public TFloat INumber<T>.ToRadians<T, TFloat>();
public TFloat INumber<T>.ToDegrees<T, TFloat>();
public TCast INumber<TFrom>.Cast<TFrom, TCast>();
public double INumber<T>.ToDouble<T>();
public float INumber<T>.ToFloat<T>();
public decimal INumber<T>.ToDecimal<T>();
public byte INumber<T>.ToByte<T>();
public sbyte INumber<T>.ToSByte<T>();
public short INumber<T>.ToShort<T>();
public ushort INumber<T>.ToUShort<T>();
public int INumber<T>.ToInt<T>();
public uint INumber<T>.ToUInt<T>();
public long INumber<T>.ToLong<T>();
public ulong INumber<T>.ToULong<T>();
public nint INumber<T>.ToNInt<T>();
public nuint INumber<T>.ToNUInt<T>();
public BigInteger INumber<T>.ToBigInt<T>();
public char INumber<T>.ToChar<T>();
public T[] INumber<T>.PlaceInArray<T>();
public List<T> INumber<T>.PlaceInList<T>();
public bool INumber<T>.IsZero<T>();
public bool INumber<T>.IsOdd<T>();
public bool INumber<T>.IsEven<T>();
public bool INumber<T>.IsGreaterThan<T>(T other);
public bool INumber<T>.IsGreaterThanOrEqualTo<T>(T other);
public bool INumber<T>.IsLessThan<T>(T other);
public bool INumber<T>.IsLessThanOrEqualTo<T>(T other);
public bool INumber<T>.IsIntegral<T>();
public bool INumber<T>.IsFloating<T>();
public bool INumber<T>.IsNaN<T>();
public bool INumber<T>.IsInfinity<T>();
public bool INumber<T>.IsFinite<T>();

public T INumber<T>.Max<T>(T other);
public T INumber<T>.Min<T>(T other);
public T INumber<T>.Double<T>();
public T INumber<T>.Halve<T>();
public T INumber<T>.Increment<T>();
public T INumber<T>.Decrement<T>();

public object INumber<T>.Box();
public INumber<T> object.UnBoxNum<T>();
```