using UnityEngine;
using TMPro;
using System.Collections;

[RequireComponent(typeof (TMP_Text))]
public class GameStateTextHandler : MonoBehaviour, IObserver<GameState>
{
#region Private Properties
    TMP_Text gameStateText;
    Stack mStack;

    Queue mQueue;

    
    #endregion


    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameStateText = GetComponent<TMP_Text>();
        Debug.Log($"<color=green>TextComponent Text: {gameStateText.text}</color>");
    }

#endregion
    
#region IObserver Implementation
    public void OnNotify(GameState data)
    {
        gameStateText.text = $"{data.name}";
    }
#endregion
    
}
