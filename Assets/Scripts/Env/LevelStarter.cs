using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource startFX;

    void Start()
    {
        StartCoroutine(countSequence());
    }

    IEnumerator countSequence(){
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.5f);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.5f);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1.5f);
        countDownGo.SetActive(true);
        startFX.Play();
    }
}
