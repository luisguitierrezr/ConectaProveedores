using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntraDomain
public class RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord : AbstractRESTStructure<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("Sufix")]
public string AttrSufix;

public RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord() { }

public RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrSufix = ConvertToRestWithoutDefaults(s.ssSufix, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrSufix = s.ssSufix;
  }
}

public static EN_635849dd879ffe94511aeebfcff26dbcEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord obj) { 
  EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s = new EN_635849dd879ffe94511aeebfcff26dbcEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssSufix = obj.AttrSufix == null ? "" : obj.AttrSufix;
  }
  return s;
}

public static Func<EN_635849dd879ffe94511aeebfcff26dbcEntityRecord, ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord FromStructure(EN_635849dd879ffe94511aeebfcff26dbcEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_635849dd879ffe94511aeebfcff26dbcEntityRecord(s, config);
}

}


