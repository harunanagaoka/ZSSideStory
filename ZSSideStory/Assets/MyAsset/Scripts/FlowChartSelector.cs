using UnityEngine;
using Fungus;
using System.Collections.Generic;

public class FlowChartSelector : MonoBehaviour
{
    //Place��Chara�̑g�ݍ��킹����`���[�g��Ԃ�
    private Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart> m_flowchartDict
      = new Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart>();

    /// <summary>
    /// �f�B�N�V���i���[�Ƀt���[�`���[�g��o�^���܂�
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
    /// �Ή�����t���[�`���[�g��Ԃ��܂�
    /// </summary>
    public Flowchart GetFlowchart(PlaceData.Pattern place, CharacterData.Pattern character)
    {
        var key = (place, character);
        //�H��true�̏ꍇ�@:��false�̏ꍇ
        return m_flowchartDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }
}

//���_�@�d���ł��Ȃ�