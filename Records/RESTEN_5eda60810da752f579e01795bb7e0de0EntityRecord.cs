using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatus
public class RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord : AbstractRESTStructure<EN_5eda60810da752f579e01795bb7e0de0EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Class")]
public string AttrClass;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("LabelES")]
public string AttrLabelES;

public RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord() { }

public RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord (EN_5eda60810da752f579e01795bb7e0de0EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_5eda60810da752f579e01795bb7e0de0EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord obj) { 
  EN_5eda60810da752f579e01795bb7e0de0EntityRecord s = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
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

public static Func<EN_5eda60810da752f579e01795bb7e0de0EntityRecord, ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_5eda60810da752f579e01795bb7e0de0EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord FromStructure(EN_5eda60810da752f579e01795bb7e0de0EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord(s, config);
}

}


