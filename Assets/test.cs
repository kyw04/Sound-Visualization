using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    const int max = 256;
    public GameObject sampleCubePrefab;
    public AudioPeer audioPeer;
    private GameObject[] sampleCube = new GameObject[max];
    public float maxScale;

    void Start()
    {
        for (int i = 0; i < max; i++)
        {
            GameObject instantiateSampleCube = Instantiate(sampleCubePrefab);
            instantiateSampleCube.transform.position = new Vector3(i, 0, 0) + transform.position;
            instantiateSampleCube.transform.parent = this.transform;
            instantiateSampleCube.name = "SampleCube" + i;
            //this.transform.eulerAngles = new Vector3(0, -360.0f / max * i, 0);
            //instantiateSampleCube.transform.position = Vector3.forward * 100;
            sampleCube[i] = instantiateSampleCube;
        }
    }

    void Update()
    {
        for (int i = 0; i < max; i++)
        {
            if (sampleCube != null)
            {
                sampleCube[i].transform.localScale = new Vector3(1, audioPeer.samples[i] * maxScale + 2, 1);
            }
        }
    }
}
