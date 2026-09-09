using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InsuranceType
public class RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord : AbstractRESTStructure<EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord() { }

public RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord (EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord obj) { 
  EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord s = new EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord, ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord FromStructure(EN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_236be3b5d3b4417469f4bc1f0f73d781EntityRecord(s, config);
}

}


