using System;
using leetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetCodeTest
{
    [TestClass]
    public class LongestPalindromeClassTest
    {
        [TestMethod]
        public void SimpleInput()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("babad");
            Assert.IsTrue(result == "bab" || result == "aba");
        }
        [TestMethod]
        public void OnlyOneCharPalindrome()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("aaaaab");
            Assert.IsTrue(result == "aaaaa");
        }
        [TestMethod]
        public void OnlyTwoCharPalindrome()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("bbaabaa");
            Assert.IsTrue(result == "aabaa");
        }
        [TestMethod]
        public void IsPalindromeSimpleTestWithPalindrome()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.IsPalindrome("aabaa");
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsPalindromeSimpleTestWithNoPalindrome()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.IsPalindrome("aaabaa");
            Assert.IsTrue(!result);
        }
        [TestMethod]
        public void IsPalindromeBigParam()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            Assert.IsTrue(result == "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
        }
        [TestMethod]
        public void IsPalindromeOneSingleChar()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("a");
            Assert.IsTrue(result == "a");
        }
        [TestMethod]
        public void IsPalindromeComplicatedLongParam()
        {
            LongestPalindromeClass instance = new LongestPalindromeClass();
            var result = instance.LongestPalindrome("jglknendplocymmvwtoxvebkekzfdhykknufqdkntnqvgfbahsljkobhbxkvyictzkqjqydczuxjkgecdyhixdttxfqmgksrkyvopwprsgoszftuhawflzjyuyrujrxluhzjvbflxgcovilthvuihzttzithnsqbdxtafxrfrblulsakrahulwthhbjcslceewxfxtavljpimaqqlcbrdgtgjryjytgxljxtravwdlnrrauxplempnbfeusgtqzjtzshwieutxdytlrrqvyemlyzolhbkzhyfyttevqnfvmpqjngcnazmaagwihxrhmcibyfkccyrqwnzlzqeuenhwlzhbxqxerfifzncimwqsfatudjihtumrtjtggzleovihifxufvwqeimbxvzlxwcsknksogsbwwdlwulnetdysvsfkonggeedtshxqkgbhoscjgpiel");
            Assert.IsTrue(result == "sknks");
        }
    }
}
