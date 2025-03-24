using UnityEngine;
using static UnityEditor.Progress;

[System.Serializable]
public class AffinityData
{
    public int affectionChange;  // �D���x�ω��ʁi��F��=5, �Z=10, ��=15, �~=-5�j
    public string comment;       // �v���[���g���̃R�����g
}

[CreateAssetMenu(fileName = "AffinityTable", menuName = "Game/AffinityTable")]
public class AffinityTable : ScriptableObject
{
    public AffinityData[] affinityDataList;

}

