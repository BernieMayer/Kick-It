using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class ProtoGameEventSystem : MonoBehaviour
{
    KickItGame game;
   	public TextMeshProUGUI currentSequenceText;
    // Start is called before the first frame update
    void Start()
    {
        game = new KickItGame();
        var moves = game.GenerateMoves();
        string currentSequence = string.Join(", ", moves.Select(m => m.ToString()));
        currentSequenceText.SetText(currentSequence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
