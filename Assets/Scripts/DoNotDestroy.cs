using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
	// При запуске не уничтожаем объекты с тегом NotDestroy (Такие как музыка, пауза и т.п)
    private void Awake()
    {
    	GameObject[] musicObj = GameObject.FindGameObjectsWithTag("NotDestroy");
    	
    	DontDestroyOnLoad(this.gameObject); 
    }
}
