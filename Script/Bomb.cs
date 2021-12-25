using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{
    public GameObject failed;
    void Update()
    {
        rotate();
    }

    public void rotate()
    {
        transform.Rotate(new Vector3(0f, 100f, 30f) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider bomb)
    {
        Destroy(gameObject);
        failed.SetActive(true);
        SceneManager.LoadScene("Level01");
    }
}
