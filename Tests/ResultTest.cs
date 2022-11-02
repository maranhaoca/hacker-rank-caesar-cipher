using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        string s = "There's-a-starman-waiting-in-the-sky";
        int k = 3;

        string expected = "Wkhuh'v-d-vwdupdq-zdlwlqj-lq-wkh-vnb";
        string actual = Result.caesarCipher(s, k);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        string s = "www.abc.xy";
        int k = 87;

        string expected = "fff.jkl.gh";
        string actual = Result.caesarCipher(s, k);

        Assert.Equal(expected, actual);
    }
}