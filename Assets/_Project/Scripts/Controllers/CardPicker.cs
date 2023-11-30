using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CardPicker : MonoBehaviour
{
    [SerializeField] private List<CardDisplay> options = new List<CardDisplay>();
    private void Start() {
        Debug.Log("Count: " + CardDatabase.Instance().cardList.Count);
        foreach(CardDisplay display in options) {
            display.SetCard(CardDatabase.Instance().cardList[Random.Range(0, CardDatabase.Instance().cardList.Count - 1)]);
        }
    }

    public void submit()
    {
        SceneManager.LoadScene("Map");
    }
}
