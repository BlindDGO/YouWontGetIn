using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject options;
    private bool m_onOptions;
    public void StartGame()
    {
        Blackboard.m_gameType = GameType.NOTBASIC;
        SceneManager.LoadScene(FixedScenes.LVL01_SCENE);
    }
    public void ToggleOptions(bool goToOption)
    {
        mainMenu.SetActive(!goToOption);
        options.SetActive(goToOption);
        MusicManager.Instance.PlayBackgroundMusic(FixedSound.TEMITA);
        MusicManager.Instance.PlaySound(FixedSound.TEMITA);
        /*if (!m_onOptions)
        {
            mainMenu.SetActive(false);
            options.SetActive(true);
            m_onOptions = !m_onOptions;
        }
        else
        {
            mainMenu.SetActive(true);
            options.SetActive(false);
            m_onOptions = !m_onOptions;
        }*/
        PlayerPrefs.GetFloat("MusicVolume", 0.5f);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
