using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PersistentScriptableObject : ScriptableObject
{
   

   public void Save(string filename= null){
       var bf =new BinaryFormatter();
       var file = File.Create(gethPath(filename));
       var json=JsonUtility.ToJson(this);

       bf.Serialize(file, json);
       file.Close();
   }

    public virtual void Load(string filename= null){
        if(File.Exists(gethPath(filename)))
        {

         var bf =new BinaryFormatter();
         var file = File.Open(gethPath(filename),FileMode.Open);
         JsonUtility.FromJsonOverwrite((string)bf.Deserialize(file),this);
         file.Close();
        }
        
       
   }

   private string gethPath(string fileName= null){
       var fullFilename = string.IsNullOrEmpty(fileName) ? name :fileName;
       return string.Format("{0}/{1}.pso",Application.persistentDataPath, fullFilename);

   }
}
