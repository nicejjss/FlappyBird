using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button playbtn;
    public Button quitbtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        playbtn.onClick.AddListener(Play);
        quitbtn.onClick.AddListener(Quit);
    }
    void Play()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    private void Quit()
    {
        Application.Quit();
    }
}
