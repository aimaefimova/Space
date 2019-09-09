using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject coin; // prefab
    public AudioManager audioManager;

    private int Points = 0;
    public Text pointsText;

   // public GameObject tree;
    public GameObject PlayerRed;

    public Stack<GameObject> Coin { get; set; } = new Stack<GameObject>();

    //Singleton
    private static GameController instance;
    public static GameController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<GameController>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        CreateObject(Coin, coin, 10, "Coin");
        InvokeRepeating("SpawnObject", 1, 1);
        UnityEngine.Time.timeScale=1;
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void CreateObject(Stack<GameObject> stack, GameObject prefab, int amount, string name)
    {
        for (int i = 1; i <= amount; i++)
        {
            stack.Push(Instantiate(prefab));
            stack.Peek().name = name + " №" + i;
            stack.Peek().SetActive(false);
        }
    }

    public void SpawnObject()
    {
        if (Coin.Count != 0) 
        {
        GameObject item = Coin.Pop();
        item.SetActive(true);
        item.transform.position = new Vector2 (Random.Range(-8f, 8f), Random.Range(-5f, 5f));
        }
    }

    public void UpPoints()
    {
        Points++;
        pointsText.text = "Очки: " + Points.ToString();
    }


}
