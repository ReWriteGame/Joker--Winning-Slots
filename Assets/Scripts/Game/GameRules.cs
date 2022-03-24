using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
   [SerializeField] private ScoreCounter score;
   [SerializeField] private ScoreCounter bid;

   

   public void WinRound()
   {
      score.Add(GetValueBid());
   }
   public void LoseRound()
   {
      score.TakeAway(GetValueBid());
   }
   
   private float GetValueBid()
   {
      return bid.Score > score.Score ? score.Score : bid.Score;
   }
}
