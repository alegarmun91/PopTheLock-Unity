using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesIconsHandler : MonoBehaviour
{
    public GameData gameData;
    public HeartController[] heartContainers;

    public void UpdateLivesIndicator()
    {
        if (gameData.livesRemaining < 0) return;

        for (int i = 0; i < gameData.maxLives; i++)
        {
            heartContainers[i].IsHeartFilled(i < (gameData.livesRemaining));
        }
    }
}
