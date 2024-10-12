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

    // Start is called before the first     rame update
    void Start()
    {
        StartCoroutine(Evenstarter());
    }
    IEnumerator Evenstarter()
    {
        yield return new WaitForSeconds(2);
        fadeScreenIn.SetActive(false);
        charAiden.SetActive(true);
        yield return new WaitForSeconds(2);
        textBox.SetActive(true);
        yield return new WaitForSeconds(2);
        charNPC.SetActive(true);
    }

}
