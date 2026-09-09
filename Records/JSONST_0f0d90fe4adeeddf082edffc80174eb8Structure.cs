using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_GL_ACC_GETDETAILResp
public class JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure : AbstractRESTStructure<ST_0f0d90fe4adeeddf082edffc80174eb8Structure> {
[JsonProperty("ACCOUNT_DETAIL")]
[JsonPropertyName("ACCOUNT_DETAIL")]
public ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure AttrACCOUNT_DETAIL;

[JsonProperty("RETURN")]
[JsonPropertyName("RETURN")]
public ssConectaProveedores.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure AttrRETURN;

public JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure() { }

public JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure (ST_0f0d90fe4adeeddf082edffc80174eb8Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrACCOUNT_DETAIL = ConvertToRestWithoutDefaults(s.ssACCOUNT_DETAIL, new ST_d2beaf811f074c88054765b10d929011Structure(), ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.FromStructure, config);
AttrRETURN = ConvertToRestWithoutDefaults(s.ssRETURN, new ST_e5256660414a7d3dddc63b7cbdd21e9cStructure(), ssConectaProveedores.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure, config);
  } else {
AttrACCOUNT_DETAIL = ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.FromStructure(s.ssACCOUNT_DETAIL, config);
AttrRETURN = ssConectaProveedores.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.FromStructure(s.ssRETURN, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure, ST_0f0d90fe4adeeddf082edffc80174eb8Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure s) => ToStructure(s, config);
}
public static ST_0f0d90fe4adeeddf082edffc80174eb8Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure obj, IBehaviorsConfiguration config) { 
  ST_0f0d90fe4adeeddf082edffc80174eb8Structure s = new ST_0f0d90fe4adeeddf082edffc80174eb8Structure();
  if(obj != null) {
  s.ssACCOUNT_DETAIL = ssConectaProveedores.RestRecords.JSONST_d2beaf811f074c88054765b10d929011Structure.ToStructure(obj.AttrACCOUNT_DETAIL, config);
  s.ssRETURN = ssConectaProveedores.RestRecords.JSONST_e5256660414a7d3dddc63b7cbdd21e9cStructure.ToStructure(obj.AttrRETURN, config);
  }
  return s;
}

public static Func<ST_0f0d90fe4adeeddf082edffc80174eb8Structure, ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_0f0d90fe4adeeddf082edffc80174eb8Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure FromStructure(ST_0f0d90fe4adeeddf082edffc80174eb8Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure(s, config);
}

}


