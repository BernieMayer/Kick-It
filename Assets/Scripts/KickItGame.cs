using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class KickItGame : ScriptableObject
{

    public Move[] moves;
    public ArrayList currentMoves;
    
    public enum Move
    {
        Jab,
        Cross,
        Kick
    }

    public Move[] GenerateMoves() 
    {
        int arraySize = 3;

        Move[] moves = new Move[arraySize];

        System.Random rand = new System.Random();

        for (int i = 0; i < arraySize; i++)
        {
            int randomIndex = rand.Next(Enum.GetValues(typeof(Move)).Length);
            moves[i] = (Move)Enum.GetValues(typeof(Move)).GetValue(randomIndex);
        }

        this.moves = moves;
        this.currentMoves = new ArrayList();
        return moves;
    }

    public void AddMove(Move move) 
    {
        currentMoves.Add(move);
    }

}
