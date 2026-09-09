using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderItemEntries
public class JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord : AbstractRESTStructure<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> {
[JsonProperty("Id")]
[JsonPropertyName("Id")]
public long? AttrId;

[JsonProperty("OrderMainItemid")]
[JsonPropertyName("OrderMainItemid")]
public long? AttrOrderMainItemid;

[JsonProperty("Quantity_")]
[JsonPropertyName("Quantity_")]
public decimal? AttrQuantity_;

[JsonProperty("IsFromFirstImport")]
[JsonPropertyName("IsFromFirstImport")]
public bool? AttrIsFromFirstImport;

[JsonProperty("EntryDocument")]
[JsonPropertyName("EntryDocument")]
public string AttrEntryDocument;

[JsonProperty("CreatedOn")]
[JsonPropertyName("CreatedOn")]
public String AttrCreatedOn;

[JsonProperty("CreatedBy")]
[JsonPropertyName("CreatedBy")]
public string AttrCreatedBy;

[JsonProperty("RejectFolio")]
[JsonPropertyName("RejectFolio")]
public bool? AttrRejectFolio;

public JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord() { }

public JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrOrderMainItemid = ConvertToRestWithoutDefaults(s.ssOrderMainItemid, 0L);
AttrQuantity_ = ConvertToRestWithoutDefaults(s.ssQuantity_, 0.0M);
AttrIsFromFirstImport = ConvertToRestWithoutDefaults(s.ssIsFromFirstImport, false);
AttrEntryDocument = ConvertToRestWithoutDefaults(s.ssEntryDocument, "");
AttrCreatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrCreatedBy = ConvertToRestWithoutDefaults(s.ssCreatedBy, "");
AttrRejectFolio = ConvertToRestWithoutDefaults(s.ssRejectFolio, false);
  } else {
AttrId = (long?) s.ssId;
AttrOrderMainItemid = (long?) s.ssOrderMainItemid;
AttrQuantity_ = (decimal?) s.ssQuantity_;
AttrIsFromFirstImport = (bool?) s.ssIsFromFirstImport;
AttrEntryDocument = s.ssEntryDocument;
AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreatedOn, config.DateTimeFormat);
AttrCreatedBy = s.ssCreatedBy;
AttrRejectFolio = (bool?) s.ssRejectFolio;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord, EN_0eb2cf39b93366f50855e537f6b98500EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord s) => ToStructure(s, config);
}
public static EN_0eb2cf39b93366f50855e537f6b98500EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_0eb2cf39b93366f50855e537f6b98500EntityRecord s = new EN_0eb2cf39b93366f50855e537f6b98500EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssOrderMainItemid = obj.AttrOrderMainItemid == null ? 0L : obj.AttrOrderMainItemid.Value;
  s.ssQuantity_ = obj.AttrQuantity_ == null ? 0.0M : obj.AttrQuantity_.Value;
  s.ssIsFromFirstImport = obj.AttrIsFromFirstImport == null ? false : obj.AttrIsFromFirstImport.Value;
  s.ssEntryDocument = obj.AttrEntryDocument == null ? "" : obj.AttrEntryDocument;
  s.ssCreatedOn = obj.AttrCreatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreatedOn, config.DateTimeFormat);
  s.ssCreatedBy = obj.AttrCreatedBy == null ? "" : obj.AttrCreatedBy;
  s.ssRejectFolio = obj.AttrRejectFolio == null ? false : obj.AttrRejectFolio.Value;
  }
  return s;
}

public static Func<EN_0eb2cf39b93366f50855e537f6b98500EntityRecord, ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0eb2cf39b93366f50855e537f6b98500EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord FromStructure(EN_0eb2cf39b93366f50855e537f6b98500EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_0eb2cf39b93366f50855e537f6b98500EntityRecord(s, config);
}

}


