﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class HandHider : MonoBehaviour
{
    private SkinnedMeshRenderer meshRenderer = null;
    private XRDirectInteractor interactor = null;

    void Awake()
    {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
        interactor = GetComponent<XRDirectInteractor>();

        interactor.onHoverEnter.AddListener(Hide);
        interactor.onHoverExit.AddListener(Show);
    }

    private void OnDestroy()
    {
        interactor.onHoverEnter.RemoveListener(Hide);
        interactor.onHoverExit.RemoveListener(Show);
    }

    private void Show(XRBaseInteractable interactable)
    {
        meshRenderer.enabled = true;
    }

    private void Hide(XRBaseInteractable interactable)
    {
        meshRenderer.enabled = false;
    }
}
