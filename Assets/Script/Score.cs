using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   public int  score=0;
   public Text txtscore;
   public static Score instance;
    public Button btnre;
    public GameObject gameover;
    public GameObject replaybtn;
    public GameObject menubtn;
    public Button btnmenu;

    public Score(int score,Text txtscore)
    {
        this.score = score;
        this.txtscore = txtscore;
    }
    private void Awake()
    {
        gameover.SetActive(false);
        replaybtn.SetActive(false);
        menubtn.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
    }
   public void GameOver()
    {
        Time.timeScale = 0;
        gameover.SetActive(true);
        replaybtn.SetActive(true);
        menubtn.SetActive(true);
        btnre = replaybtn.GetComponent<Button>();
        btnmenu = menubtn.GetComponent<Button>();
        btnre.onClick.AddListener(ReplayScence);
        btnmenu.onClick.AddListener(Menu);
    }
    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    void ReplayScence()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
   public void CountScore()
    {
        score++;
        txtscore.text = score.ToString();
    }
   
}
