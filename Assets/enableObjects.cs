using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableObjects : MonoBehaviour {
    public GameObject object_1;
    public GameObject object_2;
    public GameObject object_3;
    public GameObject object_4;
    public GameObject object_5;
    public GameObject object_6;
    public GameObject object_7;
    public GameObject object_8;
    public GameObject object_9;
    public GameObject object_10;
    public GameObject object_11;
    public GameObject object_12;
    public GameObject object_13;
    // Use this for initialization
    void Start() {
        StartCoroutine("Waiting");
    }

    // Update is called once per frame
    void Update() {

    }

    IEnumerator Waiting() {
        yield return new WaitForSeconds(5.0f);
        object_1.SetActive(true);
        object_2.SetActive(true);
        object_3.SetActive(true);
        object_4.SetActive(true);
        object_5.SetActive(true);
        object_6.SetActive(true);
        object_7.SetActive(true);
        object_8.SetActive(true);
        object_9.SetActive(true);
        object_10.SetActive(true);
        object_11.SetActive(true);
        object_12.SetActive(true);
        object_13.SetActive(true);

    }

}
