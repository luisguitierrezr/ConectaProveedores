using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceRecord
public class JSONRC_04c5986b32c7822f033c933cf71b96bd : AbstractRESTStructure<RC_04c5986b32c7822f033c933cf71b96bd> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

public JSONRC_04c5986b32c7822f033c933cf71b96bd() { }

public JSONRC_04c5986b32c7822f033c933cf71b96bd (RC_04c5986b32c7822f033c933cf71b96bd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd, RC_04c5986b32c7822f033c933cf71b96bd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd s) => ToStructure(s, config);
}
public static RC_04c5986b32c7822f033c933cf71b96bd ToStructure(ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd obj, IBehaviorsConfiguration config) { 
  RC_04c5986b32c7822f033c933cf71b96bd s = new RC_04c5986b32c7822f033c933cf71b96bd();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  }
  return s;
}

public static Func<RC_04c5986b32c7822f033c933cf71b96bd, ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_04c5986b32c7822f033c933cf71b96bd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd FromStructure(RC_04c5986b32c7822f033c933cf71b96bd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_04c5986b32c7822f033c933cf71b96bd(s, config);
}

}


