using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
  public UnityEvent getSpikeEvent;
  private void OnTriggerEnter2D(Collider2D other)
  {
    if(other.gameObject.GetComponent<Item>())
      other.gameObject.GetComponent<Destroyable>().Destroy();
    
    if(other.gameObject.GetComponent<Spike>())
      getSpikeEvent?.Invoke();
      
  }
}
