using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatusRecord
public class JSONRC_6edb17c5bf63452ff4ac24d41991a940 : AbstractRESTStructure<RC_6edb17c5bf63452ff4ac24d41991a940> {
[JsonProperty("InvoiceStatus")]
[JsonPropertyName("InvoiceStatus")]
public ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public JSONRC_6edb17c5bf63452ff4ac24d41991a940() { }

public JSONRC_6edb17c5bf63452ff4ac24d41991a940 (RC_6edb17c5bf63452ff4ac24d41991a940 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940, RC_6edb17c5bf63452ff4ac24d41991a940> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940 s) => ToStructure(s, config);
}
public static RC_6edb17c5bf63452ff4ac24d41991a940 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940 obj, IBehaviorsConfiguration config) { 
  RC_6edb17c5bf63452ff4ac24d41991a940 s = new RC_6edb17c5bf63452ff4ac24d41991a940();
  if(obj != null) {
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.JSONEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus, config);
  }
  return s;
}

public static Func<RC_6edb17c5bf63452ff4ac24d41991a940, ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6edb17c5bf63452ff4ac24d41991a940 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940 FromStructure(RC_6edb17c5bf63452ff4ac24d41991a940 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6edb17c5bf63452ff4ac24d41991a940(s, config);
}

}


