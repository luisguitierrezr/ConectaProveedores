using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceExtendedRecord
public class RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873 : AbstractRESTStructure<RC_fbe3f1050ad4f34fa0e0a15f88a56873> {
[JsonProperty("InvoiceExtended")]
public ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord AttrInvoiceExtended;

public RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873() { }

public RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873 (RC_fbe3f1050ad4f34fa0e0a15f88a56873 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceExtended = ConvertToRestWithoutDefaults(s.ssENInvoiceExtended, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure, config);
  } else {
AttrInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.FromStructure(s.ssENInvoiceExtended, config);
  }
}

public static RC_fbe3f1050ad4f34fa0e0a15f88a56873 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873 obj) { 
  RC_fbe3f1050ad4f34fa0e0a15f88a56873 s = new RC_fbe3f1050ad4f34fa0e0a15f88a56873();
  if(obj != null) {
  s.ssENInvoiceExtended = ssConectaProveedores.RestRecords.RESTEN_f81a3d226103fd013068b8763798067aEntityRecord.ToStructure(obj.AttrInvoiceExtended);
  }
  return s;
}

public static Func<RC_fbe3f1050ad4f34fa0e0a15f88a56873, ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fbe3f1050ad4f34fa0e0a15f88a56873 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873 FromStructure(RC_fbe3f1050ad4f34fa0e0a15f88a56873 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fbe3f1050ad4f34fa0e0a15f88a56873(s, config);
}

}


