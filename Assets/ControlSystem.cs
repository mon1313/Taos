using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("MainScene");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator MainScene()
    {
       
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("SampleScene");
    }
}
