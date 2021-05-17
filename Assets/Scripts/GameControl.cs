using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public int point;
    public Text P;
    public Button reset;
    public Text P2;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
        panel.SetActive(false);
    }
    public void count()
    {
        point++;
    }
    // Update is called once per frame
    void Update()
    {
        P.text = "Point: " + point.ToString();
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        P2.text = "Your Point : "+ point.ToString();

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
