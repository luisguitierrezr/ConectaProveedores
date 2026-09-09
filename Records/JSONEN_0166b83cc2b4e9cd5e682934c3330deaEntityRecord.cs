using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioStatus
public class JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord : AbstractRESTStructure<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> {
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

[JsonProperty("LabelES")]
[JsonPropertyName("LabelES")]
public string AttrLabelES;

public JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord() { }

public JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = s.ssClass;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrLabelES = s.ssLabelES;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord s) => ToStructure(s, config);
}
public static EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord s = new EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  }
  return s;
}

public static Func<EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord, ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord FromStructure(EN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord(s, config);
}

}


