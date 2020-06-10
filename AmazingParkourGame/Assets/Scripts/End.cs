using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            OpenEndScene();
        }
    }

    public void OpenEndScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
