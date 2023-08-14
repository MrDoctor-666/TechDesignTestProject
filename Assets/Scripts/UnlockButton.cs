using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockButton : MonoBehaviour
{
    [SerializeField] private Button button;

    private void OnMouseDown() => button.interactable = true;
}
