using Fungus;
using System.Linq;
using UnityEngine;

public class CharacterStatusController : MonoBehaviour
{

    [SerializeField]
    private bool m_isDebugMode = false;

    private CharacterStatus[] m_characterStatus;

    public CharacterStatus[] CharacterStatuses { get { return m_characterStatus; } }

    private void Awake()
    {
        GetCharacterStatus();
    }
    
    /// <summary>
    /// �ʂ̃L�����N�^�[�̃X�e�[�^�X���擾���܂��B
    /// </summary>
    private void GetCharacterStatus()
    {
        //�z�񏉊���
        CharacterData.Pattern max = CharacterData.Pattern.Max;
        m_characterStatus = new CharacterStatus[(int)max];
        m_characterStatus = GetComponentsInChildren<CharacterStatus>();
    }

    /// <summary>
    /// �L�����N�^�[�������_���ȏꏊ�ɔz�u���܂�
    /// </summary>
    private void PlaceCharacterRandomly()
    {
        if(m_isDebugMode)
        {
            foreach (var status in m_characterStatus)
            {
                status.SetRandomPlaceNum(0);
            }
            return;
        }

        PlaceData.Pattern max = PlaceData.Pattern.Max;

        foreach (var status in m_characterStatus)
        {
            status.SetRandomPlaceNum((int)max);
        }
    }

    private void SetRandomGreeting()
    {
        Block activeBlock = FindObjectsOfType<Block>().FirstOrDefault(b => b.IsExecuting());
        Flowchart flowchart = activeBlock.GetFlowchart();
        flowchart.SetIntegerVariable("Choice", Random.Range(0, 3));
    }
}
//Max�l�̎擾�͂̂���Init�ɂ܂Ƃ߂�
//�L�����̃����_���z�u�̌�L�����N�^�[��I�ԑI�����o������
