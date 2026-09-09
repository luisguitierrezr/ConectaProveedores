using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProposalStatus
public class JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord : AbstractRESTStructure<EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Class")]
[JsonPropertyName("Class")]
public string AttrClass;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord() { }

public JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = s.ssClass;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord s) => ToStructure(s, config);
}
public static EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord s = new EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord, ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord FromStructure(EN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord(s, config);
}

}


