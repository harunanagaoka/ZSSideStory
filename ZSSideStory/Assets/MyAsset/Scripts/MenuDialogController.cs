using Fungus;
using UnityEngine;

public class MenuDialogController : MonoBehaviour
{
    [SerializeField]
    FlowChartSelector m_flowChartSelector = null;

    [SerializeField]
    CharacterStatusController m_charaStateController = null;

    private CharacterStatus[] m_characterStatus = new CharacterStatus[(int)CharacterData.Pattern.Max];

    private MenuDialog m_menuDialog = null;

    private string m_firstBlockName = "Enter";

    private Block m_placeBlock = null;

    private Flowchart m_kari = null;

    void Start()
    {
        m_menuDialog = MenuDialog.GetMenuDialog();
        m_menuDialog.enabled = false;

        m_characterStatus = m_charaStateController.CharacterStatuses;
    }

    /// <summary>
    /// どのキャラクターと交流するかの選択肢を表示させます。
    /// </summary>
    private void MakeExchangeMenuDialog()
    {
        m_menuDialog.enabled = true;
        m_menuDialog.Clear();

        for (int i = 0; i < m_characterStatus.Length; i++)
        {
            int placeNum = (int)m_characterStatus[i].PlaceNum;
            PlaceData.Pattern place = (PlaceData.Pattern)placeNum;
            CharacterData.Pattern name = (CharacterData.Pattern)i;

            //選択肢「名前+場所」を表示、選択したらキャラクターのチャートへ飛ぶ
            Flowchart greetingChart = m_flowChartSelector.GetFlowchart(name);
            m_kari = greetingChart;
            m_menuDialog.AddOption(name.ToString() + " in " + place.ToString(),
                                 true, false, greetingChart.FindBlock("Enter"));
        }
    }

    //現在選択中のキャラと場所を自動で選べるように改修予定
    private void CallPlaceChart()
    {
        Flowchart placeChart = m_flowChartSelector.GetFlowchart(CharacterData.Pattern.Memeshino_Toka,PlaceData.Pattern.ClassRoom);
        m_kari.StopAllBlocks();
        placeChart.ExecuteIfHasBlock("Enter");
    }
}
