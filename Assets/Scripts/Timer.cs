using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
public Text scoreText;
public GameObject GameOverText;
public int Time = 30;
 
	void Start () 
    {
		InvokeRepeating("RunTimer", 1, 1);
	}
 
	void RunTimer() 
    {
        Time--;
        if (Time > 0)
        {
            scoreText.text = Time.ToString();
        }
		else
        {
            GameOverText.SetActive(true);
            scoreText.text = "";
            CancelInvoke();
            GameController.Instance.audioManager.StopBGMusic();
            UnityEngine.Time.timeScale=0;
        }
	}
}
