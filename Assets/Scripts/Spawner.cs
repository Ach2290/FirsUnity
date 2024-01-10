using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime;
    public GameObject objToSpawn;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            //El tiempo ha pasado
           currentTime = 0;

            // con getComponent cogemos el color y lo cambiamos utilizandoun random
           GameObject obj = Instantiate(objToSpawn, transform.position, Quaternion.identity);
            //obj.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        }
       
    }

}
