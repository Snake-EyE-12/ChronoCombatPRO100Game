using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public TMP_Text text;
    public int max;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //IncrementProgress(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ((int)(max * slider.value)).ToString() + "/" + ((int)max).ToString();
    }

    public void SetProgress(float newProgrss, int max)
    {
        this.max = max;
        float temp = newProgrss / max;
        slider.value = temp;
    }
}
