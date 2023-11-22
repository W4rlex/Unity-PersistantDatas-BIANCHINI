using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, ICollectible
{
    [SerializeField] int _value;
    [SerializeField] ScoreData _scoreData;

    public void Collect()
    {
        _scoreData.UpdateScoreValue(_value);
        Destroy(gameObject);
    }
}
