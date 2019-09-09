using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            gameObject.SetActive(false);
            GameController.Instance.Coin.Push(gameObject);
        }
    }
}
