﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgrammingProblems;

namespace ProgrammingProblemsTests
{
	//TODO Use Xunit pattern to eliminate duplication of code in SwapperUsingArithmeticOperationTests and SwapperUsingXorOperationTests 
	[TestClass]
	public class SwapperUsingArithmeticOperationTests
	{
		[TestMethod]
		public void SwapsPositiveValues()
		{
			// Arrange
			int a = 20, b = 30;

			// Act
			ITwoNumberSwapper sut = new SwapperUsingArithmeticOperation();
			sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(30);
			b.Should().Be(20);
		}

		[TestMethod]
		public void SwapsNegativeValues()
		{
			// Arrange
			int a = -20, b = -30;

			// Act
			ITwoNumberSwapper sut = new SwapperUsingArithmeticOperation();
			sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(-30);
			b.Should().Be(-20);
		}

		[TestMethod]
		public void SwapsZeros()
		{
			// Arrange
			int a = 0, b = 0;

			// Act
			ITwoNumberSwapper sut = new SwapperUsingArithmeticOperation();
			sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(0);
			b.Should().Be(0);
		}

		[TestMethod]
		public void SwapsSameNonZeroValues()
		{
			// Arrange
			int a = 33, b = 33;

			// Act
			ITwoNumberSwapper sut = new SwapperUsingArithmeticOperation();
			sut.Swap(ref a, ref b);

			// Assert
			a.Should().Be(33);
			b.Should().Be(33);
		}
	}
}