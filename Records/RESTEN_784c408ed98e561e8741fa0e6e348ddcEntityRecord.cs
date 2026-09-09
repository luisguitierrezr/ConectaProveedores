using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DepositType
public class RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord : AbstractRESTStructure<EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

public RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord() { }

public RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord (EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord s, IBehaviorsConfiguration config) {
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

public static EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord obj) { 
  EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord s = new EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  }
  return s;
}

public static Func<EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord, ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord FromStructure(EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord(s, config);
}

}


