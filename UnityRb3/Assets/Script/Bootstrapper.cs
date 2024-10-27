using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bootstrapper : MonoBehaviour
{
    Score score = new Score() { point = 5} ;
    private UnityAction action;

    private void Start()
    {
        action += DecrementPoint;
        ShowScore();
    }
    private void ShowScore()
    {
        Game.Instance.action.Invoke();
    }
    public Score GetScore { get { return score; } }
    public void DecrementPoint()
    {

        score.point--;
        ShowScore();
    }
    public void IncrementPoint()
    {
        score.point++;
        ShowScore();
    }
}
