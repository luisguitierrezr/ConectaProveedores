using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoice_CNInvoiceStatusRecord
public class RESTRC_426e2c309e94de792ac54a8e3665e09a : AbstractRESTStructure<RC_426e2c309e94de792ac54a8e3665e09a> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("Invoice_CN")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice_CN;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public RESTRC_426e2c309e94de792ac54a8e3665e09a() { }

public RESTRC_426e2c309e94de792ac54a8e3665e09a (RC_426e2c309e94de792ac54a8e3665e09a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoice_CN = ConvertToRestWithoutDefaults(s.ssENInvoice_CN, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice_CN, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static RC_426e2c309e94de792ac54a8e3665e09a ToStructure(ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a obj) { 
  RC_426e2c309e94de792ac54a8e3665e09a s = new RC_426e2c309e94de792ac54a8e3665e09a();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoice_CN = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice_CN);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  }
  return s;
}

public static Func<RC_426e2c309e94de792ac54a8e3665e09a, ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_426e2c309e94de792ac54a8e3665e09a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a FromStructure(RC_426e2c309e94de792ac54a8e3665e09a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_426e2c309e94de792ac54a8e3665e09a(s, config);
}

}


