using UnityEngine;
using System.Collections;

public class ScoreLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (transform.name == "Ranked_list_Label_1")
        {
            transform.GetComponent<UILabel>().text = "1�� : " + GameSateData.I.myData.manage.rank_1.ToString() + " ��";
        }
        else if (transform.name == "Ranked_list_Label_2")
        {
            transform.GetComponent<UILabel>().text = "2�� : " + GameSateData.I.myData.manage.rank_2.ToString() + " ��";
        }
        else if (transform.name == "Ranked_list_Label_3")
        {
            transform.GetComponent<UILabel>().text = "3�� : " + GameSateData.I.myData.manage.rank_3.ToString() + " ��";
        }
        else if (transform.name == "Ranked_list_Label_4")
        {
            transform.GetComponent<UILabel>().text = "4�� : " + GameSateData.I.myData.manage.rank_4.ToString() + " ��";
        }
        else if (transform.name == "Ranked_list_Label_5")
        {
            transform.GetComponent<UILabel>().text = "5�� : " + GameSateData.I.myData.manage.rank_5.ToString() + " ��";
        }
	}
}
