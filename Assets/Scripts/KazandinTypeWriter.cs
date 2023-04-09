using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KazandinTypeWriter : MonoBehaviour
{
    public float delay;

    [Multiline]
    public string text;

    Text thisText;

    private void Start()
    {
        thisText = GetComponent<Text>();

        StartCoroutine(KazandinTypeWrite());
    }

    IEnumerator KazandinTypeWrite()
    {
        foreach(char i in text)
        {
            thisText.text+= i.ToString();

            /*if(i.ToString() == ".")
            {
                yield return new WaitForSeconds(1);
            }
            else
            {
                yield return new WaitForSeconds(delay);
            }*/

            yield return new WaitForSeconds(delay);
        }
    }
}
