using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    public SpriteRenderer heartFillRenderer;

    public void IsHeartFilled(bool isFilled)
    {
        heartFillRenderer.enabled = isFilled;
    }
}
