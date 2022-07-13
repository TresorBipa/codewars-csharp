using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests;

[TestFixture]
public class ConsecutiveVowelsInStringTests
{
    [Test]
    public void SampleTests()
    {
        Assertion(0, string.Empty);
        Assertion(6, "agrtertyfikfmroyrntbvsukldkfa");
        Assertion(4, "erfaiekjudhyfimngukduo");
        Assertion(7, "akfheujfkgiaaaofmmfkdfuaiiie");
        Assertion(0, "eiknfhjrytueiouesxdczbeuiuoimnmfhfiuou");
        Assertion(16,
            "desrehakkjfuteknvfiyrtfbehjdjrobchrunbcbbhdhehbvudjsnanbakkjndhfjenfndinmfnbfondndendnfudnfnanndhdemdmcnfdemnfjimdfofnmfnfjanmdnhdua");
        Assertion(11,
            "sudnfhrakekdhhfkakjdjdhvneidkvnudntomcnnamjemdmfudkfhjamvcjedkfdnridnmnbvfhbdjdidncbvchencchdjdodncvchfndnrnencncnffduncbhjdfja");
        Assertion(11, "jurjfdleiifjriisiouajjfyhekkfjvnnmsuimsnvyuhvcodnmfnsumvbjshhsadkvhfeixoua");
        Assertion(3, "jrknjffuolgtahamhaevbgeosreljtbhuiaamxpyxdmyb");
        Assertion(6,
            "sowqapfqbrjpygtmmulybwusgjijbrnchgkxiaazkcniaxllmupjcmkxwcsmzdaessgkkgzctmbchladughtkitcognxvjwiiiltkuebrwemopvxqpeurfsfgjmeuzgvhjnssbhwkfbejzygbytipjtdcyscwofrpwshiakbdnqfioxqulohdlnmmmfpfrriwpwbddpj");
    }

    private static void Assertion(int expected, string input) =>
        Assert.AreEqual(
            expected,
            ConsecutiveVowelsInString.GetTheVowels(input),
            $"\n  Word: \"{input}\""
        );
}