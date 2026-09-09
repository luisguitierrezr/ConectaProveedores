using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FileStructRecord
public class RESTRC_44242c40a1e3a9d6bd98185caff1a7b9 : AbstractRESTStructure<RC_44242c40a1e3a9d6bd98185caff1a7b9> {
[JsonProperty("FileStruct")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure AttrFileStruct;

public RESTRC_44242c40a1e3a9d6bd98185caff1a7b9() { }

public RESTRC_44242c40a1e3a9d6bd98185caff1a7b9 (RC_44242c40a1e3a9d6bd98185caff1a7b9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFileStruct = ConvertToRestWithoutDefaults(s.ssSTFileStruct, new ST_a158c76eb93396680623c04244f48b6cStructure(), ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.FromStructure, config);
  } else {
AttrFileStruct = ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.FromStructure(s.ssSTFileStruct, config);
  }
}

public static RC_44242c40a1e3a9d6bd98185caff1a7b9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_44242c40a1e3a9d6bd98185caff1a7b9 obj) { 
  RC_44242c40a1e3a9d6bd98185caff1a7b9 s = new RC_44242c40a1e3a9d6bd98185caff1a7b9();
  if(obj != null) {
  s.ssSTFileStruct = ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.ToStructure(obj.AttrFileStruct);
  }
  return s;
}

public static Func<RC_44242c40a1e3a9d6bd98185caff1a7b9, ssConectaProveedores.RestRecords.RESTRC_44242c40a1e3a9d6bd98185caff1a7b9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_44242c40a1e3a9d6bd98185caff1a7b9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_44242c40a1e3a9d6bd98185caff1a7b9 FromStructure(RC_44242c40a1e3a9d6bd98185caff1a7b9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_44242c40a1e3a9d6bd98185caff1a7b9(s, config);
}

}


