using Xunit;

namespace XUnitPalindromoTest
{
    public class PalindromoTest
    {
        private readonly Helper.Palindromo palindromo;

        public PalindromoTest()
        {
            palindromo = new Helper.Palindromo();
        }

        [Theory]
        [InlineData("Rotator")]
        [InlineData("bob")]
        [InlineData("madam")]
        [InlineData("mAlAyAlam")]
        [InlineData("1")]
        [InlineData("Able was I, ere I saw Elba")]
        [InlineData("Madam I’m Adam")]
        [InlineData("Step on no pets.")]
        [InlineData("Top spot!.")]
        [InlineData("02/02/2020")]
        public void E_Palindromo(string valor)
        {
            Assert.True(palindromo.IsPalindromo(valor));
        }

        [Theory]
        [InlineData("xyz")]
        [InlineData("elephant")]
        [InlineData("Country")]
        [InlineData("Top . post!")]
        [InlineData("Wonderful-fool")]
        [InlineData("Wild imagination!")]
        public void Nao_E_Palindromo(string valor)
        {
            Assert.False(palindromo.IsPalindromo(valor));
        }
    }

    
}
