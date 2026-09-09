using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFilesAuditRecord
public class JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc : AbstractRESTStructure<RC_1a5b8cd0ef1115d2fdd242fac41124bc> {
[JsonProperty("InvoiceFilesAudit")]
[JsonPropertyName("InvoiceFilesAudit")]
public ssConectaProveedores.RestRecords.JSONST_29dc80a5deae2388e31181e1082143cfStructure AttrInvoiceFilesAudit;

public JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc() { }

public JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc (RC_1a5b8cd0ef1115d2fdd242fac41124bc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFilesAudit = ConvertToRestWithoutDefaults(s.ssSTInvoiceFilesAudit, new ST_29dc80a5deae2388e31181e1082143cfStructure(), ssConectaProveedores.RestRecords.JSONST_29dc80a5deae2388e31181e1082143cfStructure.FromStructure, config);
  } else {
AttrInvoiceFilesAudit = ssConectaProveedores.RestRecords.JSONST_29dc80a5deae2388e31181e1082143cfStructure.FromStructure(s.ssSTInvoiceFilesAudit, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc, RC_1a5b8cd0ef1115d2fdd242fac41124bc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc s) => ToStructure(s, config);
}
public static RC_1a5b8cd0ef1115d2fdd242fac41124bc ToStructure(ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc obj, IBehaviorsConfiguration config) { 
  RC_1a5b8cd0ef1115d2fdd242fac41124bc s = new RC_1a5b8cd0ef1115d2fdd242fac41124bc();
  if(obj != null) {
  s.ssSTInvoiceFilesAudit = ssConectaProveedores.RestRecords.JSONST_29dc80a5deae2388e31181e1082143cfStructure.ToStructure(obj.AttrInvoiceFilesAudit, config);
  }
  return s;
}

public static Func<RC_1a5b8cd0ef1115d2fdd242fac41124bc, ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_1a5b8cd0ef1115d2fdd242fac41124bc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc FromStructure(RC_1a5b8cd0ef1115d2fdd242fac41124bc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_1a5b8cd0ef1115d2fdd242fac41124bc(s, config);
}

}


