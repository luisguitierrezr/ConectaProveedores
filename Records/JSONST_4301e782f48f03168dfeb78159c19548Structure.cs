using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_Filters
public class JSONST_4301e782f48f03168dfeb78159c19548Structure : AbstractRESTStructure<ST_4301e782f48f03168dfeb78159c19548Structure> {
[JsonProperty("InvoiceName")]
[JsonPropertyName("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("SupplierId")]
[JsonPropertyName("SupplierId")]
public long? AttrSupplierId;

[JsonProperty("InvoiceStatusId")]
[JsonPropertyName("InvoiceStatusId")]
public int? AttrInvoiceStatusId;

[JsonProperty("DateFrom")]
[JsonPropertyName("DateFrom")]
public String AttrDateFrom;

[JsonProperty("DateTo")]
[JsonPropertyName("DateTo")]
public String AttrDateTo;

public JSONST_4301e782f48f03168dfeb78159c19548Structure() { }

public JSONST_4301e782f48f03168dfeb78159c19548Structure (ST_4301e782f48f03168dfeb78159c19548Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrSupplierId = ConvertToRestWithoutDefaults(s.ssSupplierId, 0L);
AttrInvoiceStatusId = ConvertToRestWithoutDefaults(s.ssInvoiceStatusId, 0);
AttrDateFrom = ConvertDateToRestWithoutDefaults(s.ssDateFrom, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
AttrDateTo = ConvertDateToRestWithoutDefaults(s.ssDateTo, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
  } else {
AttrInvoiceName = s.ssInvoiceName;
AttrSupplierId = (long?) s.ssSupplierId;
AttrInvoiceStatusId = (int?) s.ssInvoiceStatusId;
AttrDateFrom = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateFrom);
AttrDateTo = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssDateTo);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure, ST_4301e782f48f03168dfeb78159c19548Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure s) => ToStructure(s, config);
}
public static ST_4301e782f48f03168dfeb78159c19548Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure obj, IBehaviorsConfiguration config) { 
  ST_4301e782f48f03168dfeb78159c19548Structure s = new ST_4301e782f48f03168dfeb78159c19548Structure();
  if(obj != null) {
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssSupplierId = obj.AttrSupplierId == null ? 0L : obj.AttrSupplierId.Value;
  s.ssInvoiceStatusId = obj.AttrInvoiceStatusId == null ? 0 : obj.AttrInvoiceStatusId.Value;
  s.ssDateFrom = obj.AttrDateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateFrom);
  s.ssDateTo = obj.AttrDateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrDateTo);
  }
  return s;
}

public static Func<ST_4301e782f48f03168dfeb78159c19548Structure, ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4301e782f48f03168dfeb78159c19548Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure FromStructure(ST_4301e782f48f03168dfeb78159c19548Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_4301e782f48f03168dfeb78159c19548Structure(s, config);
}

}


