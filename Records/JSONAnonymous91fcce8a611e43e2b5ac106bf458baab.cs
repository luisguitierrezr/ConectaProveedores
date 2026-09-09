using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DropdownOptionRecord
public class JSONRC_e03a49308bfaca02257d451178bbf041 : AbstractRESTStructure<RC_e03a49308bfaca02257d451178bbf041> {
[JsonProperty("DropdownOption")]
[JsonPropertyName("DropdownOption")]
public ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure AttrDropdownOption;

public JSONRC_e03a49308bfaca02257d451178bbf041() { }

public JSONRC_e03a49308bfaca02257d451178bbf041 (RC_e03a49308bfaca02257d451178bbf041 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDropdownOption = ConvertToRestWithoutDefaults(s.ssSTDropdownOption, new ST_60f22bd2e9b10a22278b8afe6d7f601aStructure(), ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructure, config);
  } else {
AttrDropdownOption = ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.FromStructure(s.ssSTDropdownOption, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041, RC_e03a49308bfaca02257d451178bbf041> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041 s) => ToStructure(s, config);
}
public static RC_e03a49308bfaca02257d451178bbf041 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041 obj, IBehaviorsConfiguration config) { 
  RC_e03a49308bfaca02257d451178bbf041 s = new RC_e03a49308bfaca02257d451178bbf041();
  if(obj != null) {
  s.ssSTDropdownOption = ssConectaProveedores.RestRecords.JSONST_60f22bd2e9b10a22278b8afe6d7f601aStructure.ToStructure(obj.AttrDropdownOption, config);
  }
  return s;
}

public static Func<RC_e03a49308bfaca02257d451178bbf041, ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e03a49308bfaca02257d451178bbf041 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041 FromStructure(RC_e03a49308bfaca02257d451178bbf041 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e03a49308bfaca02257d451178bbf041(s, config);
}

}


