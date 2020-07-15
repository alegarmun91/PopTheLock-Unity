using TMPro;
using UnityEngine;

public class LevelTextUI : MonoBehaviour
{
    public GameData gameData;
    private TMP_Text _text;

    private void Start()
    {
        _text = GetComponent<TMP_Text>();
        _text.text = "Level: " + gameData.currentLevel.ToString();
    }

    private void FixedUpdate()
    {
        _text.text = "Level: " + gameData.currentLevel.ToString();
    }
}
