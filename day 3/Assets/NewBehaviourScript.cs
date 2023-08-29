using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public Text scoretext;
    public int score  = 0;

    int inc = 1;
    public Text inctext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clicker()
    {

        score += inc;
        scoretext.text=score.ToString();
    }
    public void shop ()
    {
     
        if (score > 10)
        
        {
            score -= 10;
            inc += 1;

            scoretext.text = score.ToString();
            inctext.text = "increase = "+ inc ;
        }





    }


}
