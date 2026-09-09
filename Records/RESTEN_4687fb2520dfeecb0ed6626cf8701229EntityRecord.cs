using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRetentionType
public class RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord : AbstractRESTStructure<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("Percentage")]
public decimal? AttrPercentage;

public RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord() { }

public RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrPercentage = ConvertToRestWithoutDefaults(s.ssPercentage, 0.0M);
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrPercentage = (decimal?) s.ssPercentage;
  }
}

public static EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord obj) { 
  EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord s = new EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssPercentage = obj.AttrPercentage == null ? 0.0M : obj.AttrPercentage.Value;
  }
  return s;
}

public static Func<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord FromStructure(EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord(s, config);
}

}


