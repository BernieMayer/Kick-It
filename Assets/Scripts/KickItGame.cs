using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class KickItGame : ScriptableObject
{

    public Move[] moves;
    public ArrayList currentMoves;
    bool gameOver = false;
    public int Score = 0; 
    
    public enum Move
    {
        Jab,
        Cross,
        Kick
    }


    public Move[] GenerateMoves() 
    {
        int arraySize = NumMovesToGenerate();

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

    private int NumMovesToGenerate()
    {
        if (Score < 20) 
        {
            return 3;
        } else if (Score < 40) {
            return 4;
        } else {
            return 5;
        }

    }

    public void AddMove(Move move) 
    {
        currentMoves.Add(move);

        int i = 0;
        foreach (Move userMove in currentMoves) {
            if (moves[i] != userMove) {
                gameOver = true;
                break;
            }

            i++;
        }

        if (!gameOver) {
            this.Score++;

            if (i == moves.Length) {
                this.GenerateMoves();
            }
        } 
    }

    public bool IsGameOver() 
    {
        return gameOver;
    }

}
