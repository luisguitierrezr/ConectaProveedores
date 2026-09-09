using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderApproval
public class JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord : AbstractRESTStructure<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderId")]
[JsonPropertyName("OrderId")]
public long? AttrOrderId;

[JsonProperty("CurrentLevel")]
[JsonPropertyName("CurrentLevel")]
public int? AttrCurrentLevel;

[JsonProperty("MaxLevel")]
[JsonPropertyName("MaxLevel")]
public int? AttrMaxLevel;

[JsonProperty("StartedOn")]
[JsonPropertyName("StartedOn")]
public String AttrStartedOn;

[JsonProperty("FinishedOn")]
[JsonPropertyName("FinishedOn")]
public String AttrFinishedOn;

[JsonProperty("LastApproverPuestodelGerente")]
[JsonPropertyName("LastApproverPuestodelGerente")]
public string AttrLastApproverPuestodelGerente;

[JsonProperty("LastApproverPuestodelJefe")]
[JsonPropertyName("LastApproverPuestodelJefe")]
public string AttrLastApproverPuestodelJefe;

public JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord() { }

public JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderId = ConvertToRestWithoutDefaults(s.ssOrderId, 0L);
AttrCurrentLevel = ConvertToRestWithoutDefaults(s.ssCurrentLevel, 0);
AttrMaxLevel = ConvertToRestWithoutDefaults(s.ssMaxLevel, 0);
AttrStartedOn = ConvertDateTimeToRestWithoutDefaults(s.ssStartedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrFinishedOn = ConvertDateTimeToRestWithoutDefaults(s.ssFinishedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrLastApproverPuestodelGerente = ConvertToRestWithoutDefaults(s.ssLastApproverPuestodelGerente, "");
AttrLastApproverPuestodelJefe = ConvertToRestWithoutDefaults(s.ssLastApproverPuestodelJefe, "");
  } else {
AttrId = (long?) s.ssId;
AttrOrderId = (long?) s.ssOrderId;
AttrCurrentLevel = (int?) s.ssCurrentLevel;
AttrMaxLevel = (int?) s.ssMaxLevel;
AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssStartedOn, config.DateTimeFormat);
AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssFinishedOn, config.DateTimeFormat);
AttrLastApproverPuestodelGerente = s.ssLastApproverPuestodelGerente;
AttrLastApproverPuestodelJefe = s.ssLastApproverPuestodelJefe;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord, EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord s) => ToStructure(s, config);
}
public static EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord s = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderId = obj.AttrOrderId == null ? 0L : obj.AttrOrderId.Value;
  s.ssCurrentLevel = obj.AttrCurrentLevel == null ? 0 : obj.AttrCurrentLevel.Value;
  s.ssMaxLevel = obj.AttrMaxLevel == null ? 0 : obj.AttrMaxLevel.Value;
  s.ssStartedOn = obj.AttrStartedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrStartedOn, config.DateTimeFormat);
  s.ssFinishedOn = obj.AttrFinishedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrFinishedOn, config.DateTimeFormat);
  s.ssLastApproverPuestodelGerente = obj.AttrLastApproverPuestodelGerente == null ? "" : obj.AttrLastApproverPuestodelGerente;
  s.ssLastApproverPuestodelJefe = obj.AttrLastApproverPuestodelJefe == null ? "" : obj.AttrLastApproverPuestodelJefe;
  }
  return s;
}

public static Func<EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord, ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord FromStructure(EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(s, config);
}

}


