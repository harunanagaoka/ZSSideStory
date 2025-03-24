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
        //�z�񏉊���
        CharacterData.Pattern max = CharacterData.Pattern.Max;
        m_characterStatus = new CharacterStatus[(int)max];
        m_characterStatus = GetComponentsInChildren<CharacterStatus>();
    }

    //�L�����N�^�[�̏ꏊ�ɂ���đI������\����
    //���̃L�����̂��̃t���[�`���[�g�ɔ�΂�
    private void ooiaa()
    {//���j���[�_�C�A���O�擾�i���������֐�������j
        //�_�C�A���O�N���A
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

        //�L�����̖��O�~�ꏊ�̑I������\��������i�ЂƂ܂�enum��string�ɂ��Ă����j
        //�I�񂾂�L�����̖��O�~�ꏊ����t���[�`���[�g���擾�iOK�j
        //���AExecuteBlock��Call
        //menuDialog.AddOption("�e�L�X�g", () => {flowchart.SetStringVariable("�I����", "�U������")�Ƃ��R�[���o�b�N});
        //flowchart.ExecuteBlock("�u���b�N��");���s��
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
//Max�l�̎擾�͂̂���Init�ɂ܂Ƃ߂�
//�L�����̃����_���z�u�̌�L�����N�^�[��I�ԑI�����o������
