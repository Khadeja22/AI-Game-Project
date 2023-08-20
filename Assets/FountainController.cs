using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FountainController : MonoBehaviour
{
    private Animator fountainAnimator;

    private void Start()
    {
        fountainAnimator = GetComponent<Animator>();
    }

    public void StartFlowAnimation()
    {
        fountainAnimator.SetTrigger("StartFlow");
    }

    public void StopFlowAnimation()
    {
        fountainAnimator.SetTrigger("StopFlow");
    }
}
