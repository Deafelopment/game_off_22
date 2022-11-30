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
        while (barrelCount < 10)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 50);
            Instantiate(theBarrel, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            barrelCount += 1;
        }
    }

}
