using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] ScoreData scoreData;
    [SerializeField] int startWater;

   

    private void OnTriggerEnter(Collider other)
    {
        ICollectible iCollect = other.GetComponent<ICollectible>();
        if (iCollect != null)
        {
            iCollect.Collect();
        }

        ITalking talking = other.GetComponent<ITalking>();
        if(talking != null)
        {
            talking.Talk();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ITalking talking = collision.gameObject.GetComponent<ITalking>();
        if (talking != null)
        {
            talking.Talk();
        }
    }
}

