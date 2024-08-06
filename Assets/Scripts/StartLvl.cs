using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartLvl : MonoBehaviour
{
    // Загружаем первый уровень
    
    public void StartL() {
    	SceneManager.LoadScene("lvl_1");
    }

    
}
