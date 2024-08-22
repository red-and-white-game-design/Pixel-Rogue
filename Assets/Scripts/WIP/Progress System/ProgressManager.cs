using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LevelType {
    Level,
    BossLevel,
    Event,
    Shop,
}

public enum LevelID {
    Level_1_1, Level_1_2, Level_1_3,
    Level_2_1, Level_2_2, Level_2_3,
    Level_3_1, Level_3_2, Level_3_3,
    Level_4_1, Level_4_2, 
    Level_5_1, Level_5_2, 
    Level_6_1, Level_6_2, 
    Level_7_1,
    Event_0, Event_1, Event_2, 
    Shop,
}

public class ProgressManager : MonoBehaviour {
    public static ProgressManager instance;

    public int totalStage;
    public int currentStage;
    public List<List<LevelType>> level;
    public List<List<LevelID>> levelID;
    public int totalLevel;
    public int currentLevel;

    private void InitManager() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private void Awake() {
        InitManager();
    }

    private LevelID GetRandomLevelIDFromStage(int stage) {
        List<LevelID> idList;
        switch (stage) {
            case 1:
                idList = new List<LevelID> { LevelID.Level_1_1, LevelID.Level_1_2, LevelID.Level_1_3 };
                break;
            case 2:
                idList = new List<LevelID> { LevelID.Level_2_1, LevelID.Level_2_2, LevelID.Level_2_3 };
                break;
            case 3:
                idList = new List<LevelID> { LevelID.Level_3_1, LevelID.Level_3_2, LevelID.Level_3_3 };
                break;
            case 4:
                idList = new List<LevelID> { LevelID.Level_4_1, LevelID.Level_4_2 };
                break;
            case 5:
                idList = new List<LevelID> { LevelID.Level_5_1, LevelID.Level_5_2 };
                break;
            case 6:
                idList = new List<LevelID> { LevelID.Level_6_1, LevelID.Level_6_2 };
                break;
            case 7:
                idList = new List<LevelID> { LevelID.Level_7_1 };
                break;
            default:
                idList = new();
                break;
        }
        return idList[Random.Range(0, idList.Count)];
    }

    private List<LevelID> GetRandomLevelIDFromStage(int stage, int count) {
        List<LevelID> idList;
        switch (stage) {
            case 1:
                idList = new List<LevelID> { LevelID.Level_1_1, LevelID.Level_1_2, LevelID.Level_1_3 };
                break;
            case 2:
                idList = new List<LevelID> { LevelID.Level_2_1, LevelID.Level_2_2, LevelID.Level_2_3 };
                break;
            case 3:
                idList = new List<LevelID> { LevelID.Level_3_1, LevelID.Level_3_2, LevelID.Level_3_3 };
                break;
            case 4:
                idList = new List<LevelID> { LevelID.Level_4_1, LevelID.Level_4_2 };
                break;
            case 5:
                idList = new List<LevelID> { LevelID.Level_5_1, LevelID.Level_5_2 };
                break;
            case 6:
                idList = new List<LevelID> { LevelID.Level_6_1, LevelID.Level_6_2 };
                break;
            case 7:
                idList = new List<LevelID> { LevelID.Level_7_1 };
                break;
            default:
                idList = new();
                break;
        }
        List<LevelID> ret = new();
        for (int i = 0; i < count; i++) {
            var id = Random.Range(0, idList.Count);
            ret.Add(idList[id]);
            idList.Remove(idList[id]);
        }
        return ret;
    }

    private LevelID GetRandomEventID() {
        List<LevelID> idList = new() { LevelID.Event_0, LevelID.Event_1, LevelID.Event_2 };
        return idList[Random.Range(0, idList.Count)];
    }

    public void Init() {
        if ((int)DifficultyManager.instance.difficulty < 1) {
            var stage1 = new List<LevelType> { LevelType.Level, LevelType.Event, LevelType.Shop};
            var stage2 = new List<LevelType> { LevelType.Level, LevelType.Event, LevelType.Shop};
            var stage3 = new List<LevelType> { LevelType.Level, LevelType.Event, LevelType.Shop};
            var stage4 = new List<LevelType> { LevelType.BossLevel, LevelType.Event, LevelType.Shop};
            var stage5 = new List<LevelType> { LevelType.Level, LevelType.Event, LevelType.Shop};
            var stage6 = new List<LevelType> { LevelType.Level, LevelType.Event, LevelType.Shop};
            var stage7 = new List<LevelType> { LevelType.BossLevel };
            level = new List<List<LevelType>> { stage1, stage2, stage3, stage4, stage5, stage6, stage7 };
            var stage1id = new List<LevelID> { GetRandomLevelIDFromStage(1), GetRandomEventID(), LevelID.Shop };
            var stage2id = new List<LevelID> { GetRandomLevelIDFromStage(2), GetRandomEventID(), LevelID.Shop };
            var stage3id = new List<LevelID> { GetRandomLevelIDFromStage(3), GetRandomEventID(), LevelID.Shop };
            var stage4id = new List<LevelID> { GetRandomLevelIDFromStage(4), GetRandomEventID(), LevelID.Shop };
            var stage5id = new List<LevelID> { GetRandomLevelIDFromStage(5), GetRandomEventID(), LevelID.Shop };
            var stage6id = new List<LevelID> { GetRandomLevelIDFromStage(6), GetRandomEventID(), LevelID.Shop };
            var stage7id = new List<LevelID> { GetRandomLevelIDFromStage(7 )};
            levelID = new List<List<LevelID>> { stage1id, stage2id, stage3id, stage4id, stage5id, stage6id, stage7id };
        } else {
            var stage1 = new List<LevelType> { LevelType.Level, LevelType.Level, LevelType.Event, LevelType.Shop };
            var stage2 = new List<LevelType> { LevelType.Level, LevelType.Level, LevelType.Event, LevelType.Shop };
            var stage3 = new List<LevelType> { LevelType.Level, LevelType.Level, LevelType.Event, LevelType.Shop };
            var stage4 = new List<LevelType> { LevelType.BossLevel, LevelType.Event, LevelType.Shop };
            var stage5 = new List<LevelType> { LevelType.Level, LevelType.Level, LevelType.Event, LevelType.Shop };
            var stage6 = new List<LevelType> { LevelType.Level, LevelType.Level, LevelType.Event, LevelType.Shop };
            var stage7 = new List<LevelType> { LevelType.BossLevel };
            level = new List<List<LevelType>> { stage1, stage2, stage3, stage4, stage5, stage6, stage7 };
            var stage1id = GetRandomLevelIDFromStage(1, 2);
            stage1id.AddRange(new List<LevelID> { GetRandomEventID(), LevelID.Shop });
            var stage2id = GetRandomLevelIDFromStage(2, 2);
            stage1id.AddRange(new List<LevelID> { GetRandomEventID(), LevelID.Shop });
            var stage3id = GetRandomLevelIDFromStage(3, 2);
            stage1id.AddRange(new List<LevelID> { GetRandomEventID(), LevelID.Shop });
            var stage4id = new List<LevelID> { GetRandomLevelIDFromStage(4), GetRandomEventID(), LevelID.Shop };
            var stage5id = GetRandomLevelIDFromStage(5, 2);
            stage1id.AddRange(new List<LevelID> { GetRandomEventID(), LevelID.Shop });
            var stage6id = GetRandomLevelIDFromStage(6, 2);
            stage1id.AddRange(new List<LevelID> { GetRandomEventID(), LevelID.Shop });
            var stage7id = new List<LevelID> { GetRandomLevelIDFromStage(7) };
            levelID = new List<List<LevelID>> { stage1id, stage2id, stage3id, stage4id, stage5id, stage6id, stage7id };
        }
    }
}
