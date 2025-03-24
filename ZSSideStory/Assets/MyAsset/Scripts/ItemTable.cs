using UnityEngine;
using static UnityEditor.Progress;

[System.Serializable]
public class AffinityData
{
    public int affectionChange;  // 好感度変化量（例：△=5, 〇=10, ◎=15, ×=-5）
    public string comment;       // プレゼント時のコメント
}

[CreateAssetMenu(fileName = "AffinityTable", menuName = "Game/AffinityTable")]
public class AffinityTable : ScriptableObject
{
    public AffinityData[] affinityDataList;

}

