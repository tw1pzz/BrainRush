using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsBtn : MonoBehaviour
{
    
    public GameObject pauseMenu;
    public GameObject Btns;
    public GameObject self;

    void Update() { // Пауза не будет работать если сцена lvl_select
    	if (SceneManager.GetActiveScene().name == "lvl_select") {
    		self.SetActive(false);
    	}
    	else {
    		self.SetActive(true);
    	}
    }


    public void ButClick() {
    	

    	if (SetPause.isPaused == true) {
    		ResumeGame();
    	}
    	else {
    		PauseGame();
    	}
    	try {
    		Btns.SetActive(!SetPause.isPaused);
    		
    		
    	}
    	catch {
    			Debug.Log("Pass");
    		}
    }

    public void PauseGame() {
    	pauseMenu.SetActive(true);
    	Time.timeScale = 0f;
    	SetPause.isPaused = true;
    }

    public void ResumeGame() {
    	pauseMenu.SetActive(false);
    	Time.timeScale = 1f;
    	SetPause.isPaused = false;
    }

    
}
