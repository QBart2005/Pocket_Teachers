using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptText : MonoBehaviour
{
    public int i = 1;
    public Text txt;

    void Start()
    {
        txt.text = "Welkom bij Pocket Teachers!";
    }

    // Update is called once per frame
    void Update()
    {
        while(i == 1)
        if(Input.GetButtonDown("Jump"))
        {
            txt.text = "Het doel van de game is om docenten te vangen en die tegen elkaar te laten vangen.";
            i = 1;
        }
    }
}
