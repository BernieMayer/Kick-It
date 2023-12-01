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
        KickItGame game = ScriptableObject.CreateInstance<KickItGame>();

        Assert.That(game != null);
    }

    [Test]
    public void TestKickItGameGameOver() 
    {
        KickItGame game = ScriptableObject.CreateInstance<KickItGame>();
        KickItGame.Move[] moves = {KickItGame.Move.Jab, KickItGame.Move.Jab};

        game.moves = moves;
        game.currentMoves = new ArrayList();

        game.AddMove(KickItGame.Move.Cross);

        Assert.That(game.IsGameOver()); 
    }

    [Test]
    public void TestKickItGameScoreGoesUp() 
    {
        KickItGame game = ScriptableObject.CreateInstance<KickItGame>();
        KickItGame.Move[] moves = {KickItGame.Move.Jab, KickItGame.Move.Jab, KickItGame.Move.Kick};

        game.moves = moves;
        game.currentMoves = new ArrayList();

        game.AddMove(KickItGame.Move.Jab);
        Assert.That(game.Score == 1);

        game.AddMove(KickItGame.Move.Jab);
        Assert.That(game.Score == 2);

        game.AddMove(KickItGame.Move.Kick);
        Assert.That(game.Score == 3);

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
