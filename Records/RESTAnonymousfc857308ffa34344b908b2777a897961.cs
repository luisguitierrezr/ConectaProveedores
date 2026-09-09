using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceInvoiceStatusRecord
public class RESTRC_cad676a01e44d775889bfdee9f2eda1f : AbstractRESTStructure<RC_cad676a01e44d775889bfdee9f2eda1f> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public RESTRC_cad676a01e44d775889bfdee9f2eda1f() { }

public RESTRC_cad676a01e44d775889bfdee9f2eda1f (RC_cad676a01e44d775889bfdee9f2eda1f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static RC_cad676a01e44d775889bfdee9f2eda1f ToStructure(ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f obj) { 
  RC_cad676a01e44d775889bfdee9f2eda1f s = new RC_cad676a01e44d775889bfdee9f2eda1f();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  }
  return s;
}

public static Func<RC_cad676a01e44d775889bfdee9f2eda1f, ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cad676a01e44d775889bfdee9f2eda1f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f FromStructure(RC_cad676a01e44d775889bfdee9f2eda1f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f(s, config);
}

}


