using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


// USAR AL FINAL
public class TypeWriterEffect : MonoBehaviour
{
    public int charPosition = 0;

    public float delay = 0.2f;
    public string fullText;

    private string currentText = "";

    public TextMeshProUGUI thisText;


    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for (charPosition = 0; charPosition < fullText.Length; charPosition++)
        {
            
            currentText = fullText.Substring(0, charPosition);
            //this.GetComponent<tEXTMESH>
            thisText.text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }

    public void ResetTypewriter()
    {
        charPosition = 0;
    }
}
