using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;

    public static int theScore ;

    private void Start()
    {
        theScore = 0;
    }

    private void Update()
    {
        scoreText.GetComponent<Text>().text = "Score : " + theScore;
    }

    private void OnTriggerEnter(Collider other)
    {
        theScore += 1;
        Destroy(gameObject);

    }

}
