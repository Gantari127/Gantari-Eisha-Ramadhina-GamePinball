using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TriggerRampController : MonoBehaviour
{
    public float score;

    public Collider bola;
    public ScoreManager scoreManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            //score add
            scoreManager.AddScore(score);
        }
    }
}
