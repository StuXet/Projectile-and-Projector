using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject[] childObjects;
    public float delay = 1.0f;
    private int currentIndex = 0;

    void Start()
    {
        StartCoroutine(ActivateChildObjectsCoroutine());
    }

    IEnumerator ActivateChildObjectsCoroutine()
    {
        while (currentIndex < childObjects.Length)
        {
            childObjects[currentIndex].SetActive(true);
            yield return new WaitForSeconds(delay);

            childObjects[currentIndex].SetActive(false);
            currentIndex++;
        }
    }
}
