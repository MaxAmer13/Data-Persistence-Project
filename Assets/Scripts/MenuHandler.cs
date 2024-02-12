using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class MenuHandler : MonoBehaviour
{
    public TextMeshProUGUI titleText;

    private void Start()
    {
        GameHandler.instance.LoadElement();
        titleText.text = "Best Score : " + GameHandler.instance.player + " : " + GameHandler.instance.score;
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        EditorApplication.ExitPlaymode();
    }

    public void EnterName(string name)
    {
        GameHandler.instance.player = name;
        
    }

    public void EnterLead()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }
}
