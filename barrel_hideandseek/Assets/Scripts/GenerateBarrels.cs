using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBarrels : MonoBehaviour
{

    public GameObject theBarrel;
    public int xPos;
    public int zPos;
    public int barrelCount;

    void Start()
    {
        StartCoroutine(BarrelDrop());
    }

    IEnumerator BarrelDrop()
    {
        while (barrelCount < 99)
        {
            xPos = Random.Range(1, 99);
            zPos = Random.Range(1, 99);
            Instantiate(theBarrel, new Vector3(xPos, 4, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0f);
            barrelCount += 1;
        }
    }

}
