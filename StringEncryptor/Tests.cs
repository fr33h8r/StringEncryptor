using FluentAssertions;
using Xunit;

namespace StringEncryptor
{
    public class EncryptorTests
    {
        [Fact]
        public void should_get_char_return_number()
        {
            //act
            var res = new Encryptor().Convert("a");
            //assert
            res.Should().BeEquivalentTo("1");
        }

        [Fact(Skip = "")]
        public void should_get_int_return_char()
        {
            //act
            //var res = Encryptor.IntToChar("1");
            //assert
            //res.Should().BeEquivalentTo("a");
        }

        [Fact]
        public void should_take_string_of_chars_return_nums()
        {
            var res = new Encryptor().Convert("abcd");
            res.Should().BeEquivalentTo("1_2_3_4");
        }

        [Fact(Skip = "")]
        public void should_take_string_of_nums_return_chars()
        {
            //var res = Encryptor.IntToChar("1_2_3_4");
            //res.Should().BeEquivalentTo("abcd");
        }

        [Fact]
        public void should_take_chars_and_convert_them_to_nums()
        {
            //arrange
            const string text = "ab cd";
            const string expected = "1_2_0_3_4";
            //act
            var res = new Encryptor().Convert(text);
            //assert
            res.Should().BeEquivalentTo(expected);
        }
        [Fact(Skip = "")]
        public void should_take_nums_and_convert_them_to_chars()
        {
            //arrange
            const string text = "1_2_3_4";
            const string expected = "abcd";
            //act
            var res = new Encryptor().Convert(text);
            //assert
            res.Should().BeEquivalentTo(expected);
        }
    }
}