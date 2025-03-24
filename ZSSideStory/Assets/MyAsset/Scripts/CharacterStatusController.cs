using Fungus;
using UnityEngine;

public class CharacterStatusController : MonoBehaviour
{
    [SerializeField]
    FlowChartSelector m_selector = null;

    private CharacterStatus[] m_characterStatus;

    private void Start()
    {
        GetCharacterStatus();
    }
    
    private void GetCharacterStatus()
    {
        //配列初期化
        CharacterData.Pattern max = CharacterData.Pattern.Max;
        m_characterStatus = new CharacterStatus[(int)max];
        m_characterStatus = GetComponentsInChildren<CharacterStatus>();
    }

    //キャラクターの場所によって選択肢を表示し
    //そのキャラのそのフローチャートに飛ばす
    private void ooiaa()
    {//メニューダイアログ取得（そういう関数がある）
        //ダイアログクリア
        var menuDialog = MenuDialog.GetMenuDialog();
        menuDialog.enabled = true;
        menuDialog.Clear();

        for (int i = 0; i < m_characterStatus.Length; i++)
        {
            int placeNum = (int)m_characterStatus[i].PlaceNum;
            PlaceData.Pattern place = (PlaceData.Pattern)placeNum;
            CharacterData.Pattern name = (CharacterData.Pattern)i;

            Flowchart targetChart = m_selector.GetFlowchart(place, name);
           // menuDialog.AddOption(name.ToString(),() => { targetChart.ExecuteBlock("Enter"); });

        }

        //キャラの名前×場所の選択肢を表示させる（ひとまずenumをstringにしておく）
        //選んだらキャラの名前×場所からフローチャートを取得（OK）
        //し、ExecuteBlockでCall
        //menuDialog.AddOption("テキスト", () => {flowchart.SetStringVariable("選択肢", "攻撃する")とかコールバック});
        //flowchart.ExecuteBlock("ブロック名");を行う
    }

    private void PlaceCharacterRandomly()
    {
        PlaceData.Pattern max = PlaceData.Pattern.Max;

        foreach (var status in m_characterStatus)
        {
            status.SetRandomPlaceNum((int)max);
        }
    }
}
//Max値の取得はのちにInitにまとめる
//キャラのランダム配置の後キャラクターを選ぶ選択肢出したい
