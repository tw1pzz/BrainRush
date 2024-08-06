using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Скрипт на паузе - кнопка возврата в меню

public class PauseQuit : MonoBehaviour
{
	public GameObject btn;
	void Update() {
		if (SceneManager.GetActiveScene().name != "Menu") { // Если сцена не меню, то показывваем кнопку
			btn.SetActive(true);
		}
		else {
			btn.SetActive(false);
		}
	}
    public void btnClick() { // При нажатии кнопки возвращаемся в меню и уничтожаем объекты с тегом NotDestroy
    	foreach (var ds in GameObject.FindGameObjectsWithTag("NotDestroy")) {
    		Destroy(ds);
    	};
    	Time.timeScale = 1f;
    	SetPause.isPaused = false;
    	SceneManager.LoadScene("Menu");
    	
    }
    
}
