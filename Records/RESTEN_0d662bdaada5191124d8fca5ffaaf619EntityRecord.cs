using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessLines_F43
public class RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord : AbstractRESTStructure<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceAccounting_ProcessId")]
public long? AttrInvoiceAccounting_ProcessId;

[JsonProperty("Parameter")]
public string AttrParameter;

public RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord() { }

public RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceAccounting_ProcessId = ConvertToRestWithoutDefaults(s.ssInvoiceAccounting_ProcessId, 0L);
AttrParameter = ConvertToRestWithoutDefaults(s.ssParameter, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceAccounting_ProcessId = (long?) s.ssInvoiceAccounting_ProcessId;
AttrParameter = s.ssParameter;
  }
}

public static EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord obj) { 
  EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord s = new EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceAccounting_ProcessId = obj.AttrInvoiceAccounting_ProcessId == null ? 0L : obj.AttrInvoiceAccounting_ProcessId.Value;
  s.ssParameter = obj.AttrParameter == null ? "" : obj.AttrParameter;
  }
  return s;
}

public static Func<EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord, ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord FromStructure(EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_0d662bdaada5191124d8fca5ffaaf619EntityRecord(s, config);
}

}


