using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeBlocker : MonoBehaviour
{
    [SerializeField] GameObject escapeblocker;
    private void Start()
    {
        escapeblocker.SetActive(true);
    }
    void Update()
    {
        if (dusmanhasaralma.dusmansayýsý == 0)
        {
            escapeblocker.SetActive(false);
        }
    }
}
