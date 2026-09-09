using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ImportStatus
public class JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord : AbstractRESTStructure<EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord() { }

public JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord (EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord, EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord s) => ToStructure(s, config);
}
public static EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord s = new EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord, ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord FromStructure(EN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_78d32e7ff6d0cbfb3931f775eadeeb09EntityRecord(s, config);
}

}


