using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardPicker : MonoBehaviour
{
    public void submit()
    {
        SceneManager.LoadScene("Map");
    }
}
