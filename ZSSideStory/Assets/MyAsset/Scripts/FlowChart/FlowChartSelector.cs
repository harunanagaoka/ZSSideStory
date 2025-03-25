using UnityEngine;
using Fungus;
using System.Collections.Generic;

public class FlowChartSelector : MonoBehaviour
{
    //Chara�ɉ����ă`���[�g��Ԃ�
    private Dictionary<CharacterData.Pattern, Flowchart> m_greetingDict
      = new Dictionary<CharacterData.Pattern, Flowchart>();

    //Place��Chara�̑g�ݍ��킹����`���[�g��Ԃ�
    private Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart> m_placeDict
      = new Dictionary<(PlaceData.Pattern, CharacterData.Pattern), Flowchart>();

    /// <summary>
    /// �f�B�N�V���i���[�ɃL�����N�^�[�̃t���[�`���[�g��o�^���܂�
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
    /// �f�B�N�V���i���[�ɃL�����N�^�[�~�ꏊ�̃t���[�`���[�g��o�^���܂�
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
        //�H��true�̏ꍇ�@:��false�̏ꍇ
        return m_greetingDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }

    /// <summary>
    /// �L�����̖��O�Əꏊ�ɉ����đΉ�����t���[�`���[�g��Ԃ��܂�
    /// </summary>
    public Flowchart GetFlowchart( CharacterData.Pattern character, PlaceData.Pattern place)
    {
        var key = (place, character);
        //�H��true�̏ꍇ�@:��false�̏ꍇ
        return m_placeDict.TryGetValue(key, out Flowchart flowchart) ? flowchart : null;
    }
}

//���_�@�d���ł��Ȃ�