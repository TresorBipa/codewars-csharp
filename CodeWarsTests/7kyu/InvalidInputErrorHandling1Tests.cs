using System;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InvalidInputErrorHandling1Tests
    {
        [Test]
        public static void FixedTest()
        {
            InvalidInputErrorHandling1.Counter re = InvalidInputErrorHandling1.GetCount("Test");
            Assert.AreEqual(1, re.Vowels);
            Assert.AreEqual(3, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("Here is some text!");
            Assert.AreEqual(6, re.Vowels);
            Assert.AreEqual(8, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("To be a Codewarrior or not to be");
            Assert.AreEqual(12, re.Vowels);
            Assert.AreEqual(13, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("To Kata or not to Kata");
            Assert.AreEqual(8, re.Vowels);
            Assert.AreEqual(9, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("aeiou");
            Assert.AreEqual(5, re.Vowels);
            Assert.AreEqual(0, re.Consonants);
        }

        private static string[] TestText =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam aliquam sed enim non euismod. Aliquam ut turpis at tellus tincidunt aliquam. Nam feugiat urna ac lacus ultrices, eu tempor nulla semper. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Mauris hendrerit lectus eu neque ornare semper. Donec purus elit, cursus quis maximus a, viverra a lorem. Morbi sollicitudin congue volutpat. Vivamus scelerisque, leo quis luctus mattis, sapien quam gravida leo, in tincidunt erat nisl ac augue. Suspendisse placerat a urna nec porta.Nullam facilisis sagittis blandit. Vivamus fermentum consectetur sodales. In rutrum dapibus feugiat. Aenean iaculis lacinia vulputate. Curabitur neque libero, feugiat sed volutpat nec, commodo at sem. Quisque quis mattis ipsum, lacinia aliquet est. Nulla efficitur purus convallis finibus egestas. Curabitur ullamcorper leo ornare velit viverra, mollis vehicula metus vehicula. Praesent id aliquet lacus, eget sagittis sem. Morbi pretium tellus fermentum, mattis nisl ut, sodales sapien.Maecenas sed sollicitudin nunc. Nunc id nunc tellus. Donec ultrices neque nunc, a imperdiet nunc porta at. In id elit convallis, cursus sapien eu, pharetra arcu. Etiam rutrum, neque sit amet porta ultrices, odio risus aliquet odio, ac tempus justo mi ultricies justo. Donec facilisis, diam non sollicitudin mollis, arcu velit sodales nibh, egestas tristique est nulla id purus. Donec venenatis cursus mauris, sit amet posuere leo. Nulla consequat dui est, ut pharetra mauris semper nec. Cras blandit lectus eu neque accumsan facilisis. Donec varius feugiat neque, in cursus leo lobortis quis. Nam nec auctor neque, id suscipit."
                .Split(' ');

        [Test]
        public static void FixedHappyTest()
        {
            InvalidInputErrorHandling1.Counter re = InvalidInputErrorHandling1.GetCount("Test");
            Assert.AreEqual(1, re.Vowels);
            Assert.AreEqual(3, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("Here is some text!");
            Assert.AreEqual(6, re.Vowels);
            Assert.AreEqual(8, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("To be a Codewarrior or not to be");
            Assert.AreEqual(12, re.Vowels);
            Assert.AreEqual(13, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("To Kata or not to Kata");
            Assert.AreEqual(8, re.Vowels);
            Assert.AreEqual(9, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("aeiou");
            Assert.AreEqual(5, re.Vowels);
            Assert.AreEqual(0, re.Consonants);
        }

        [Test]
        public static void FixedUnappyTest()
        {
            InvalidInputErrorHandling1.Counter re = InvalidInputErrorHandling1.GetCount("Test");
            Assert.AreEqual(1, re.Vowels);
            Assert.AreEqual(3, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount("HEre Is sOme text   ");
            Assert.AreEqual(6, re.Vowels);
            Assert.AreEqual(8, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount('k');
            Assert.AreEqual(0, re.Vowels);
            Assert.AreEqual(0, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount(67457468);
            Assert.AreEqual(0, re.Vowels);
            Assert.AreEqual(0, re.Consonants);

            re = InvalidInputErrorHandling1.GetCount(true);
            Assert.AreEqual(0, re.Vowels);
            Assert.AreEqual(0, re.Consonants);
        }

        [Test]
        public static void RandomTests()
        {
            Random rand = new Random();

            object[] invalid = new object[] {"HEre Is sOme text   ", 'k', 563, true};

            for (int i = 0; i < 100; i++)
            {
                if (rand.Next(1, 100) < 50)
                {
                    int textCount = rand.Next(1, TestText.Length);
                    string text = "";
                    for (int x = 0; x < textCount; x++)
                        text += TestText[x].Trim().ToLower();


                    InvalidInputErrorHandling1.Counter re = InvalidInputErrorHandling1.GetCount(text);
                    InvalidInputErrorHandling1.Counter ans = solve(text);
                    Assert.AreEqual(ans.Vowels, re.Vowels);
                    Assert.AreEqual(ans.Consonants, re.Consonants);
                }
                else
                {
                    object input = invalid[rand.Next(0, invalid.Length)];

                    InvalidInputErrorHandling1.Counter re = InvalidInputErrorHandling1.GetCount(input);
                    InvalidInputErrorHandling1.Counter ans = solve(input);
                    Assert.AreEqual(ans.Vowels, re.Vowels);
                    Assert.AreEqual(ans.Consonants, re.Consonants);
                }
            }
        }

        private static InvalidInputErrorHandling1.Counter solve(object word)
        {
            if (word.GetType() != typeof(String))
                return new InvalidInputErrorHandling1.Counter(0, 0);

            string myWord = ((String) word).Trim().ToLower();

            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};

            string pattern = @"[^\w]";
            string replacement = "";
            Regex rgx = new Regex(pattern);
            myWord = rgx.Replace(myWord, replacement);

            return new InvalidInputErrorHandling1.Counter(
                myWord.ToCharArray().Where(l => Array.IndexOf(vowels, l) != -1).ToArray().Length,
                myWord.ToCharArray().Where(l => Array.IndexOf(vowels, l) == -1).ToArray().Length
            );
        }
    }
}