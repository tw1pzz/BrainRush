using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//when something get into the alta, make the runes glow
namespace Cainos.PixelArtTopDown_Basic
{
    // Скрипт верхнего алтаря
    public class PropsAltar : MonoBehaviour
    {
        public List<SpriteRenderer> runes;
        public float lerpSpeed;
        public GameObject drcls;
        public GameObject dropn;

        private Color curColor;
        private Color targetColor;



        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Stone") // Если объект при коллайде с тегом Stone
            {
                if (GameObject.FindWithTag("Door")) // Если на карте есть объект с тегом Door
                {
                    Destroy(GameObject.FindWithTag("Door")); // Уничтожаем его
                }
                GameObject varA = Instantiate(dropn, new Vector3(-15.856f, 3.61f, 0.84f), Quaternion.Euler(0.268f, -71.679f, 89.19f));
                varA.tag = "DoorOpened"; // Спавним открытую дверь с тегом DoorOpened
            }
            targetColor = new Color(1, 1, 1, 1);
        }

        private void OnTriggerExit2D(Collider2D other) // То же самое только наоборот (При выходе камня из зоны триггера)
        {
            if (other.tag == "Stone")
            {

                if (GameObject.FindWithTag("DoorOpened"))
                {
                    Destroy(GameObject.FindWithTag("DoorOpened"));
                }
                GameObject varB = Instantiate(drcls, new Vector3(-15.856f, 3.61f, 0.84f), Quaternion.Euler(0.268f, -71.679f, 89.19f));
                varB.tag = "Door";

            }
            targetColor = new Color(1, 1, 1, 0);
        }

        private void Update()
        { //Меняем цвет рун
            curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

            foreach (var r in runes)
            {
                r.color = curColor;
            }
        }
    }
}
