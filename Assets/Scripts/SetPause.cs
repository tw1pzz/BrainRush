using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetPause : MonoBehaviour
{
    public GameObject pauseMenu; // Игровой оъект Panel для Меню
    public KeyCode pauseKey; // Кнопка паузы (Esc)
    public static bool isPaused; // Bool-переменная, пастовлена ли игра на паузу
    public GameObject Btns; // Игровой оъект кнопок для удаления
    public Slider slider; // Объект слайдера, для управления музыкой
    

    void Start() {
    	pauseMenu.SetActive(false); // При запуске игры меню скрыто
    }

    void Update() {
    	if (SceneManager.GetActiveScene().name == "lvl_select") {
    		return;
    	} // Меню паузы скрыто на выборе уровня

    	if(Input.GetKeyDown(KeyCode.Escape)) // Если нажали Escape
    	{
    		if(isPaused) {
    			ResumeGame(); // Если пауза true - продолжаем игру

    		}
    		else{
    			PauseGame(); // Если пауза false - ставим игру на паузу
    		}
    		try {
    		
    			Btns.SetActive(!SetPause.isPaused); // Убираем кнопки
    		}
    		catch {
    			Debug.Log("Btns f");
    		}

    		
    	}
    	AudioListener.volume = slider.value; // Меняем громкость музыки слайдером

    }

    public void PauseGame() { // Функция паузы игры
    	pauseMenu.SetActive(true); // Показываем меню
    	Time.timeScale = 0f; // Остановка времени
    	isPaused = true; // Переменная true - игра на паузе
    }

    public void ResumeGame() { // Функция продолжения игры
    	pauseMenu.SetActive(false); // Убираем меню
    	Time.timeScale = 1f; // Ставим стандартное значение времени
    	isPaused = false; // Переменная false - игра продолжается
    }
    
}
