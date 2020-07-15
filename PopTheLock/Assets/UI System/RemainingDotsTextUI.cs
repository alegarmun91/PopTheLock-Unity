using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemainingDotsTextUI : MonoBehaviour
{
    public GameData gameData;
    private TMP_Text _text;
    
    void Start()
    {
        _text = GetComponent<TMP_Text>();
        _text.text = gameData.dotsRemaining.ToString();
    }

    void FixedUpdate()
    {
        _text.text = gameData.dotsRemaining.ToString();
    }
}
