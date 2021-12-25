using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour
{
    public GameObject playerWin;

    // Update is called once per frame
    void Update()
    {

        if (ScoringSystem.theScore >= 7)
        {
            gameObject.SetActive(true);
        }
    }
}
