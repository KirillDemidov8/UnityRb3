using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Game : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointText;
    [SerializeField] Bootstrapper bootstrapper;
    Score score;
    public UnityAction action;
    public void SetScore()
    {
        score = bootstrapper.GetScore;
        Debug.Log(score.point);
        pointText.text = score.point.ToString();
    }

    public static Game Instance
    {
        get
        {
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
        action += SetScore;
       
    }
    static private Game _instance;
    public void ExitGame()
    {
        Debug.Log("ExitGame");
        score.point = 0;
    }


}
