﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerationAdmin : MonoBehaviour
{
    public GameObject iaprefab;
    public int karts = 10;
    public IAInput[] iaKarts;
    public float[] bestiaturnDNA;

    void Start()
    {


        iaKarts = new IAInput[karts];
        for (int i = 0; i < karts; i++)
        {
            GameObject kart =
            Instantiate(iaprefab, transform.position, transform.rotation);
            iaKarts[i] = kart.GetComponent<IAInput>();


        }

        StartCoroutine(DNAStart());
        StartCoroutine(SaveBestAfterTime());
    }

    private IEnumerator DNAStart()
    {
        if (PlayerPrefs.HasKey("BestIA"))
        {
            bestiaturnDNA = PlayerPrefsX.GetFloatArray("BestIA");
            print("tem save");
        }
        for (int i = 0; i < karts; i++)
        {
            if (bestiaturnDNA.Length > 0)
            {
                //print("colocando o melhor");
                iaKarts[i].SetDNA(bestiaturnDNA);
            }
            else
            {

                iaKarts[i].CreateDNA();
            }
            yield return new WaitForEndOfFrame();
        }


    }


    // Update is called once per frame
    void Update()
    {
        foreach (IAInput kart in iaKarts)
        {

            if (kart.enabled != false)
            {
                return;
            }
        }

        SaveBest();
    }

    IEnumerator SaveBestAfterTime()
    {
        yield return new WaitForSeconds(90);
        SaveBest();
    }

    void SaveBest()
    {
        int bestcheckpoint = -1;
        IAInput bestcart = null;
        for (int i = 0; i < karts; i++)
        {

            if (bestcheckpoint < iaKarts[i].checkpoint)
            {
                bestcheckpoint = iaKarts[i].checkpoint;
                bestcart = iaKarts[i];
            }


        }
        if (bestcheckpoint > 0)
        {
            print("salvando melhor");
            var cubeRenderer = bestcart.gameObject.GetComponentInChildren<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
            bestiaturnDNA = bestcart.GetDNA();
            PlayerPrefsX.SetFloatArray("BestIA", bestiaturnDNA);
        }

        SceneManager.LoadScene("SampleScene");
    }

    private void OnGUI()
    {
        if (EditorApplication.isPaused)
        {
            print("pause");
        }

    }

}
