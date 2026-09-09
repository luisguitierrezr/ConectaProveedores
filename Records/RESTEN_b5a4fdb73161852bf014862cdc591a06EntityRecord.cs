using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceAccountingProcessRetentions
public class RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord : AbstractRESTStructure<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord> {
[JsonProperty("Id")]
public long? AttrId;

[JsonProperty("InvoiceAccountingProcessId")]
public long? AttrInvoiceAccountingProcessId;

[JsonProperty("WITHT")]
public string AttrWITHT;

[JsonProperty("WT_WITHCD")]
public string AttrWT_WITHCD;

[JsonProperty("WT_SUBJCT")]
public string AttrWT_SUBJCT;

public RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord() { }

public RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (long?) s.ssId;
AttrInvoiceAccountingProcessId = ConvertToRestWithoutDefaults(s.ssInvoiceAccountingProcessId, 0L);
AttrWITHT = ConvertToRestWithoutDefaults(s.ssWITHT, "");
AttrWT_WITHCD = ConvertToRestWithoutDefaults(s.ssWT_WITHCD, "");
AttrWT_SUBJCT = ConvertToRestWithoutDefaults(s.ssWT_SUBJCT, "");
  } else {
AttrId = (long?) s.ssId;
AttrInvoiceAccountingProcessId = (long?) s.ssInvoiceAccountingProcessId;
AttrWITHT = s.ssWITHT;
AttrWT_WITHCD = s.ssWT_WITHCD;
AttrWT_SUBJCT = s.ssWT_SUBJCT;
  }
}

public static EN_b5a4fdb73161852bf014862cdc591a06EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord obj) { 
  EN_b5a4fdb73161852bf014862cdc591a06EntityRecord s = new EN_b5a4fdb73161852bf014862cdc591a06EntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0L : obj.AttrId.Value;
  s.ssInvoiceAccountingProcessId = obj.AttrInvoiceAccountingProcessId == null ? 0L : obj.AttrInvoiceAccountingProcessId.Value;
  s.ssWITHT = obj.AttrWITHT == null ? "" : obj.AttrWITHT;
  s.ssWT_WITHCD = obj.AttrWT_WITHCD == null ? "" : obj.AttrWT_WITHCD;
  s.ssWT_SUBJCT = obj.AttrWT_SUBJCT == null ? "" : obj.AttrWT_SUBJCT;
  }
  return s;
}

public static Func<EN_b5a4fdb73161852bf014862cdc591a06EntityRecord, ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_b5a4fdb73161852bf014862cdc591a06EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord FromStructure(EN_b5a4fdb73161852bf014862cdc591a06EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_b5a4fdb73161852bf014862cdc591a06EntityRecord(s, config);
}

}


