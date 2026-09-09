using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoice_CNInvoiceStatusRecord
public class JSONRC_426e2c309e94de792ac54a8e3665e09a : AbstractRESTStructure<RC_426e2c309e94de792ac54a8e3665e09a> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Invoice_CN")]
[JsonPropertyName("Invoice_CN")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice_CN;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public JSONRC_426e2c309e94de792ac54a8e3665e09a() { }

public JSONRC_426e2c309e94de792ac54a8e3665e09a (RC_426e2c309e94de792ac54a8e3665e09a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoice_CN = ConvertToRestWithoutDefaults(s.ssENInvoice_CN, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoice_CN = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice_CN, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a, RC_426e2c309e94de792ac54a8e3665e09a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a s) => ToStructure(s, config);
}
public static RC_426e2c309e94de792ac54a8e3665e09a ToStructure(ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a obj, IBehaviorsConfiguration config) { 
  RC_426e2c309e94de792ac54a8e3665e09a s = new RC_426e2c309e94de792ac54a8e3665e09a();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoice_CN = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice_CN, config);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  }
  return s;
}

public static Func<RC_426e2c309e94de792ac54a8e3665e09a, ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_426e2c309e94de792ac54a8e3665e09a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a FromStructure(RC_426e2c309e94de792ac54a8e3665e09a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_426e2c309e94de792ac54a8e3665e09a(s, config);
}

}


