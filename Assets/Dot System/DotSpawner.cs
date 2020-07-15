using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class DotSpawner : MonoBehaviour
{
    public AnchoredMotor motor;
    public GameObject dotPrefab;
    public GameData gameData;

    private GameObject _activeDot;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        if (_activeDot)
            Destroy(_activeDot);

        if (gameData.dotsRemaining > 0)
        {
            Transform motorTransform = motor.transform;
            var angle = Random.Range(45, 100);
            
            _activeDot = Instantiate(dotPrefab, motorTransform.position, Quaternion.identity , motorTransform.parent);
        
            _activeDot.transform.RotateAround(transform.position, Vector3.forward, angle*(int)motor.direction);
        }
        
    }
}
