using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] ScoreData scoreData;
    [SerializeField] int startWater;

    private void Start()
    {
        scoreData.InitScoreValue(startWater);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ICollectible>() != null)
        {
            other.GetComponent<ICollectible>().Collect();
        }
    }
}

