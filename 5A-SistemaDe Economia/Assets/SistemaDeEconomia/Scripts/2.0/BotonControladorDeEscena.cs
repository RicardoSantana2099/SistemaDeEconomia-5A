using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonControladorDeEscena : MonoBehaviour
{
    enum TargetScene
    {
        Next, 
        Previous, 
        MainMenu
    }

    [SerializeField] TargetScene targetScene;
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.RemoveAllListeners();
        switch(targetScene)
        {
            case TargetScene.MainMenu:
                button.onClick.AddListener(() => ControladorDeEscena.LoadMainScene());
                break;

            case TargetScene.Next:
                button.onClick.AddListener(() => ControladorDeEscena.LoadNextScene());
                break;

            case TargetScene.Previous:
                button.onClick.AddListener(() => ControladorDeEscena.LoadPreviousScene());
                break;
        }
    }
}
