using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// User_Preferences
public class JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord : AbstractRESTStructure<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public string AttrId;

[JsonProperty("TableLinesCount")]
[JsonPropertyName("TableLinesCount")]
public int? AttrTableLinesCount;

public JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord() { }

public JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = s.ssId;
AttrTableLinesCount = ConvertToRestWithoutDefaults(s.ssTableLinesCount, 20);
  } else {
AttrId = s.ssId;
AttrTableLinesCount = (int?) s.ssTableLinesCount;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord, EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord s) => ToStructure(s, config);
}
public static EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord s = new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? "" : obj.AttrId;
  s.ssTableLinesCount = obj.AttrTableLinesCount == null ? 20 : obj.AttrTableLinesCount.Value;
  }
  return s;
}

public static Func<EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord FromStructure(EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord(s, config);
}

}


