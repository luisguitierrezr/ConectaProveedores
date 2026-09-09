using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFilesAudit
public class RESTST_29dc80a5deae2388e31181e1082143cfStructure : AbstractRESTStructure<ST_29dc80a5deae2388e31181e1082143cfStructure> {
[JsonProperty("InvoiceId")]
public long? AttrInvoiceId;

[JsonProperty("InvoiceName")]
public string AttrInvoiceName;

[JsonProperty("SupplierNr")]
public string AttrSupplierNr;

[JsonProperty("InvoiceUpdatedOn")]
public String AttrInvoiceUpdatedOn;

public RESTST_29dc80a5deae2388e31181e1082143cfStructure() { }

public RESTST_29dc80a5deae2388e31181e1082143cfStructure (ST_29dc80a5deae2388e31181e1082143cfStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceId = ConvertToRestWithoutDefaults(s.ssInvoiceId, 0L);
AttrInvoiceName = ConvertToRestWithoutDefaults(s.ssInvoiceName, "");
AttrSupplierNr = ConvertToRestWithoutDefaults(s.ssSupplierNr, "");
AttrInvoiceUpdatedOn = ConvertDateTimeToRestWithoutDefaults(s.ssInvoiceUpdatedOn, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), config.DateTimeFormat);
  } else {
AttrInvoiceId = (long?) s.ssInvoiceId;
AttrInvoiceName = s.ssInvoiceName;
AttrSupplierNr = s.ssSupplierNr;
AttrInvoiceUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(s.ssInvoiceUpdatedOn, config.DateTimeFormat);
  }
}

public static ST_29dc80a5deae2388e31181e1082143cfStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure obj) { 
  ST_29dc80a5deae2388e31181e1082143cfStructure s = new ST_29dc80a5deae2388e31181e1082143cfStructure();
  if(obj != null) {
  s.ssInvoiceId = obj.AttrInvoiceId == null ? 0L : obj.AttrInvoiceId.Value;
  s.ssInvoiceName = obj.AttrInvoiceName == null ? "" : obj.AttrInvoiceName;
  s.ssSupplierNr = obj.AttrSupplierNr == null ? "" : obj.AttrSupplierNr;
  s.ssInvoiceUpdatedOn = obj.AttrInvoiceUpdatedOn == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(obj.AttrInvoiceUpdatedOn, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
  }
  return s;
}

public static Func<ST_29dc80a5deae2388e31181e1082143cfStructure, ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_29dc80a5deae2388e31181e1082143cfStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure FromStructure(ST_29dc80a5deae2388e31181e1082143cfStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_29dc80a5deae2388e31181e1082143cfStructure(s, config);
}

}


