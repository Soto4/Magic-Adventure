using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject fadeScreenIn;
    public GameObject charAiden;
    public GameObject charNPC;
    public GameObject textBox;
    [SerializeField] AudioSource aidentalk;
    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLength;
    [SerializeField] GameObject mainTextObject;
    [SerializeField] GameObject nextButton;
    [SerializeField] GameObject charName;
    [SerializeField] int evenPos = 0;


    void Update()
    {
        textLength = TextCreator.charCount;
    }


    // Start is called before the first     rame update
    void Start()
    {
        StartCoroutine(Evenstarter());
    }
    IEnumerator Evenstarter()
    {
        //event 1
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charAiden.SetActive(true);
        yield return new WaitForSeconds(2);
        mainTextObject.SetActive(true);
        textToSpeak = "Hei, kenapa kamu tampak sedih?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
         aidentalk.Play();
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        nextButton.SetActive(true);
        evenPos = 1;
        
    }

    IEnumerator EventOne()
    {
        nextButton.SetActive(false);
        charNPC.SetActive(true);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Wanda";
        textToSpeak = "Aku sedih karna desa kami diserang penyihir jahat";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLength == currentTextLength);
        yield return new WaitForSeconds(0.5f);
        aidentalk.Play();
        nextButton.SetActive(true);
        evenPos = 2;

        
    }

    public void NextButton()
    {
        if (evenPos == 1)
        {
            StartCoroutine(EventOne());
        }
    }

}
