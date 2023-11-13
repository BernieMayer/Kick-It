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
    public TextMeshProUGUI scoreText;
    public Button retryButton;
    public GameObject boxer;
    Animator boxerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        boxerAnimator = boxer.GetComponent<Animator>();
        game = ScriptableObject.CreateInstance<KickItGame>();
        game.GenerateMoves();

        // retryButton.gameObect.setActive(false);
        UpdateGameUI();
    }

    public void Retry() {
        game = ScriptableObject.CreateInstance<KickItGame>();
        game.GenerateMoves();

        UpdateGameUI();
    }

    public void JabEvent()
    {
        boxerAnimator.SetTrigger("Jab");
        game.AddMove(KickItGame.Move.Jab);
        UpdateGameUI();
    }

    public void CrossEvent()
    {
        boxerAnimator.SetTrigger("Cross");
        game.AddMove(KickItGame.Move.Cross);
        UpdateGameUI();
    }

    public void KickEvent() 
    {
        boxerAnimator.SetTrigger("Kick");
        game.AddMove(KickItGame.Move.Kick);
        UpdateGameUI();
    }

    void UpdateGameUI()
    {
        var moves = game.moves;
        string currentSequence = string.Join(", ", moves.Select(m => m.ToString()));
        currentSequenceText.SetText(currentSequence);
        if (!game.IsGameOver()) {
            scoreText.SetText("Score: " + game.Score);
        } else {
            scoreText.SetText("Game Over :(");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
