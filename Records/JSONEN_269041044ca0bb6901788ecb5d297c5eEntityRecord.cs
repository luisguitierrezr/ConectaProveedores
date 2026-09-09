using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialApproval
public class JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord : AbstractRESTStructure<EN_269041044ca0bb6901788ecb5d297c5eEntityRecord> {
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

public JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord() { }

public JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord (EN_269041044ca0bb6901788ecb5d297c5eEntityRecord s, IBehaviorsConfiguration config) {
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

public static Func<ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord, EN_269041044ca0bb6901788ecb5d297c5eEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord s) => ToStructure(s, config);
}
public static EN_269041044ca0bb6901788ecb5d297c5eEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_269041044ca0bb6901788ecb5d297c5eEntityRecord s = new EN_269041044ca0bb6901788ecb5d297c5eEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_269041044ca0bb6901788ecb5d297c5eEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord FromStructure(EN_269041044ca0bb6901788ecb5d297c5eEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_269041044ca0bb6901788ecb5d297c5eEntityRecord(s, config);
}

}


