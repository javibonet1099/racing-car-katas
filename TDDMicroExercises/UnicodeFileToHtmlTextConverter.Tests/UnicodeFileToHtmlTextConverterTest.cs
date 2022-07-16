using Xunit;

namespace TDDMicroExercises.UnicodeFileToHtmlTextConverter.Tests
{
    public class UnicodeFileToHtmlTextConverterTest
    {
        [Fact]
        public void It_should_load_a_file_from_url()
        {
            //arrange
            var converter = new UnicodeFileToHtmlTextConverter(@"C:\Users\jaboes\Development\aspire_program\racing_car_katas_good\TDDMicroExercises\TDDMicroExercises\src\unicode.txt");

            //act 
            var result = converter.Convert();

            //assert
            Assert.Equal("Lorem ipsum dolor sit amet<br />", result);
        }

        [Fact]
        public void It_should_convert_a_plain_text()
        {
            //arrange
            var source = new UnicodeTextSourceStub("Hello this is a test");
            var converter = new UnicodeFileToHtmlTextConverter(source);

            //act 
            var result = converter.Convert();

            //assert
            Assert.Equal("Hello this is a test<br />", result);
        }

        [Fact]
        public void It_should_convert_a_plain_text_with_symbols()
        {
            //arrange
            var source = new UnicodeTextSourceStub("Hello this is & test");
            var converter = new UnicodeFileToHtmlTextConverter(source);

            //act 
            var result = converter.Convert();

            //assert
            Assert.Equal("Hello this is &amp; test<br />", result);
        }
    }
}
