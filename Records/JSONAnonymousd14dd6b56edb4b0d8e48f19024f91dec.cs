using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceTaxTypeRecord
public class JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0 : AbstractRESTStructure<RC_68f99e3ed8896e3b241abe92cbb6c9b0> {
[JsonProperty("InvoiceTaxType")]
[JsonPropertyName("InvoiceTaxType")]
public ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord AttrInvoiceTaxType;

public JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0() { }

public JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0 (RC_68f99e3ed8896e3b241abe92cbb6c9b0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceTaxType = ConvertToRestWithoutDefaults(s.ssENInvoiceTaxType, new EN_cff5cb02ac5fe11578884acf37327af3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.FromStructure, config);
  } else {
AttrInvoiceTaxType = ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.FromStructure(s.ssENInvoiceTaxType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0, RC_68f99e3ed8896e3b241abe92cbb6c9b0> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0 s) => ToStructure(s, config);
}
public static RC_68f99e3ed8896e3b241abe92cbb6c9b0 ToStructure(ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0 obj, IBehaviorsConfiguration config) { 
  RC_68f99e3ed8896e3b241abe92cbb6c9b0 s = new RC_68f99e3ed8896e3b241abe92cbb6c9b0();
  if(obj != null) {
  s.ssENInvoiceTaxType = ssConectaProveedores.RestRecords.JSONEN_cff5cb02ac5fe11578884acf37327af3EntityRecord.ToStructure(obj.AttrInvoiceTaxType, config);
  }
  return s;
}

public static Func<RC_68f99e3ed8896e3b241abe92cbb6c9b0, ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_68f99e3ed8896e3b241abe92cbb6c9b0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0 FromStructure(RC_68f99e3ed8896e3b241abe92cbb6c9b0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_68f99e3ed8896e3b241abe92cbb6c9b0(s, config);
}

}


