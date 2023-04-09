using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool bittimi;
    public GameObject teleport;
    [SerializeField] Text dusmanSayisi;

    void Update()
    {
        dusmanSayisi.text = "X "+dusmanhasaralma.dusmansayýsý.ToString();
        if (dusmanhasaralma.dusmansayýsý == 0)
        {
            dusmanSayisi.text = "Kapý Açýldý";
            teleport.SetActive(true);
        }
    }
}
