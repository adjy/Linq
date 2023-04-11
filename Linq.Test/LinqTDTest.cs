using System.Collections.Generic;
using System.Linq;

using Xunit;

namespace Linq.Test {
	public class LinqTDTest {
		private readonly IEnumerable<string> stringSequence = new List<string>() {
			"aaaa",
			"abcd",
			"bbbb",
			"cccc",
			"dddd",
			"gggggggg",
		};

		private readonly IEnumerable<int> intSequence = new List<int>() {
			0, 10, 12, 27, 56, 43, 101, -2, 6, 0, 0, 0, 0
		};

		private readonly IEnumerable<DummyModel> objectSequence = new List<DummyModel>() {
			new DummyModel { Id = 1, Name = "Alice", IsDeleted = false, Age = 21 },
			new DummyModel { Id = 2, Name = "Bob", IsDeleted = true, Age = 35 },
			new DummyModel { Id = 3, Name = "Charlie", IsDeleted = false, Age = 12 },
			new DummyModel { Id = 4, Name = "Dan", IsDeleted = false, Age = 24 }
		};

		[Theory]
		[InlineData('a')]
		[InlineData('b')]
		[InlineData('e')]
		[InlineData('g')]
		[InlineData('z')]
		public void Linq_Should_Filter__Starting_Letter(char letter) {
			List<string> results = new();
			foreach (string element in stringSequence) {
				if (element.StartsWith(letter)) {
					results.Add(element);
				}
			}

			Assert.Equal(
				LinqTD.FilterElementsBeginningWithSpecificLetter(stringSequence, letter),
				results
			);
		}

		[Theory]
		[InlineData(2)]
		[InlineData(4)]
		[InlineData(6)]
		[InlineData(8)]
		public void Linq_Should_Returns__FirstElementOfLengthI(int size) {
			string? result = default;
			foreach (string element in stringSequence) {
				if (element.Length == size) {
					result = element;
					break;
				}
			}

			Assert.Equal(
				LinqTD.FirstElementOfLengthI(stringSequence, size),
				result
			);
		}

		[Fact]
		public void Linq_Should_Returns_AverageOfSequence() {
			double average = 0;
			foreach (int element in intSequence) {
				average += element;
			}
			average /= intSequence.Count();

			Assert.Equal(
				LinqTD.AverageOfSequence(intSequence),
				average
			);
		}

		[Fact]
		public void Linq_Should_Returns_AverageOfUniqueSequenceElements() {
			double average = 0;
			List<int> alreadyAddedElements = new();
			foreach (int element in intSequence) {
				if (alreadyAddedElements.Contains(element)) {
					continue;
				}

				alreadyAddedElements.Add(element);

				average += element;
			}
			average /= alreadyAddedElements.Count;

			Assert.Equal(
				LinqTD.AverageOfUniqueSequenceElements(intSequence),
				average
			);
		}

		[Fact]
		public void Linq_Should_Returns_MinMaxOfSequence() {
			int min = int.MaxValue;
			int max = int.MinValue;

			foreach (int element in intSequence) {
				if (element < min) {
					min = element;
				}

				if (element > max) {
					max = element;
				}
			}

			Assert.Equal(
				LinqTD.MinMaxOfSequence(intSequence),
				(min, max)
			);
		}

		[Fact]
		public void Linq_Should_Returns_IdsListOfSequence() {
			List<int> ids = new();
			foreach (var element in objectSequence) {
				ids.Add(element.Id);
			}

			Assert.Equal(
				LinqTD.IdsListOfSequence(objectSequence),
				ids
			);
		}

		[Fact]
		public void Linq_Should_Returns_AgeAverageOfSequence() {
			double average = 0;
			int i = 0;
			foreach (var element in objectSequence) {
				if (element.IsDeleted) {
					continue;
				}

				i++;
				average += element.Age;
			}
			average /= i;

			Assert.Equal(
				LinqTD.AgeAverageOfSequence(objectSequence),
				average
			);
		}

		[Theory]
		[InlineData(12, true)]
		[InlineData(24, true)]
		[InlineData(25, false)]
		[InlineData(36, false)]
		public void Linq_Should_Returns_IfSomeonesHasASpecificAge(int age, bool expectedResult) {
			Assert.Equal(
				LinqTD.DoesSomeonesHasASpecificAge(objectSequence, age),
				expectedResult
			);
		}
	}
}
