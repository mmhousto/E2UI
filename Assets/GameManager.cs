using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject load, rock, roll, title, loadBtn, rockBtn, rollBtn, point;
    private int points;
    public Text pointsLbl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (load.activeSelf)
        {
            if (Input.GetKeyDown("a"))
            {
                points += 5;
                pointsLbl.text = "Points: " + points;
            }
            else if (Input.GetKeyDown("s"))
            {
                points -= 1;
                pointsLbl.text = "Points: " + points;
            }
        }else if (rock.activeSelf)
        {
            if (Input.GetKeyDown("a"))
            {
                points += 10;
                pointsLbl.text = "Points: " + points;
            }
            else if (Input.GetKeyDown("s"))
            {
                points -= 50;
                pointsLbl.text = "Points: " + points;
            }
        } else if (roll.activeSelf)
        {
            if (Input.GetKeyDown("a"))
            {
                points += 1;
                pointsLbl.text = "Points: " + points;
            }
            else if (Input.GetKeyDown("s"))
            {
                points -= 2;
                pointsLbl.text = "Points: " + points;
            }
        }
        if (Input.GetKeyDown("x"))
        {
            load.SetActive(false);
            rock.SetActive(false);
            roll.SetActive(false);
            title.SetActive(true);
            points = 0;
            pointsLbl.text = "Points: " + points;
            point.SetActive(false);
            loadBtn.SetActive(true);
            rockBtn.SetActive(true);
            rollBtn.SetActive(true);

        }
    }
}
