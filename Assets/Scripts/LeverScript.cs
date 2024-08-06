using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeverScript : MonoBehaviour
{
	// Скрипт рычага из лабиринта, уничтожение и замена двери + рычага
	public GameObject lvroff;
    public GameObject lvron;
    public GameObject dropn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
        	if (GameObject.FindWithTag("LeverOff"))
                {
                    Destroy(GameObject.FindWithTag("LeverOff"));
                    Destroy(GameObject.FindWithTag("Zaval"));
                    Debug.Log("Destoryed lo");
                }
                GameObject varA = Instantiate(lvron, new Vector3(-6.657f, -28.41f, 0f), Quaternion.identity);
                varA.tag = "LeverOn";
                varA.transform.localScale = new Vector3(1.8579f, 1.666f, 1f);
                GameObject varB = Instantiate(dropn, new Vector3(0.8898507f, -2.849429f, 0f), Quaternion.identity);
                

		}

	}
}