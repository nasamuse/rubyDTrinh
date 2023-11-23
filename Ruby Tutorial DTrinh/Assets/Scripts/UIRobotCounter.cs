using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIRobotCounter : MonoBehaviour
{
    public Text robotCounterText;
   
    public static UIRobotCounter instance;

    void awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        robotCounterText.text = "Robots fixed: 0";
        //robotCounterText.text = "Fixed Robots: " + numFixedRobots.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        instance = this;
        
    }
    public void updateCounter(int number)
    {
        robotCounterText.text = "Robots fixed: " + number.ToString();
    }
}
