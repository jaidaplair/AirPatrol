using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use TMP assests
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreUiText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //converty score to string
        ScoreUiText.text = score.ToString();
    }
}
