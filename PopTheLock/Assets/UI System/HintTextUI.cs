﻿using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class HintTextUI : MonoBehaviour
{
    public GameData gameData;
    public TMP_Text _text;

    public void FadeOut()
    {
        StartCoroutine(FadeEffect.FadeTMP_Text(_text, _text.alpha, 0f, 1f));
    }
}
