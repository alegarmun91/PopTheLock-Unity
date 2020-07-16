using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    public static IEnumerator FadeTMP_Text(TMP_Text textMeshPro, float startAlpha, float endAlpha, float duration)
    {
        var startTime = Time.time;
        var endTime = Time.time + duration;

        textMeshPro.alpha = startAlpha;

        while (Time.time <= endTime)
        {
            var elapsedTime = Time.time - startTime;
            var percentage = 1 / (duration / elapsedTime);

            if (startAlpha > endAlpha) //fading out/down 
                textMeshPro.alpha = startAlpha - percentage;
            else //fading in/up
                textMeshPro.alpha = startAlpha + percentage;

            yield return new WaitForEndOfFrame();
        }

        textMeshPro.alpha = endAlpha;
    }
}
