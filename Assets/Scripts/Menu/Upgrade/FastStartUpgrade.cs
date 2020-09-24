using UnityEngine;
using System.Collections;

public class FastStartUpgrade : MonoBehaviour {

    public int LevelVersion = GameSateData.I.myData.manage.FastStartUpgradeLevel;
    public int UpgradeWantCoin = 800;
    UILabel LevelLabel = null;
    UILabel UpgradeInformation = null;
    UILabel WantCoin = null;
    UISprite UpgradeTarget = null;
	
	void Start () {
        LevelLabel = GameObject.Find("LevelLabel").GetComponent<UILabel>();
        WantCoin = GameObject.Find("WantCoin").GetComponent<UILabel>();
        UpgradeInformation = GameObject.Find("UpgradeInformation").GetComponent<UILabel>();
        UpgradeTarget = GameObject.Find("UpgradeTarget").GetComponent<UISprite>();
	}
	
	// Update is called once per frame
	void Update () {
        if (UpgradeTarget.spriteName == "Fast Start")
        {
            LevelLabel.text = "���� : " + LevelVersion.ToString();
        }
	}

    void OnClick()
    {
        UpgradeInformation.text = "�����ϸ� ������\n" + "���¿��� �����ð�\n ���ӵ˴ϴ�.";
        UpgradeTarget.spriteName = "Fast Start";
        WantCoin.text = "800";
    }
}
