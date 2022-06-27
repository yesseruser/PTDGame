using UnityEngine;

[CreateAssetMenu(menuName = "Unit/Profile")]
public class UnitProfile : ScriptableObject
{
    public int unitID;
    public string nickname;
    public AttackID attack1ID;
    public AttackID attack2ID;
    public AttackID attack3ID;
    public AttackID attack4ID;
    public int attackSelected;
    public int lvl;
    public int exp;
    public int special;
    public int baseHP;
    public float baseSpeed;
    //Will unit leave the level after reaching the end of the path
    public bool freeRoam;
    // Can the unit capture candy
    public bool canCaptureCandy;

    public bool nonDamagingAttackOnly;

    public static string GetUnitGfxName(int unitID) {
        var name = "";
        switch(unitID) {
            case 20:
                name = "u0020_rat";
                break;
            default:
                name = "u0001_frog";
                break;
        }
        return name;
    }
}
