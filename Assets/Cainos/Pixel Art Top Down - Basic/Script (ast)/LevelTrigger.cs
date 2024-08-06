using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{

    // Скрипт Нижнего алтаря
    public List<SpriteRenderer> runes;
    public float lerpSpeed;
    public GameObject drcls;
    public GameObject dropn;

    private Color curColor;
    private Color targetColor;
    


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Stone")
        {
            if (GameObject.FindWithTag("DoorExit"))
            {
                Destroy(GameObject.FindWithTag("DoorExit"));
            }
            GameObject varA = Instantiate(dropn, new Vector3(1.3775f, -31.8391f, 0f), Quaternion.identity);
            varA.tag = "DoorExitOpened";
        }
        targetColor = new Color(1, 1, 1, 1);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Stone")
        {

            if (GameObject.FindWithTag("DoorExitOpened"))
            {
                Destroy(GameObject.FindWithTag("DoorExitOpened"));
            }
            GameObject varB = Instantiate(drcls, new Vector3(1.3775f, -31.8391f, 0f), Quaternion.identity);
            varB.tag = "DoorExit";
           
        }
        targetColor = new Color(1, 1, 1, 0);
    }

    private void Update()
    {
        curColor = Color.Lerp(curColor, targetColor, lerpSpeed * Time.deltaTime);

        foreach (var r in runes)
        {
            r.color = curColor;
        }
    }
}
