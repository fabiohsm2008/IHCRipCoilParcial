using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    public bool target = false;
    public bool CenterTarget = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (target)
        {
            GameObject the_text = GameObject.Find("score");
            CurrentScore aja = the_text.GetComponent<CurrentScore>();
            if (CenterTarget)
            {
                aja.SetCurrentScore(aja.actual * 2);
            }
            else
            {
                aja.SetCurrentScore(aja.actual * 3);
            }
            aja.UpdateText();

        }
        else
        {
            GameObject the_text = GameObject.Find("score");
            CurrentScore aja = the_text.GetComponent<CurrentScore>();
            aja.SetCurrentScore(aja.actual * 2);
        }
    }
}
