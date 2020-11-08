﻿using Require;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace OneOf
{
	[DebuggerDisplay("{Value}")]
	public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
	{
		private readonly int index;
		private readonly T0 value0;
		private readonly T1 value1;
		private readonly T2 value2;
		private readonly T3 value3;
		private readonly T4 value4;
		private readonly T5 value5;
		private readonly T6 value6;
		private readonly T7 value7;
		private readonly T8 value8;
		private readonly T9 value9;

		OneOf(bool _)
		{
			index = default!;
			value0 = default!;
			value1 = default!;
			value2 = default!;
			value3 = default!;
			value4 = default!;
			value5 = default!;
			value6 = default!;
			value7 = default!;
			value8 = default!;
			value9 = default!;
		}

		OneOf(T0 value) : this(false) => (index, value0) = (0, value);
		OneOf(T1 value) : this(false) => (index, value1) = (1, value);
		OneOf(T2 value) : this(false) => (index, value2) = (2, value);
		OneOf(T3 value) : this(false) => (index, value3) = (3, value);
		OneOf(T4 value) : this(false) => (index, value4) = (4, value);
		OneOf(T5 value) : this(false) => (index, value5) = (5, value);
		OneOf(T6 value) : this(false) => (index, value6) = (6, value);
		OneOf(T7 value) : this(false) => (index, value7) = (7, value);
		OneOf(T8 value) : this(false) => (index, value8) = (8, value);
		OneOf(T9 value) : this(false) => (index, value9) = (9, value);

		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T8 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);
		public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T9 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t);

		public object? Value => index switch
		{
			0 => value0,
			1 => value1,
			2 => value2,
			3 => value3,
			4 => value4,
			5 => value5,
			6 => value6,
			7 => value7,
			8 => value8,
			9 => value9,
			_ => throw new InvalidOperationException(),
		};

		public bool Is<T>(Type<T0> _ = default!) where T : T0 => index == 0;
		public bool Is<T>(Type<T1> _ = default!) where T : T1 => index == 1;
		public bool Is<T>(Type<T2> _ = default!) where T : T2 => index == 2;
		public bool Is<T>(Type<T3> _ = default!) where T : T3 => index == 3;
		public bool Is<T>(Type<T4> _ = default!) where T : T4 => index == 4;
		public bool Is<T>(Type<T5> _ = default!) where T : T5 => index == 5;
		public bool Is<T>(Type<T6> _ = default!) where T : T6 => index == 6;
		public bool Is<T>(Type<T7> _ = default!) where T : T7 => index == 7;
		public bool Is<T>(Type<T8> _ = default!) where T : T8 => index == 8;
		public bool Is<T>(Type<T9> _ = default!) where T : T9 => index == 9;

		public T0 As<T>(Type<T0> _ = default!) where T : T0 => value0;
		public T1 As<T>(Type<T1> _ = default!) where T : T1 => value1;
		public T2 As<T>(Type<T2> _ = default!) where T : T2 => value2;
		public T3 As<T>(Type<T3> _ = default!) where T : T3 => value3;
		public T4 As<T>(Type<T4> _ = default!) where T : T4 => value4;
		public T5 As<T>(Type<T5> _ = default!) where T : T5 => value5;
		public T6 As<T>(Type<T6> _ = default!) where T : T6 => value6;
		public T7 As<T>(Type<T7> _ = default!) where T : T7 => value7;
		public T8 As<T>(Type<T8> _ = default!) where T : T8 => value8;
		public T9 As<T>(Type<T9> _ = default!) where T : T9 => value9;

		public void Switch
			(/**/Action<T0> f0
			,/**/Action<T1> f1
			,/**/Action<T2> f2
			,/**/Action<T3> f3
			,/**/Action<T4> f4
			,/**/Action<T5> f5
			,/**/Action<T6> f6
			,/**/Action<T7> f7
			,/**/Action<T8> f8
			,/**/Action<T9> f9
			)
		{
			switch (index)
			{
			case 0: f0(value0); break;
			case 1: f1(value1); break;
			case 2: f2(value2); break;
			case 3: f3(value3); break;
			case 4: f4(value4); break;
			case 5: f5(value5); break;
			case 6: f6(value6); break;
			case 7: f7(value7); break;
			case 8: f8(value8); break;
			case 9: f9(value9); break;
			default: throw new InvalidOperationException();
			}
		}

		public TResult Match<TResult>
			(/**/Func<T0, TResult> f0
			,/**/Func<T1, TResult> f1
			,/**/Func<T2, TResult> f2
			,/**/Func<T3, TResult> f3
			,/**/Func<T4, TResult> f4
			,/**/Func<T5, TResult> f5
			,/**/Func<T6, TResult> f6
			,/**/Func<T7, TResult> f7
			,/**/Func<T8, TResult> f8
			,/**/Func<T9, TResult> f9
			)
		{
			return index switch
			{
				0 => f0(value0),
				1 => f1(value1),
				2 => f2(value2),
				3 => f3(value3),
				4 => f4(value4),
				5 => f5(value5),
				6 => f6(value6),
				7 => f7(value7),
				8 => f8(value8),
				9 => f9(value9),
				_ => throw new InvalidOperationException(),
			};
		}

		public OneOf<MapT0, T1, T2, T3, T4, T5, T6, T7, T8, T9> Map<T, MapT0>(Func<T, MapT0> mapFunc, Type<T0> _ = default!) where T : T0 => Match<OneOf<MapT0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>(_0 => mapFunc((T)_0!), _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, MapT1, T2, T3, T4, T5, T6, T7, T8, T9> Map<T, MapT1>(Func<T, MapT1> mapFunc, Type<T1> _ = default!) where T : T1 => Match<OneOf<T0, MapT1, T2, T3, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => mapFunc((T)_1!), _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, MapT2, T3, T4, T5, T6, T7, T8, T9> Map<T, MapT2>(Func<T, MapT2> mapFunc, Type<T2> _ = default!) where T : T2 => Match<OneOf<T0, T1, MapT2, T3, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => mapFunc((T)_2!), _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, MapT3, T4, T5, T6, T7, T8, T9> Map<T, MapT3>(Func<T, MapT3> mapFunc, Type<T3> _ = default!) where T : T3 => Match<OneOf<T0, T1, T2, MapT3, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => mapFunc((T)_3!), _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, T3, MapT4, T5, T6, T7, T8, T9> Map<T, MapT4>(Func<T, MapT4> mapFunc, Type<T4> _ = default!) where T : T4 => Match<OneOf<T0, T1, T2, T3, MapT4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => mapFunc((T)_4!), _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, T3, T4, MapT5, T6, T7, T8, T9> Map<T, MapT5>(Func<T, MapT5> mapFunc, Type<T5> _ = default!) where T : T5 => Match<OneOf<T0, T1, T2, T3, T4, MapT5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => mapFunc((T)_5!), _6 => _6, _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, T3, T4, T5, MapT6, T7, T8, T9> Map<T, MapT6>(Func<T, MapT6> mapFunc, Type<T6> _ = default!) where T : T6 => Match<OneOf<T0, T1, T2, T3, T4, T5, MapT6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => mapFunc((T)_6!), _7 => _7, _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, T3, T4, T5, T6, MapT7, T8, T9> Map<T, MapT7>(Func<T, MapT7> mapFunc, Type<T7> _ = default!) where T : T7 => Match<OneOf<T0, T1, T2, T3, T4, T5, T6, MapT7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => mapFunc((T)_7!), _8 => _8, _9 => _9);
		public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, MapT8, T9> Map<T, MapT8>(Func<T, MapT8> mapFunc, Type<T8> _ = default!) where T : T8 => Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, MapT8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => mapFunc((T)_8!), _9 => _9);
		public OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, MapT9> Map<T, MapT9>(Func<T, MapT9> mapFunc, Type<T9> _ = default!) where T : T9 => Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, MapT9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => mapFunc((T)_9!));

		public bool TryPick<T>(out T value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> remainder, Type<T0> _ = default!) where T : T0 { var @is = Is<T0>(); value = @is ? (T)As<T0>()! : default!; remainder = @is ? default! : Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(_0 => throw new InvalidOperationException(), _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9> remainder, Type<T1> _ = default!) where T : T1 { var @is = Is<T1>(); value = @is ? (T)As<T1>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => throw new InvalidOperationException(), _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9> remainder, Type<T2> _ = default!) where T : T2 { var @is = Is<T2>(); value = @is ? (T)As<T2>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => throw new InvalidOperationException(), _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9> remainder, Type<T3> _ = default!) where T : T3 { var @is = Is<T3>(); value = @is ? (T)As<T3>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => throw new InvalidOperationException(), _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9> remainder, Type<T4> _ = default!) where T : T4 { var @is = Is<T4>(); value = @is ? (T)As<T4>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => throw new InvalidOperationException(), _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9> remainder, Type<T5> _ = default!) where T : T5 { var @is = Is<T5>(); value = @is ? (T)As<T5>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => throw new InvalidOperationException(), _6 => _6, _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9> remainder, Type<T6> _ = default!) where T : T6 { var @is = Is<T6>(); value = @is ? (T)As<T6>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => throw new InvalidOperationException(), _7 => _7, _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9> remainder, Type<T7> _ = default!) where T : T7 { var @is = Is<T7>(); value = @is ? (T)As<T7>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => throw new InvalidOperationException(), _8 => _8, _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9> remainder, Type<T8> _ = default!) where T : T8 { var @is = Is<T8>(); value = @is ? (T)As<T8>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => throw new InvalidOperationException(), _9 => _9); return @is; }
		public bool TryPick<T>(out T value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> remainder, Type<T9> _ = default!) where T : T9 { var @is = Is<T9>(); value = @is ? (T)As<T9>()! : default!; remainder = @is ? default! : Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>>(_0 => _0, _1 => _1, _2 => _2, _3 => _3, _4 => _4, _5 => _5, _6 => _6, _7 => _7, _8 => _8, _9 => throw new InvalidOperationException()); return @is; }

		public override string ToString() => index switch
		{
			0 => value0?.ToString() ?? "",
			1 => value1?.ToString() ?? "",
			2 => value2?.ToString() ?? "",
			3 => value3?.ToString() ?? "",
			4 => value4?.ToString() ?? "",
			5 => value5?.ToString() ?? "",
			6 => value6?.ToString() ?? "",
			7 => value7?.ToString() ?? "",
			8 => value8?.ToString() ?? "",
			9 => value9?.ToString() ?? "",
			_ => throw new InvalidOperationException(),
		};

		public struct EqualityComparer : IEqualityComparer<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>
		{
			public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> x, OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> y) =>
				x.index == y.index
				&& x.index switch
				{
					0 => EqualityComparer<T0>.Default.Equals(x.value0, y.value0),
					1 => EqualityComparer<T1>.Default.Equals(x.value1, y.value1),
					2 => EqualityComparer<T2>.Default.Equals(x.value2, y.value2),
					3 => EqualityComparer<T3>.Default.Equals(x.value3, y.value3),
					4 => EqualityComparer<T4>.Default.Equals(x.value4, y.value4),
					5 => EqualityComparer<T5>.Default.Equals(x.value5, y.value5),
					6 => EqualityComparer<T6>.Default.Equals(x.value6, y.value6),
					7 => EqualityComparer<T7>.Default.Equals(x.value7, y.value7),
					8 => EqualityComparer<T8>.Default.Equals(x.value8, y.value8),
					9 => EqualityComparer<T9>.Default.Equals(x.value9, y.value9),
					_ => throw new InvalidOperationException(),
				};

			public int GetHashCode(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> obj) =>
				obj.index switch
				{
					0 => (obj.index, obj.value0).GetHashCode(),
					1 => (obj.index, obj.value1).GetHashCode(),
					2 => (obj.index, obj.value2).GetHashCode(),
					3 => (obj.index, obj.value3).GetHashCode(),
					4 => (obj.index, obj.value4).GetHashCode(),
					5 => (obj.index, obj.value5).GetHashCode(),
					6 => (obj.index, obj.value6).GetHashCode(),
					7 => (obj.index, obj.value7).GetHashCode(),
					8 => (obj.index, obj.value8).GetHashCode(),
					9 => (obj.index, obj.value9).GetHashCode(),
					_ => throw new InvalidOperationException(),
				};
		}

		#region IEquatable
		public override int GetHashCode() =>
			default(EqualityComparer).GetHashCode(this);

		public override bool Equals(object? other) => other is OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> that &&
			default(EqualityComparer).Equals(this, that);
		public bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> that) =>
			default(EqualityComparer).Equals(this, that);
		public static bool operator ==(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> x, OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> y) =>
			default(EqualityComparer).Equals(x, y);
		public static bool operator !=(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> x, OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> y) =>
			!default(EqualityComparer).Equals(x, y);
		#endregion
	}
}
