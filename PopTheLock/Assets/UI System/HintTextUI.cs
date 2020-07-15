using System;
using TMPro;
using UnityEngine;

public class HintTextUI : MonoBehaviour
{
    public GameData gameData;
    private TMP_Text _text;

    private void Update()
    {
        gameObject.SetActive(gameData.currentLevel <= 1);
    }
}
