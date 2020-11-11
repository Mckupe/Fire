using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Sick : MonoBehaviour
{
    public Material[] materials;
    public Material material;
    private bool flag = false;
    private double timeStep = 2.0;
    private DateTime sickSturtTime;
    private float r=0;
    private float g =255.0f;
    private float b =0;


    void D()
    {
        if (gameObject.tag == "Sick")
        {
            if (r < 100.0f)
            {
                r = r + 1f;
                gameObject.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
                Debug.Log(gameObject.GetComponent<MeshRenderer>().material.color.g);
            }
            else if (g > 0.0f)
            {
                g = g - 1f;
                gameObject.GetComponent<MeshRenderer>().material.color = new Color(r, g, b);
                Debug.Log(gameObject.GetComponent<MeshRenderer>().material.color.g);
            }
            
            //if (!flag)
            //{
            //    sickSturtTime = DateTime.Now;
            //    flag = true;
            //    gameObject.GetComponent<MeshRenderer>().material = material[0];
            //}
            //else if ((DateTime.Now - sickSturtTime).TotalSeconds > 4 * timeStep)
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = material[4];
            //    gameObject.tag = "Dead";
            //}
            //else if ((DateTime.Now - sickSturtTime).TotalSeconds > 3 * timeStep)
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = material[3];
            //}
            //else if ((DateTime.Now - sickSturtTime).TotalSeconds > 2 * timeStep)
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = material[2];
            //    float distanceBetweenSpheres = 10f;
            //    var sickCenters = gameObject.transform.position;
            //    Collider[] neighbors = Physics.OverlapSphere(sickCenters, distanceBetweenSpheres);
            //    foreach (var neighbor in neighbors)
            //    {
            //        if (neighbor.gameObject.tag == "Healthy")
            //        {
            //            neighbor.gameObject.tag = "Sick";
            //        }
            //    }
            //}
            //else if ((DateTime.Now - sickSturtTime).TotalSeconds > 1 * timeStep)
            //{
            //    gameObject.GetComponent<MeshRenderer>().material = material[1];
            //}
        }
    }

    void Start()
    {
        var rnd = new System.Random();
        var e = rnd.Next(0, SphereGenerator.listSpheres.Count);
        SphereGenerator.listSpheres[e].tag = "Sick";
    }

    void Update()
    {
        D();
    }
}   
