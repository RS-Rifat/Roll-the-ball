using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    void Update()
    {
        rotate();
    }

    public void rotate()
    {
        transform.Rotate(new Vector3(0f, -100f, 0f) * Time.deltaTime);
    }
}
