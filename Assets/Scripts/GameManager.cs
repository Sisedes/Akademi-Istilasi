using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;

    public Text düþmanText; 
    
    void Update()
    {
        düþmanText.text = "X " + dusmanhasaralma.dusmansayýsý.ToString();

        if (dusmanhasaralma.dusmansayýsý == 0)
        {
            teleport.SetActive(true);
        }
    }
}
