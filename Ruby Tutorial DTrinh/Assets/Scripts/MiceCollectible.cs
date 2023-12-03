using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Copied, pasted, and modified relevant code from HealthCollectible, UIrobotCounter, and EnemyController
public class MiceCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    public Text miceCounterText;
    public static MiceCollectible instance;
    private RubyController rubyController;
    void awake()
    {
        instance = this;
    }

    void Start()
    {
        miceCounterText.text = "Mice found: 0";
    }

    void Update()
    {
        instance = this;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
        Destroy(gameObject);
        controller.PlaySound(collectedClip);
        controller.numMice = controller.numMice + 1;
        controller.ChangeMouseNum(controller.numMice);
        //rubyController.numMice = rubyController.numMice + 1;
        Debug.Log("Rubycontroller num Mice = " + controller.numMice);
        //rubyController.ChangeMouseNum(rubyController.numMice);
        }

    }

    public void updateCounter(int number)
    {
        miceCounterText.text = "Mice found: " + number.ToString();
    }
}

