using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ScoringZone : MonoBehaviour
{

    public EventTrigger.TriggerEvent scoreTrigger;
    
    
    private void OnCollisionEnter2D(Collision2D others)
    {
        Ball ball = others.gameObject.GetComponent<Ball>();
      
        if (ball != null)
        {
            BaseEventData _baseEventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(_baseEventData);
           
        }


    }
}
