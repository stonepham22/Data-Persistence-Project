using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private string _playerName;
    public string PlayerName => _playerName;
    public InputField nameInputField;

    private static GameManager _instance;
    public static GameManager Instance => _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SubmitName()
    {
        _playerName = nameInputField.text;  
        Debug.Log("Player Name: " + _playerName);
    }

    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else    
        Application.Quit();
#endif
    }
}
