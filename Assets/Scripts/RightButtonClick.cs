using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// Правая кнопка pillar

public class RightButtonClick : MonoBehaviour {
    public static IControllerButtonPilarRight controllerButton;
    private void OnTriggerEnter2D() {
        controllerButton.RightBntClick();
    }
}


