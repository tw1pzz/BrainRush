using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// Средняя кнопка pillar

public class MiddleButtonClick : MonoBehaviour {
    public static IControllerButtonPilarMiddle controllerButton;
    private void OnTriggerEnter2D() {
        controllerButton.MiddleBntClick();
    }
}


