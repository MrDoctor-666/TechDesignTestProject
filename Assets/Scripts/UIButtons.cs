using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    public void GoToScene(int buildIndex) => SceneManager.LoadScene(buildIndex);
}
