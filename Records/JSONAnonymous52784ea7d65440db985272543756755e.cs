using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceOrderMainInvoiceAccountingProcessRecord
public class JSONRC_ff169b020f7f52f3fee2c054b741a07f : AbstractRESTStructure<RC_ff169b020f7f52f3fee2c054b741a07f> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("InvoiceAccountingProcess")]
[JsonPropertyName("InvoiceAccountingProcess")]
public ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord AttrInvoiceAccountingProcess;

public JSONRC_ff169b020f7f52f3fee2c054b741a07f() { }

public JSONRC_ff169b020f7f52f3fee2c054b741a07f (RC_ff169b020f7f52f3fee2c054b741a07f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrInvoiceAccountingProcess = ConvertToRestWithoutDefaults(s.ssENInvoiceAccountingProcess, new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.FromStructure(s.ssENInvoiceAccountingProcess, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f, RC_ff169b020f7f52f3fee2c054b741a07f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f s) => ToStructure(s, config);
}
public static RC_ff169b020f7f52f3fee2c054b741a07f ToStructure(ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f obj, IBehaviorsConfiguration config) { 
  RC_ff169b020f7f52f3fee2c054b741a07f s = new RC_ff169b020f7f52f3fee2c054b741a07f();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  s.ssENInvoiceAccountingProcess = ssConectaProveedores.RestRecords.JSONEN_d21666375df829d28ffce8e5e0a3400dEntityRecord.ToStructure(obj.AttrInvoiceAccountingProcess, config);
  }
  return s;
}

public static Func<RC_ff169b020f7f52f3fee2c054b741a07f, ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ff169b020f7f52f3fee2c054b741a07f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f FromStructure(RC_ff169b020f7f52f3fee2c054b741a07f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ff169b020f7f52f3fee2c054b741a07f(s, config);
}

}


