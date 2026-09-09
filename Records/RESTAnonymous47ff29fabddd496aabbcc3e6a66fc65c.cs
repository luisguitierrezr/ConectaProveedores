using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRecord
public class RESTRC_04c5986b32c7822f033c933cf71b96bd : AbstractRESTStructure<RC_04c5986b32c7822f033c933cf71b96bd> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

public RESTRC_04c5986b32c7822f033c933cf71b96bd() { }

public RESTRC_04c5986b32c7822f033c933cf71b96bd (RC_04c5986b32c7822f033c933cf71b96bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
  }
}

public static RC_04c5986b32c7822f033c933cf71b96bd ToStructure(ssConectaProveedores.RestRecords.RESTRC_04c5986b32c7822f033c933cf71b96bd obj) { 
  RC_04c5986b32c7822f033c933cf71b96bd s = new RC_04c5986b32c7822f033c933cf71b96bd();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  }
  return s;
}

public static Func<RC_04c5986b32c7822f033c933cf71b96bd, ssConectaProveedores.RestRecords.RESTRC_04c5986b32c7822f033c933cf71b96bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04c5986b32c7822f033c933cf71b96bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_04c5986b32c7822f033c933cf71b96bd FromStructure(RC_04c5986b32c7822f033c933cf71b96bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_04c5986b32c7822f033c933cf71b96bd(s, config);
}

}


