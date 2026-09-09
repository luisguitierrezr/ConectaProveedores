using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceLogRequisitionRecord
public class RESTRC_0971e035ffe4575db2572522684e7dc7 : AbstractRESTStructure<RC_0971e035ffe4575db2572522684e7dc7> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceLog")]
public ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

public RESTRC_0971e035ffe4575db2572522684e7dc7() { }

public RESTRC_0971e035ffe4575db2572522684e7dc7 (RC_0971e035ffe4575db2572522684e7dc7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
  }
}

public static RC_0971e035ffe4575db2572522684e7dc7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0971e035ffe4575db2572522684e7dc7 obj) { 
  RC_0971e035ffe4575db2572522684e7dc7 s = new RC_0971e035ffe4575db2572522684e7dc7();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog);
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  }
  return s;
}

public static Func<RC_0971e035ffe4575db2572522684e7dc7, ssConectaProveedores.RestRecords.RESTRC_0971e035ffe4575db2572522684e7dc7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0971e035ffe4575db2572522684e7dc7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0971e035ffe4575db2572522684e7dc7 FromStructure(RC_0971e035ffe4575db2572522684e7dc7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0971e035ffe4575db2572522684e7dc7(s, config);
}

}


