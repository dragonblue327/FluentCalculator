
public class FluentCalculatorTests
{
	[Fact]
	public void Addition_ShouldReturnCorrectResult()
	{
		// Arrange & Act
		var result = FluentCalculator.One.Plus.Two;

		// Assert
		Assert.Equal(3, result);
	}

	[Fact]
	public void Subtraction_ShouldReturnCorrectResult()
	{
		// Arrange & Act
		var result = FluentCalculator.Five.Minus.Two;

		// Assert
		Assert.Equal(3, result);
	}

	[Fact]
	public void Multiplication_ShouldReturnCorrectResult()
	{
		// Arrange & Act
		var result = FluentCalculator.Three.Times.Two;

		// Assert
		Assert.Equal(6, result);
	}

	[Fact]
	public void Division_ShouldReturnCorrectResult()
	{
		// Arrange & Act
		var result = FluentCalculator.Six.DividedBy.Two;

		// Assert
		Assert.Equal(3, result);
	}

	[Fact]
	public void ComplexExpression_ShouldReturnCorrectResult()
	{
		// Arrange & Act
		var result = FluentCalculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four;

		// Assert
		Assert.Equal(-1, result);
	}

	[Fact]
	public void Value_ShouldResolveToPrimitiveInteger()
	{
		// Arrange & Act
		var result = FluentCalculator.One.Plus.Ten - 10;

		// Assert
		Assert.Equal(1, result);
	}



	[Fact]
	public void Operation_CannotCallAnotherOperation()
	{
		// Arrange & Act
		Action action = () => { var result = FluentCalculator.One.Plus.Plus; };

		// Assert
		Assert.Throws<InvalidOperationException>(action);
	}
}
