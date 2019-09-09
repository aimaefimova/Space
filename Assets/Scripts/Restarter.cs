using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    public int index;
    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }
}
