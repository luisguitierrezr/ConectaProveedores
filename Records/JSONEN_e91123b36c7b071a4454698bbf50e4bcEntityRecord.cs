using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessResponse
public class JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord : AbstractRESTStructure<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> {
[JsonProperty("InvoiceAccountingProcessId")]
[JsonPropertyName("InvoiceAccountingProcessId")]
public long? AttrInvoiceAccountingProcessId;

[JsonProperty("IsSuccess")]
[JsonPropertyName("IsSuccess")]
public bool? AttrIsSuccess;

[JsonProperty("ID_POLIZA")]
[JsonPropertyName("ID_POLIZA")]
public string AttrID_POLIZA;

[JsonProperty("TEXTO")]
[JsonPropertyName("TEXTO")]
public string AttrTEXTO;

[JsonProperty("PO_RESULTADO")]
[JsonPropertyName("PO_RESULTADO")]
public string AttrPO_RESULTADO;

[JsonProperty("CODIGO")]
[JsonPropertyName("CODIGO")]
public string AttrCODIGO;

public JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord() { }

public JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceAccountingProcessId = (long?) s.ssInvoiceAccountingProcessId;
AttrIsSuccess = ConvertToRestWithoutDefaults(s.ssIsSuccess, false);
AttrID_POLIZA = ConvertToRestWithoutDefaults(s.ssID_POLIZA, "");
AttrTEXTO = ConvertToRestWithoutDefaults(s.ssTEXTO, "");
AttrPO_RESULTADO = ConvertToRestWithoutDefaults(s.ssPO_RESULTADO, "");
AttrCODIGO = ConvertToRestWithoutDefaults(s.ssCODIGO, "");
  } else {
AttrInvoiceAccountingProcessId = (long?) s.ssInvoiceAccountingProcessId;
AttrIsSuccess = (bool?) s.ssIsSuccess;
AttrID_POLIZA = s.ssID_POLIZA;
AttrTEXTO = s.ssTEXTO;
AttrPO_RESULTADO = s.ssPO_RESULTADO;
AttrCODIGO = s.ssCODIGO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord, EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord s) => ToStructure(s, config);
}
public static EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord obj, IBehaviorsConfiguration config) { 
  EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord s = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();
  if(obj != null) {
  s.ssInvoiceAccountingProcessId = obj.AttrInvoiceAccountingProcessId == null ? 0L : obj.AttrInvoiceAccountingProcessId.Value;
  s.ssIsSuccess = obj.AttrIsSuccess == null ? false : obj.AttrIsSuccess.Value;
  s.ssID_POLIZA = obj.AttrID_POLIZA == null ? "" : obj.AttrID_POLIZA;
  s.ssTEXTO = obj.AttrTEXTO == null ? "" : obj.AttrTEXTO;
  s.ssPO_RESULTADO = obj.AttrPO_RESULTADO == null ? "" : obj.AttrPO_RESULTADO;
  s.ssCODIGO = obj.AttrCODIGO == null ? "" : obj.AttrCODIGO;
  }
  return s;
}

public static Func<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord, ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord FromStructure(EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_e91123b36c7b071a4454698bbf50e4bcEntityRecord(s, config);
}

}


