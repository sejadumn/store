namespace Store.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WhitNull_ReturnFalse()
        {
            bool actual = Book.IsIsbn(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WhitBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbn("   ");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WhithInvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbn("ISBN 123");

            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WhithISBN10_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0");

            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WhithISBN13_ReturnTrue()
        {
            bool actual = Book.IsIsbn("IsBn 123-456-789 0123");

            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_WhitTrashSytart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("xxx IsBn 123-456-789 0123 yyy");

            Assert.False(actual);
        }
    }
}