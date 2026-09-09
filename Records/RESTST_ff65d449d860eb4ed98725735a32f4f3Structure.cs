using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_COSMOZ_Response
public class RESTST_ff65d449d860eb4ed98725735a32f4f3Structure : AbstractRESTStructure<ST_ff65d449d860eb4ed98725735a32f4f3Structure> {
[JsonProperty("EM_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure AttrEM_COSMOZ_Response_Struct;

public RESTST_ff65d449d860eb4ed98725735a32f4f3Structure() { }

public RESTST_ff65d449d860eb4ed98725735a32f4f3Structure (ST_ff65d449d860eb4ed98725735a32f4f3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssEM_COSMOZ_Response_Struct, new ST_5bf89f3eec4235b40802e9da4fd3e4afStructure(), ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.FromStructure, config);
  } else {
AttrEM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.FromStructure(s.ssEM_COSMOZ_Response_Struct, config);
  }
}

public static ST_ff65d449d860eb4ed98725735a32f4f3Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure obj) { 
  ST_ff65d449d860eb4ed98725735a32f4f3Structure s = new ST_ff65d449d860eb4ed98725735a32f4f3Structure();
  if(obj != null) {
  s.ssEM_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_5bf89f3eec4235b40802e9da4fd3e4afStructure.ToStructure(obj.AttrEM_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<ST_ff65d449d860eb4ed98725735a32f4f3Structure, ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_ff65d449d860eb4ed98725735a32f4f3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure FromStructure(ST_ff65d449d860eb4ed98725735a32f4f3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_ff65d449d860eb4ed98725735a32f4f3Structure(s, config);
}

}


