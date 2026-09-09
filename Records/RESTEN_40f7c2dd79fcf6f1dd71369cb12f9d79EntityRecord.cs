using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicePoliza
public class RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord : AbstractRESTStructure<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("PolizaId")]
public string AttrPolizaId;

[JsonProperty("PolizaSAP")]
public string AttrPolizaSAP;

[JsonProperty("SAPObject")]
public string AttrSAPObject;

[JsonProperty("Sent")]
public bool? AttrSent;

[JsonProperty("SentWhen")]
public String AttrSentWhen;

[JsonProperty("WithError")]
public bool? AttrWithError;

[JsonProperty("Error_Message")]
public string AttrError_Message;

[JsonProperty("CreatedOn")]
public String AttrCreatedOn;

public RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord() { }

public RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrPolizaId = ConvertToRestWithoutDefaults(s.ssPolizaId, "");
AttrPolizaSAP = ConvertToRestWithoutDefaults(s.ssPolizaSAP, "");
AttrSAPObject = ConvertToRestWithoutDefaults(s.ssSAPObject, "");
AttrSent = ConvertToRestWithoutDefaults(s.ssSent, false);
AttrSentWhen = ConvertDateTimeToRestWithoutDefaults(s.ssSentWhen, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrWithError = ConvertToRestWithoutDefaults(s.ssWithError, false);
AttrError_Message = ConvertToRestWithoutDefaults(s.ssError_Message, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrId = (long?) s.ssId;
AttrPolizaId = s.ssPolizaId;
AttrPolizaSAP = s.ssPolizaSAP;
AttrSAPObject = s.ssSAPObject;
AttrSent = (bool?) s.ssSent;
AttrSentWhen = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssSentWhen, config.DateTimeFormat);
AttrWithError = (bool?) s.ssWithError;
AttrError_Message = s.ssError_Message;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
  }
}

public static EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord obj) { 
  EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord s = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssPolizaId = obj.AttrPolizaId == null ? "" : obj.AttrPolizaId;
  s.ssPolizaSAP = obj.AttrPolizaSAP == null ? "" : obj.AttrPolizaSAP;
  s.ssSAPObject = obj.AttrSAPObject == null ? "" : obj.AttrSAPObject;
  s.ssSent = obj.AttrSent == null ? false : obj.AttrSent.Value;
  s.ssSentWhen = obj.AttrSentWhen == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrSentWhen, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  s.ssWithError = obj.AttrWithError == null ? false : obj.AttrWithError.Value;
  s.ssError_Message = obj.AttrError_Message == null ? "" : obj.AttrError_Message;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord, ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord FromStructure(EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord(s, config);
}

}


