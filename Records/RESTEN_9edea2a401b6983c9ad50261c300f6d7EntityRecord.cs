using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatusHistory
public class RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord : AbstractRESTStructure<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceStatusId")]
public int? AttrInvoiceStatusId;

[JsonProperty("TimeStamp")]
public String AttrTimeStamp;

[JsonProperty("CreatedBy")]
public string AttrCreatedBy;

public RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord() { }

public RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceStatusId = ConvertToRestWithoutDefaults(s.ssInvoiceStatusId, 0);
AttrTimeStamp = ConvertDateTimeToRestWithoutDefaults(s.ssTimeStamp, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceStatusId = (int?) s.ssInvoiceStatusId;
AttrTimeStamp = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssTimeStamp, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
  }
}

public static EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord obj) { 
  EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord s = new EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceStatusId = obj.AttrInvoiceStatusId == null ? 0 : obj.AttrInvoiceStatusId.Value;
  s.ssTimeStamp = obj.AttrTimeStamp == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrTimeStamp, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  }
  return s;
}

public static Func<EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord, ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord FromStructure(EN_9edea2a401b6983c9ad50261c300f6d7EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_9edea2a401b6983c9ad50261c300f6d7EntityRecord(s, config);
}

}


