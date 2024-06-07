using System;
namespace FluentCalculators
{
	public class CustomBool
	{
		private bool _value;

		public CustomBool(bool value)
		{
			_value = value;
		}

		public override bool Equals(object obj)
		{
			return obj is CustomBool other && _value;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(CustomBool a, bool b)
		{
			return a._value;
		}

		public static bool operator !=(CustomBool a, bool b)
		{
			return !(a == b);
		}

		public static implicit operator bool(CustomBool a)
		{
			return a._value;
		}
	}


	public class FluentCalculator
	{
		private int _value;

		private FluentCalculator(int value)
		{
			_value = value;
		}

		public static Value Zero => new Value(0);
		public static Value One => new Value(1);
		public static Value Two => new Value(2);
		public static Value Three => new Value(3);
		public static Value Four => new Value(4);
		public static Value Five => new Value(5);
		public static Value Six => new Value(6);
		public static Value Seven => new Value(7);
		public static Value Eight => new Value(8);
		public static Value Nine => new Value(9);
		public static Value Ten => new Value(10);

		public class Value
		{
			private int _value;

			public Value(int value)
			{
				_value = value;
			}

			public static implicit operator int(Value value) => value._value;

			public Operation Plus => new Operation(this, (a, b) => a + b);
			public Operation Minus => new Operation(this, (a, b) => a - b);
			public Operation Times => new Operation(this, (a, b) => a * b);
			public Operation DividedBy => new Operation(this, (a, b) => a / b);

			public Value One => throw new InvalidOperationException("A Value cannot call another Value.");
		}

		public class Operation
		{
			private readonly Value _left;
			private readonly Func<int, int, int> _operation;

			public Operation(Value left, Func<int, int, int> operation)
			{
				_left = left;
				_operation = operation;
			}

			public Value Zero => new Value(_operation(_left, 0));
			public Value One => new Value(_operation(_left, 1));
			public Value Two => new Value(_operation(_left, 2));
			public Value Three => new Value(_operation(_left, 3));
			public Value Four => new Value(_operation(_left, 4));
			public Value Five => new Value(_operation(_left, 5));
			public Value Six => new Value(_operation(_left, 6));
			public Value Seven => new Value(_operation(_left, 7));
			public Value Eight => new Value(_operation(_left, 8));
			public Value Nine => new Value(_operation(_left, 9));
			public Value Ten => new Value(_operation(_left, 10));

			public Operation Plus => throw new InvalidOperationException("An Operation cannot call another Operation.");
			public Operation Minus => throw new InvalidOperationException("An Operation cannot call another Operation.");
			public Operation Times => throw new InvalidOperationException("An Operation cannot call another Operation.");
			public Operation DividedBy => throw new InvalidOperationException("An Operation cannot call another Operation.");
		}
	}


	public class Program
	{
		public static void Main(string[] args)
		{
			/* Может ли переменная быть одновременно True и False? 
			 * Нет, это нелогично потому что если преобразовать логическое True к типу int , то получится 1 ,
			  а преобразование False даст 0 , переменная не может быть одновременно True и False.

			 * Переменная типа bool может принимать только одно из двух значений - True или False.
			  
			  
			 * Определите someBool так, чтобы следующее выражение возвращало true: (someBool == true && someBool == false)

			You can see the code below */



			CustomBool someBool = new CustomBool(true);
			if (someBool == true && someBool == false)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}

			Console.WriteLine("\n***** Here the first task ends *****\n");

			try
			{
				Console.WriteLine("\n** Testing that value can call an Operation, but cannot call a value  FluentCalculator.One.One **");
				var result = FluentCalculator.One.One;
				Console.WriteLine(result);
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine("Undefined: " + ex.Message + "\n");
			}

			try
			{
				Console.WriteLine("\n** Testing that Operation can call a Value, but cannot call a operation FluentCalculator.plus.plus **");
				var result = FluentCalculator.One.Plus.Plus;
				Console.WriteLine(result);
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine("Undefined: " + ex.Message + "\n");
			}

			var result1 = FluentCalculator.One.Plus.Two;
			Console.WriteLine(result1); // Output: 3

			var result2 = FluentCalculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four;
			Console.WriteLine(result2); // Output: -1

			var result3 = FluentCalculator.One.Plus.Ten - 10;
			Console.WriteLine(result3); // Output: 1
		}
	}

}