using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RoleStatus
public class RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord : AbstractRESTStructure<EN_fee44a96be32c0c9f1bda470eac56718EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord() { }

public RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord (EN_fee44a96be32c0c9f1bda470eac56718EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_fee44a96be32c0c9f1bda470eac56718EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord obj) { 
  EN_fee44a96be32c0c9f1bda470eac56718EntityRecord s = new EN_fee44a96be32c0c9f1bda470eac56718EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_fee44a96be32c0c9f1bda470eac56718EntityRecord, ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_fee44a96be32c0c9f1bda470eac56718EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord FromStructure(EN_fee44a96be32c0c9f1bda470eac56718EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_fee44a96be32c0c9f1bda470eac56718EntityRecord(s, config);
}

}


