using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


// Скрипт уровня с рунами


public class PillarController : MonoBehaviour, IControllerButtonPilarLeft, IControllerButtonPilarRight, IControllerButtonPilarMiddle {
    public List<SpriteRenderer> runes; 
    public List<SpriteRenderer> runes2;
    public List<SpriteRenderer> runes3;
    private List<List<SpriteRenderer>> TempList = new List<List<SpriteRenderer>>(){
        new List<SpriteRenderer>(),
        new List<SpriteRenderer>(), // Список для горящих рун
        new List<SpriteRenderer>(),
    }; 
    public GameObject dropn;
    public bool is_enabled;

    // Обработка нажатий на кнопки pillar

    public void LeftBntClick() {
        AddRunesInTemp(runes, TempList[0]);
        AddRunesInTemp(runes2, TempList[1]);
    }
    public void RightBntClick() {
        AddRunesInTemp(runes2, TempList[1]);
        AddRunesInTemp(runes3, TempList[2]);
    }
    public void MiddleBntClick() {
        AddRunesInTemp(runes, TempList[0]);
        AddRunesInTemp(runes2, TempList[1]);
        AddRunesInTemp(runes3, TempList[2]);
    }


    // Функция добавления рун в TempList
    private void AddRunesInTemp(List<SpriteRenderer> from, List<SpriteRenderer> to) { // Добавление рун в список
        
        foreach (var r in from) {
            if (r.color.a > 0.95f) { // Если руна горит
            	if (!to.Contains(r))  { // Если в списке ее нет
            		to.Add(r); // Добавляем
            	}
        	}
    	}
    	SetOrReset(from, to);
    	
    }

    // Функция включения/выключения рун
    private void SetOrReset(List<SpriteRenderer> rns, List<SpriteRenderer> tmp) { 
        if (tmp.Count != 4) {
        	rns[tmp.Count].color = new Color(1,1,1,1); } // Изменение цвета рун по количеству горящих рун

        else { // Если горят все 4 руны 
        	foreach (var r in rns) {
        		r.color = new Color(1,1,1,0); // Выключаем все
        	}
        	tmp.Clear(); // Стираем список
        	rns[0].color = new Color(1,1,1,1); // Включаем первую

        }
        		
        }

    void Start() { // Интерфейсы
        LeftButtonClick.controllerButton = this;
        RightButtonClick.controllerButton = this;
        MiddleButtonClick.controllerButton = this;
        is_enabled = true;
    }


    void Update() {
    	
		bool j = false;
		if (is_enabled) {
			foreach(var t in TempList) { // Проверка на прохождение рун
				if (t.Count+1 == 4) {
				    j = true;
				}
	        	else {
	        		j = false;
	        		break;
	        	}
	        }
	       	if (j) { // Открытие двери
	       		Destroy(GameObject.FindWithTag("door2"));
	       		GameObject varB = Instantiate(dropn, new Vector3(-23.096f, -2.843f, 0f), Quaternion.identity);
	       		is_enabled = false;
	       	}

       }
    }
}
