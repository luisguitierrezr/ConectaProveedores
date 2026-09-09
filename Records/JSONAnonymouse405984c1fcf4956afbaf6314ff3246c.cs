using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UserInvoiceInvoiceLogRecord
public class JSONRC_febdfe749051cd5849a077ecffdddeec : AbstractRESTStructure<RC_febdfe749051cd5849a077ecffdddeec> {
[JsonProperty("User")]
[JsonPropertyName("User")]
public ssConectaProveedores.RestRecords.JSONENUserEntityRecord AttrUser;

[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceLog")]
[JsonPropertyName("InvoiceLog")]
public ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord AttrInvoiceLog;

public JSONRC_febdfe749051cd5849a077ecffdddeec() { }

public JSONRC_febdfe749051cd5849a077ecffdddeec (RC_febdfe749051cd5849a077ecffdddeec s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUser = ConvertToRestWithoutDefaults(s.ssENUser, new ENUserEntityRecord(), ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure, config);
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceLog = ConvertToRestWithoutDefaults(s.ssENInvoiceLog, new EN_bf34270fdd0f7785895f41a998e724e8EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure, config);
  } else {
AttrUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.FromStructure(s.ssENUser, config);
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.FromStructure(s.ssENInvoiceLog, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec, RC_febdfe749051cd5849a077ecffdddeec> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec s) => ToStructure(s, config);
}
public static RC_febdfe749051cd5849a077ecffdddeec ToStructure(ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec obj, IBehaviorsConfiguration config) { 
  RC_febdfe749051cd5849a077ecffdddeec s = new RC_febdfe749051cd5849a077ecffdddeec();
  if(obj != null) {
  s.ssENUser = ssConectaProveedores.RestRecords.JSONENUserEntityRecord.ToStructure(obj.AttrUser, config);
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceLog = ssConectaProveedores.RestRecords.JSONEN_bf34270fdd0f7785895f41a998e724e8EntityRecord.ToStructure(obj.AttrInvoiceLog, config);
  }
  return s;
}

public static Func<RC_febdfe749051cd5849a077ecffdddeec, ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_febdfe749051cd5849a077ecffdddeec s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec FromStructure(RC_febdfe749051cd5849a077ecffdddeec s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_febdfe749051cd5849a077ecffdddeec(s, config);
}

}


