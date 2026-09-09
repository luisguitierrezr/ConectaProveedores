using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_Response
public class JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure : AbstractRESTStructure<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> {
[JsonProperty("ZMXMIMMF_EM_SM_MO_COSMOZ.Response")]
[JsonPropertyName("ZMXMIMMF_EM_SM_MO_COSMOZ.Response")]
public ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure AttrEM_SM_MO_COSMOZ_Response_Struct;

public JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure() { }

public JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_MO_COSMOZ_Response_Struct, new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure(), ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure(s.ssEM_SM_MO_COSMOZ_Response_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure, ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s) => ToStructure(s, config);
}
public static ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure obj, IBehaviorsConfiguration config) { 
  ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();
  if(obj != null) {
  s.ssEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.JSONST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Response_Struct, config);
  }
  return s;
}

public static Func<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure, ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure FromStructure(ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure(s, config);
}

}


