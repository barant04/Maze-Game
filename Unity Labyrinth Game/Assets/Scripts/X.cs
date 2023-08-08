using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class X : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 0, 0.00f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "X")
        {
            SceneManager.LoadScene("Scenes/Sahne2");
        }
    }
}