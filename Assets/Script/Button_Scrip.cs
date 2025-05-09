using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Button_Scrip : MonoBehaviour
{
    public GameObject Setting_Panel;
    public GameObject Setting_BTN;
    public GameObject Start_BTN;
    public GameObject Exit_BTN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickPuzzleMode()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Clicked");
    }

    public void onClickEasy()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Clicked");
    }

    public void onClickNormal()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Clicked");
    }

    public void onClickHard()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Clicked");
    }

    public void onClickCreateMode()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Clicked");
    }

    public void onClickBack()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Clicked");
    }
    public void onClickSetting()
    {
        Setting_Panel.SetActive(true);
        Setting_BTN.SetActive(false);
        Start_BTN.SetActive(false);
        Exit_BTN.SetActive(false);
    }
    public void onClickCancel()
    {
        Setting_Panel.SetActive(false);
        Setting_BTN.SetActive(true);
        Start_BTN.SetActive(true);
        Exit_BTN.SetActive(true);
    }
    public void onClickExit()
    {
        Application.Quit();
    }
}
