using System.Collections;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;

public class Testing : MonoBehaviour
{
    private bool isRunning;

    private void Start()
    {
        // Type A
        //SlowJob();

        // Type B
        //StartCoroutine(SlowJobCoroutine());

        // Type C
        Thread myThread = new Thread(SlowJob);
        myThread.Start();        
    }

    private void Update()
    {
        if (isRunning == true)
        {
            Debug.Log("----- Calling Update -----");            
        }
    }

    // Type A, C
    private void SlowJob()
    {
        isRunning = true;
        Debug.Log("----- Doing 1000 things, each take 2ms -----");

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        sw.Start();


        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(2);
        }

        sw.Stop();

        Debug.Log("----- Done! Elapsed time: " + sw.ElapsedMilliseconds / 1000f + " -----");

        isRunning = false;
    }

    // Type B
    private IEnumerator SlowJobCoroutine()
    {
        isRunning = true;
        Debug.Log("----- Doing 1000 things, each take 2ms -----");

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        sw.Start();

        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(2);

            yield return null;
        }

        sw.Stop();

        Debug.Log("----- Done! Elapsed time: " + sw.ElapsedMilliseconds / 1000f + " -----");

        isRunning = false;
    }
}
