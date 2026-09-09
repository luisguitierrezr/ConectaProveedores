using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_MO_COSMOZ_Response
public class RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure : AbstractRESTStructure<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> {
[JsonProperty("EM_SM_MO_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure AttrEM_SM_MO_COSMOZ_Response_Struct;

public RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure() { }

public RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_MO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_MO_COSMOZ_Response_Struct, new ST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure(), ssConectaProveedores.RestRecords.RESTST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure, config);
  } else {
AttrEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.FromStructure(s.ssEM_SM_MO_COSMOZ_Response_Struct, config);
  }
}

public static ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure obj) { 
  ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();
  if(obj != null) {
  s.ssEM_SM_MO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_a9a173db59d58c3d9b3cce36f7bcb5ccStructure.ToStructure(obj.AttrEM_SM_MO_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure, ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure FromStructure(ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_5a2f27e86c3f9cff3d6a27ca1772d236Structure(s, config);
}

}


