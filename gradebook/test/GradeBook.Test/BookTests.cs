using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStats();

            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B',result.Letter);
        }

        [Fact]
        public void test1()
        {
            var book = new Book("test");
            book.AddGrade(-1);
            book.AddGrade(105);
            book.AddGrade(85);

            Assert.Equal(1, book.grades.Count);

        }
    }
}
