using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Incrementer : MonoBehaviour
{
    [SerializeField] private int value = 0;
    [SerializeField] private Text text;

    public void Increment()
    {
        value++;
        text.text = value.ToString();
    }
}
