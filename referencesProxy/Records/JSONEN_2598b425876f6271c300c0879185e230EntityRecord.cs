using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// CustomSettings
public class JSONEN_2598b425876f6271c300c0879185e230EntityRecord : AbstractRESTStructure<EN_2598b425876f6271c300c0879185e230EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public int? AttrId;

[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

[JsonProperty("Description")]
[JsonPropertyName("Description")]
public string AttrDescription;

[JsonProperty("CustomSettingTypeId")]
[JsonPropertyName("CustomSettingTypeId")]
public int? AttrCustomSettingTypeId;

[JsonProperty("Order")]
[JsonPropertyName("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
[JsonPropertyName("Is_Active")]
public bool? AttrIs_Active;

public JSONEN_2598b425876f6271c300c0879185e230EntityRecord() { }

public JSONEN_2598b425876f6271c300c0879185e230EntityRecord (EN_2598b425876f6271c300c0879185e230EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrDescription = ConvertToRestWithoutDefaults(s.ssDescription, "");
AttrCustomSettingTypeId = ConvertToRestWithoutDefaults(s.ssCustomSettingTypeId, 0);
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrDescription = s.ssDescription;
AttrCustomSettingTypeId = (int?) s.ssCustomSettingTypeId;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord, EN_2598b425876f6271c300c0879185e230EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord s) => ToStructure(s, config);
}
public static EN_2598b425876f6271c300c0879185e230EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_2598b425876f6271c300c0879185e230EntityRecord s = new EN_2598b425876f6271c300c0879185e230EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssDescription = obj.AttrDescription == null ? "" : obj.AttrDescription;
  s.ssCustomSettingTypeId = obj.AttrCustomSettingTypeId == null ? 0 : obj.AttrCustomSettingTypeId.Value;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_2598b425876f6271c300c0879185e230EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_2598b425876f6271c300c0879185e230EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord FromStructure(EN_2598b425876f6271c300c0879185e230EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_2598b425876f6271c300c0879185e230EntityRecord(s, config);
}

}


