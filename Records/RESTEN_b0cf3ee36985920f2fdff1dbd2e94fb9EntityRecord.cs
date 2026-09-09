using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialPostDeliveryAuthorization
public class RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord : AbstractRESTStructure<EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord() { }

public RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord (EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord obj) { 
  EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord s = new EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord FromStructure(EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord(s, config);
}

}


