using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedRecord
public class JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873 : AbstractRESTStructure<RC_fbe3f1050ad4f34fa0e0a15f88a56873> {
[JsonProperty("InvoiceExtended")]
[JsonPropertyName("InvoiceExtended")]
public ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873() { }

public JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873 (RC_fbe3f1050ad4f34fa0e0a15f88a56873 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873, RC_fbe3f1050ad4f34fa0e0a15f88a56873> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873 s) => ToStructure(s, config);
}
public static RC_fbe3f1050ad4f34fa0e0a15f88a56873 ToStructure(ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873 obj, IBehaviorsConfiguration config) { 
  RC_fbe3f1050ad4f34fa0e0a15f88a56873 s = new RC_fbe3f1050ad4f34fa0e0a15f88a56873();
  if(obj != null) {
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.JSONEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended, config);
  }
  return s;
}

public static Func<RC_fbe3f1050ad4f34fa0e0a15f88a56873, ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fbe3f1050ad4f34fa0e0a15f88a56873 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873 FromStructure(RC_fbe3f1050ad4f34fa0e0a15f88a56873 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fbe3f1050ad4f34fa0e0a15f88a56873(s, config);
}

}


