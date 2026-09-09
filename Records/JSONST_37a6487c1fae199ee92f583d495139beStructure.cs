using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationOutput
public class JSONST_37a6487c1fae199ee92f583d495139beStructure : AbstractRESTStructure<ST_37a6487c1fae199ee92f583d495139beStructure> {
[JsonProperty("Select")]
[JsonPropertyName("Select")]
public bool? AttrSelect;

[JsonProperty("SupplierName")]
[JsonPropertyName("SupplierName")]
public string AttrSupplierName;

[JsonProperty("InvoiceName")]
[JsonPropertyName("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("RequisitionName")]
[JsonPropertyName("RequisitionName")]
public string AttrRequisitionName;

[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public decimal? AttrTotalAmount;

[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public string AttrCurrency;

[JsonProperty("UUId")]
[JsonPropertyName("UUId")]
public string AttrUUId;

[JsonProperty("Filename")]
[JsonPropertyName("Filename")]
public string AttrFilename;

[JsonProperty("CreateOn")]
[JsonPropertyName("CreateOn")]
public String AttrCreateOn;

[JsonProperty("AccountDate")]
[JsonPropertyName("AccountDate")]
public String AttrAccountDate;

[JsonProperty("StorageId")]
[JsonPropertyName("StorageId")]
public long? AttrStorageId;

[JsonProperty("Size")]
[JsonPropertyName("Size")]
public long? AttrSize;

public JSONST_37a6487c1fae199ee92f583d495139beStructure() { }

public JSONST_37a6487c1fae199ee92f583d495139beStructure (ST_37a6487c1fae199ee92f583d495139beStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSelect = ConvertToRestWithoutDefaults(s.ssSelect, false);
AttrSupplierName = ConvertToRestWithoutDefaults(s.ssSupplierName, "");
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrRequisitionName = ConvertToRestWithoutDefaults(s.ssRequisitionName, "");
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
AttrCurrency = ConvertToRestWithoutDefaults(s.ssCurrency, "");
AttrUUId = ConvertToRestWithoutDefaults(s.ssUUId, "");
AttrFilename = ConvertToRestWithoutDefaults(s.ssFilename, "");
AttrCreateOn = ConvertDateTimeToRestWithoutDefaults(s.ssCreateOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
AttrAccountDate = ConvertDateToRestWithoutDefaults(s.ssAccountDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrStorageId = ConvertToRestWithoutDefaults(s.ssStorageId, 0L);
AttrSize = ConvertToRestWithoutDefaults(s.ssSize, 0L);
  } else {
AttrSelect = (bool?) s.ssSelect;
AttrSupplierName = s.ssSupplierName;
AttrInvoiceName = s.ssInvoiceName;
AttrRequisitionName = s.ssRequisitionName;
AttrTotalAmount = (decimal?) s.ssTotalAmount;
AttrCurrency = s.ssCurrency;
AttrUUId = s.ssUUId;
AttrFilename = s.ssFilename;
AttrCreateOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssCreateOn, config.DateTimeFormat);
AttrAccountDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssAccountDate);
AttrStorageId = (long?) s.ssStorageId;
AttrSize = (long?) s.ssSize;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure, ST_37a6487c1fae199ee92f583d495139beStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure s) => ToStructure(s, config);
}
public static ST_37a6487c1fae199ee92f583d495139beStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure obj, IBehaviorsConfiguration config) { 
  ST_37a6487c1fae199ee92f583d495139beStructure s = new ST_37a6487c1fae199ee92f583d495139beStructure();
  if(obj != null) {
  s.ssSelect = obj.AttrSelect == null ? false : obj.AttrSelect.Value;
  s.ssSupplierName = obj.AttrSupplierName == null ? "" : obj.AttrSupplierName;
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssRequisitionName = obj.AttrRequisitionName == null ? "" : obj.AttrRequisitionName;
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  s.ssCurrency = obj.AttrCurrency == null ? "" : obj.AttrCurrency;
  s.ssUUId = obj.AttrUUId == null ? "" : obj.AttrUUId;
  s.ssFilename = obj.AttrFilename == null ? "" : obj.AttrFilename;
  s.ssCreateOn = obj.AttrCreateOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrCreateOn, config.DateTimeFormat);
  s.ssAccountDate = obj.AttrAccountDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrAccountDate);
  s.ssStorageId = obj.AttrStorageId == null ? 0L : obj.AttrStorageId.Value;
  s.ssSize = obj.AttrSize == null ? 0L : obj.AttrSize.Value;
  }
  return s;
}

public static Func<ST_37a6487c1fae199ee92f583d495139beStructure, ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_37a6487c1fae199ee92f583d495139beStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure FromStructure(ST_37a6487c1fae199ee92f583d495139beStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure(s, config);
}

}


