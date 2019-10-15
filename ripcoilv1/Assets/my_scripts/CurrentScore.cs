using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentScore : MonoBehaviour
{
    public int actual = 1;
    public int score = 0;
    public TextMesh thetext;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetCurrentScore(int x)
    {
        actual = x;
    }
    public void RefreshCurrentScore()
    {
        actual = 0;
    }
    public void UpdateText()
    {
        thetext.text = "Puntaje: " + (score + actual).ToString();
    }
}
