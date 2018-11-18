using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    public int hitCount = 0;
    private Text m_text;
    private string m_initialText;
    private void Awake()
    {
        m_text = GetComponent<Text>();
        m_initialText = m_text.text;
        m_text.text = m_initialText + " " + hitCount;
    }

    public void IncrementHitCount()
    {
        hitCount++;
        m_text.text = m_initialText + " " + hitCount;
    }

}
