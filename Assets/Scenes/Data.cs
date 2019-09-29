using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public static string PlayerName;
    public static int score;
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public Text showMyScore;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        showPlayerName.text = PlayerName;
    }

    public void UpdateName() 
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName); 
        showPlayerName.text = PlayerName;  
    }
    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void ShowScore()
    {
        showMyScore.text = score.ToString();
    }
}
