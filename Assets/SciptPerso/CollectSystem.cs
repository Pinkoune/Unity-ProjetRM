using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int leScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score : " + leScore;
    }
}
