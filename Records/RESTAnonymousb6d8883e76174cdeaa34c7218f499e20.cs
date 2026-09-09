using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceStatusRecord
public class RESTRC_6edb17c5bf63452ff4ac24d41991a940 : AbstractRESTStructure<RC_6edb17c5bf63452ff4ac24d41991a940> {
[JsonProperty("InvoiceStatus")]
public ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord AttrInvoiceStatus;

public RESTRC_6edb17c5bf63452ff4ac24d41991a940() { }

public RESTRC_6edb17c5bf63452ff4ac24d41991a940 (RC_6edb17c5bf63452ff4ac24d41991a940 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceStatus = ConvertToRestWithoutDefaults(s.ssENInvoiceStatus, new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure, config);
  } else {
AttrInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.FromStructure(s.ssENInvoiceStatus, config);
  }
}

public static RC_6edb17c5bf63452ff4ac24d41991a940 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940 obj) { 
  RC_6edb17c5bf63452ff4ac24d41991a940 s = new RC_6edb17c5bf63452ff4ac24d41991a940();
  if(obj != null) {
  s.ssENInvoiceStatus = ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord.ToStructure(obj.AttrInvoiceStatus);
  }
  return s;
}

public static Func<RC_6edb17c5bf63452ff4ac24d41991a940, ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6edb17c5bf63452ff4ac24d41991a940 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940 FromStructure(RC_6edb17c5bf63452ff4ac24d41991a940 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940(s, config);
}

}


