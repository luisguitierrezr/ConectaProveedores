using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceLog
public class RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord : AbstractRESTStructure<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("Message")]
public string AttrMessage;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("IsError")]
public bool? AttrIsError;

public RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord() { }

public RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrMessage = ConvertToRestWithoutDefaults(s.ssMessage, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrIsError = ConvertToRestWithoutDefaults(s.ssIsError, false);
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrMessage = s.ssMessage;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrIsError = (bool?) s.ssIsError;
  }
}

public static EN_bf34270fdd0f7785895f41a998e724e8EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord obj) { 
  EN_bf34270fdd0f7785895f41a998e724e8EntityRecord s = new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssMessage = obj.AttrMessage == null ? "" : obj.AttrMessage;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssIsError = obj.AttrIsError == null ? false : obj.AttrIsError.Value;
  }
  return s;
}

public static Func<EN_bf34270fdd0f7785895f41a998e724e8EntityRecord, ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_bf34270fdd0f7785895f41a998e724e8EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord FromStructure(EN_bf34270fdd0f7785895f41a998e724e8EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord(s, config);
}

}


