using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceLogRequisitionRecord
public class JSONRC_0971e035ffe4575db2572522684e7dc7 : AbstractRESTStructure<RC_0971e035ffe4575db2572522684e7dc7> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceLog")]
[JsonPropertyName("InvoiceLog")]
public ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public JSONRC_0971e035ffe4575db2572522684e7dc7() { }

public JSONRC_0971e035ffe4575db2572522684e7dc7 (RC_0971e035ffe4575db2572522684e7dc7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7, RC_0971e035ffe4575db2572522684e7dc7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7 s) => ToStructure(s, config);
}
public static RC_0971e035ffe4575db2572522684e7dc7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7 obj, IBehaviorsConfiguration config) { 
  RC_0971e035ffe4575db2572522684e7dc7 s = new RC_0971e035ffe4575db2572522684e7dc7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog, config);
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  }
  return s;
}

public static Func<RC_0971e035ffe4575db2572522684e7dc7, ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0971e035ffe4575db2572522684e7dc7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7 FromStructure(RC_0971e035ffe4575db2572522684e7dc7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0971e035ffe4575db2572522684e7dc7(s, config);
}

}


