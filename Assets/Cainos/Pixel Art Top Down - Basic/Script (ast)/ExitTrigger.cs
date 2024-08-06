using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTrigger : MonoBehaviour
{
	// При соприкосновении с зоной выхода меняем сцену
	private void OnTriggerEnter2D(Collider2D other) {
	    foreach (var ds in GameObject.FindGameObjectsWithTag("NotDestroy")) { // Уничтожение тега NotDestroy
	    	Destroy(ds);
    	};
    	SceneManager.LoadScene("Menu"); // Загружаем сцену
    }
}
