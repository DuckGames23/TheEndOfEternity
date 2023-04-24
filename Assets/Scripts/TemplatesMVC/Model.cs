using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Model<DatabaseClass> : MonoBehaviour
{
    public DatabaseClass Database;

    protected string databasePath;

    public virtual void InitializeModel(string databaseName, DatabaseClass databaseClass)
    {
        this.databasePath = $"{Application.persistentDataPath}/Saves/{databaseName}";
        this.Database = databaseClass;
        LoadData();
    }

    public virtual void LoadData()
    {
        Debug.Log(databasePath);
        if (IsDatabaseCreated())
        {
            string jsonFormat = File.ReadAllText(databasePath);
            JsonUtility.FromJsonOverwrite(jsonFormat, this.Database);
            //for(int i = 0; i < databaseStruct.)
        }
    }

    public virtual void SaveData()
    {
        CheckDirectoryExistance();
        File.WriteAllText(databasePath, JsonUtility.ToJson(this.Database));
    }

    protected virtual void CheckDirectoryExistance()
    {
        if (!Directory.Exists($"{Application.persistentDataPath}/Saves"))
            Directory.CreateDirectory($"{Application.persistentDataPath}/Saves");
    }

    protected virtual bool IsDatabaseCreated()
    {
        return File.Exists(databasePath);
    }
}