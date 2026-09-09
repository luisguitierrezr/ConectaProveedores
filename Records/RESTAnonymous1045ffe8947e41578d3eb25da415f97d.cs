using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyInvoiceInvoiceStatusOrderAccConceptsOrderRequestFileOrderAccountingOrderMainAccountingDataTypeRecord
public class RESTRC_2563c789f5f898fb1c6cb65b6b599fae : AbstractRESTStructure<RC_2563c789f5f898fb1c6cb65b6b599fae> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

[JsonProperty("OrderAccConcepts")]
public ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord AttrOrderAccConcepts;

[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord AttrOrderAccounting;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("AccountingDataType")]
public ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord AttrAccountingDataType;

public RESTRC_2563c789f5f898fb1c6cb65b6b599fae() { }

public RESTRC_2563c789f5f898fb1c6cb65b6b599fae (RC_2563c789f5f898fb1c6cb65b6b599fae s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
AttrOrderAccConcepts = ConvertToRestWithoutDefaults(s.ssENOrderAccConcepts, new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure, config);
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderAccounting = ConvertToRestWithoutDefaults(s.ssENOrderAccounting, new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrAccountingDataType = ConvertToRestWithoutDefaults(s.ssENAccountingDataType, new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
AttrOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.FromStructure(s.ssENOrderAccConcepts, config);
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.FromStructure(s.ssENOrderAccounting, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.FromStructure(s.ssENAccountingDataType, config);
  }
}

public static RC_2563c789f5f898fb1c6cb65b6b599fae ToStructure(ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae obj) { 
  RC_2563c789f5f898fb1c6cb65b6b599fae s = new RC_2563c789f5f898fb1c6cb65b6b599fae();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  s.ssENOrderAccConcepts = ssConectaProveedores.RestRecords.RESTEN_3e07a23619060cc7dc5624548803f5fdEntityRecord.ToStructure(obj.AttrOrderAccConcepts);
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssENOrderAccounting = ssConectaProveedores.RestRecords.RESTEN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord.ToStructure(obj.AttrOrderAccounting);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENAccountingDataType = ssConectaProveedores.RestRecords.RESTEN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord.ToStructure(obj.AttrAccountingDataType);
  }
  return s;
}

public static Func<RC_2563c789f5f898fb1c6cb65b6b599fae, ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2563c789f5f898fb1c6cb65b6b599fae s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae FromStructure(RC_2563c789f5f898fb1c6cb65b6b599fae s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2563c789f5f898fb1c6cb65b6b599fae(s, config);
}

}


