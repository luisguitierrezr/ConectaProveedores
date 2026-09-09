using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceLogRecord
public class RESTRC_febdfe749051cd5849a077ecffdddeec : AbstractRESTStructure<RC_febdfe749051cd5849a077ecffdddeec> {
[JsonProperty("User")]
public ssConectaProveedores.RestRecords.RESTENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceLog")]
public ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

public RESTRC_febdfe749051cd5849a077ecffdddeec() { }

public RESTRC_febdfe749051cd5849a077ecffdddeec (RC_febdfe749051cd5849a077ecffdddeec s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
  }
}

public static RC_febdfe749051cd5849a077ecffdddeec ToStructure(ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec obj) { 
  RC_febdfe749051cd5849a077ecffdddeec s = new RC_febdfe749051cd5849a077ecffdddeec();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.RESTENUserEntityRecord.ToStructure(obj.AttrUser);
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.RESTEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog);
  }
  return s;
}

public static Func<RC_febdfe749051cd5849a077ecffdddeec, ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_febdfe749051cd5849a077ecffdddeec s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec FromStructure(RC_febdfe749051cd5849a077ecffdddeec s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_febdfe749051cd5849a077ecffdddeec(s, config);
}

}


