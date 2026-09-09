using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceStatusRecord
public class JSONRC_cad676a01e44d775889bfdee9f2eda1f : AbstractRESTStructure<RC_cad676a01e44d775889bfdee9f2eda1f> {
[JsonProperty("Invoice")]
[JsonPropertyName("Invoice")]
public ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public JSONRC_cad676a01e44d775889bfdee9f2eda1f() { }

public JSONRC_cad676a01e44d775889bfdee9f2eda1f (RC_cad676a01e44d775889bfdee9f2eda1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f, RC_cad676a01e44d775889bfdee9f2eda1f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f s) => ToStructure(s, config);
}
public static RC_cad676a01e44d775889bfdee9f2eda1f ToStructure(ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f obj, IBehaviorsConfiguration config) { 
  RC_cad676a01e44d775889bfdee9f2eda1f s = new RC_cad676a01e44d775889bfdee9f2eda1f();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.JSONEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice, config);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  }
  return s;
}

public static Func<RC_cad676a01e44d775889bfdee9f2eda1f, ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cad676a01e44d775889bfdee9f2eda1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f FromStructure(RC_cad676a01e44d775889bfdee9f2eda1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_cad676a01e44d775889bfdee9f2eda1f(s, config);
}

}


