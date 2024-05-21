using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PuntajePersistente : ScriptableObject
{
    //system.io accede a nuestro disco duro
    //using System.Runtime.Serialization.Formatters.Binary; sirve para guardar en formato binario por seguridad

    // Start is called before the first frame update
    public void Guardar(string NombreArchivo = null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(ObtenerRuta(NombreArchivo));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);
        file.Close();
    }

    public virtual void Cargar(string NombreArchivo = null)
    {
        if (File.Exists(ObtenerRuta(NombreArchivo))) 
        {
            var bf = new BinaryFormatter();
            var archivo = File.Open(ObtenerRuta(NombreArchivo), FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo),this);
            archivo.Close();
        }
    }
    public string ObtenerRuta(string NombreArchivo = null)
    {
        var nomreArquivoCompleto = string.IsNullOrEmpty(NombreArchivo) ? name : NombreArchivo;
        return string.Format("{0}/{1}.ebac", Application.persistentDataPath, nomreArquivoCompleto);
    }

}
