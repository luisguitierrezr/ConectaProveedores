using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceTaxType
public class RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord : AbstractRESTStructure<EN_cff5cb02ac5fe11578884acf37327af3EntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord() { }

public RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord (EN_cff5cb02ac5fe11578884acf37327af3EntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_cff5cb02ac5fe11578884acf37327af3EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord obj) { 
  EN_cff5cb02ac5fe11578884acf37327af3EntityRecord s = new EN_cff5cb02ac5fe11578884acf37327af3EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_cff5cb02ac5fe11578884acf37327af3EntityRecord, ssConectaProveedores.RestRecords.RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_cff5cb02ac5fe11578884acf37327af3EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord FromStructure(EN_cff5cb02ac5fe11578884acf37327af3EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_cff5cb02ac5fe11578884acf37327af3EntityRecord(s, config);
}

}


