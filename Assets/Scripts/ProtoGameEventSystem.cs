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
    public GameObject boxer;
    Animator boxerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        boxerAnimator = boxer.GetComponent<Animator>();
        game = new KickItGame();
        var moves = game.GenerateMoves();
        string currentSequence = string.Join(", ", moves.Select(m => m.ToString()));
        currentSequenceText.SetText(currentSequence);
    }

    public void JabEvent()
    {
        boxerAnimator.SetTrigger("Jab");
    }

    public void CrossEvent()
    {
        boxerAnimator.SetTrigger("Cross");
    }

    public void KickEvent() 
    {
        boxerAnimator.SetTrigger("Kick");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
