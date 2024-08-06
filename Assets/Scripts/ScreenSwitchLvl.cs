using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenSwitchLvl : MonoBehaviour
{
    public void ScreenSwitching()
    {
        SceneManager.LoadScene("lvl_select"); // Меняем сцену на выбор уровня
    }
}
