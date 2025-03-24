using UnityEngine;
using Fungus;
using System.Collections.Generic;

public class FlowChartSelector : MonoBehaviour
{
    //PlaceとCharaの組み合わせからチャートを返す
    private Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart> m_flowchartDict
      = new Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart>();

    /// <summary>
    /// ディクショナリーにフローチャートを登録します
    /// </summary>
    public void RegisterFlowchart(PlaceData.Pattern place, CharacterData.Pattern character, Flowchart flowchart)
    {
        var key = (place, character);
        if (!m_flowchartDict.ContainsKey(key))
        {
            m_flowchartDict[key] = flowchart;
        }
    }

    /// <summary>
    /// 対応するフローチャートを返します
    /// </summary>
    public Flowchart GetFlowchart(PlaceData.Pattern place, CharacterData.Pattern character)
    {
        var key = (place, character);
        //？はtrueの場合　:はfalseの場合
        return m_flowchartDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }
}

//問題点　重複できない