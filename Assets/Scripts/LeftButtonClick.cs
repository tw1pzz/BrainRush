using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Левая кнопка pillar

public class LeftButtonClick : MonoBehaviour {
    public static IControllerButtonPilarLeft controllerButton;
    private void OnTriggerEnter2D() {
        controllerButton.LeftBntClick();
    }
}
