using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestKickItGame
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestKickItGameSimplePasses()
    {
        // Use the Assert class to test conditions
        KickItGame game = ScriptableObject.CreateInstance<KickItGame>();

        Assert.That(game != null);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestKickItGameWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
