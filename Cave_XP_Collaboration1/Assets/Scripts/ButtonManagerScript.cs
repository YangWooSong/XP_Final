using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject optionMenu;
    public GameObject exitMenu;

    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Scene1_ControllRoom");
        GameManangerScript.timeGo=true;
    }
    public void OptionButton()
    {
        startMenu.SetActive(false);
        optionMenu.SetActive(true);
        exitMenu.SetActive(false);
    }
    public void ExitButton()
    {
        startMenu.SetActive(false);
        optionMenu.SetActive(false);
        exitMenu.SetActive(true);
    }
    public void OptionBackButton()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }
    public void ExitGoButton()
    {
       // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit(); 
    }
    public void ExitBackButton()
    {
        startMenu.SetActive(true);
        optionMenu.SetActive(false);
        exitMenu.SetActive(false);
    }

    public void GoToTitleScene()
    {
        SceneManager.LoadScene("Scene0_Title");
        GameManangerScript.timeGo = false;
    }

    public void GoToAnagramScene()
    {
        SceneManager.LoadScene("Mini3_AnagramGame");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = false;
    }
    public void GoToMemoryScene()
    {
        SceneManager.LoadScene("Mini2_MemoryGame");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = false;
    }

    public void GoToWireScene()
    {
        SceneManager.LoadScene("Mini1_WireGame");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = false;
    }

    public void GoToGameTestScene()
    {
        SceneManager.LoadScene("GameTestScene");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = true;
    }

    public void GoToControl()
    {
        SceneManager.LoadScene("Scene1_ControllRoom");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = true;
    }
    public void GoToSetting()
    {
        SceneManager.LoadScene("Scene2_SettingRoom");  //�ٸ� Scene���� �Ѿ��
        GameManangerScript.timeGo = true;
    }


}
