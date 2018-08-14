using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScript : MonoBehaviour
{
    public GameObject Player;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("WaitForDeath");
    }

    void DieDramatically()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForDeath()
    {
        while (true)
        {
            if (Player.transform.position.x < -40.40f || Player.transform.position.x > 40.40f) SceneManager.LoadScene("death");
            yield return new WaitForSeconds(0.5f);
        }
    }
}
