using UnityEngine;
using Fungus;
using System.Collections.Generic;

public class FlowChartSelector : MonoBehaviour
{
    //Charaに応じてチャートを返す
    private Dictionary<CharacterData.Pattern, Flowchart> m_greetingDict
      = new Dictionary<CharacterData.Pattern, Flowchart>();

    //PlaceとCharaの組み合わせからチャートを返す
    private Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart> m_placeDict
      = new Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart>();

    /// <summary>
    /// ディクショナリーにキャラクターのフローチャートを登録します
    /// </summary>
    public void RegistGreetingChart(CharacterData.Pattern character,Flowchart flowchart)
    {
        var key = (character);
        if (!m_greetingDict.ContainsKey(key))
        {
            m_greetingDict[key] = flowchart;
        }
    }

    /// <summary>
    /// ディクショナリーにキャラクター×場所のフローチャートを登録します
    /// </summary>
    public void RegisterPlacechart(PlaceData.Pattern place, CharacterData.Pattern character, Flowchart flowchart)
    {
        var key = (place, character);
        if (!m_placeDict.ContainsKey(key))
        {
            m_placeDict[key] = flowchart;
        }
    }

    public Flowchart GetFlowchart(CharacterData.Pattern character)
    {
        var key = (character);
        //？はtrueの場合　:はfalseの場合
        return m_greetingDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }

    /// <summary>
    /// キャラの名前と場所に応じて対応するフローチャートを返します
    /// </summary>
    public Flowchart GetFlowchart( CharacterData.Pattern character, PlaceData.Pattern place)
    {
        var key = (place, character);
        //？はtrueの場合　:はfalseの場合
        return m_placeDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }
}

//問題点　重複できない