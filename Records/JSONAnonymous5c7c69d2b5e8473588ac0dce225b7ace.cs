using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileStructRecord
public class JSONRC_70fa652e74d85e31a0b3b094a20bcd92 : AbstractRESTStructure<RC_70fa652e74d85e31a0b3b094a20bcd92> {
[JsonProperty("InvoiceFileStruct")]
[JsonPropertyName("InvoiceFileStruct")]
public ssConectaProveedores.RestRecords.JSONST_7837994e68174a4794f15e4233b48555Structure AttrInvoiceFileStruct;

public JSONRC_70fa652e74d85e31a0b3b094a20bcd92() { }

public JSONRC_70fa652e74d85e31a0b3b094a20bcd92 (RC_70fa652e74d85e31a0b3b094a20bcd92 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFileStruct = ConvertToRestWithoutDefaults(s.ssSTInvoiceFileStruct, new ST_7837994e68174a4794f15e4233b48555Structure(), ssConectaProveedores.RestRecords.JSONST_7837994e68174a4794f15e4233b48555Structure.FromStructure, config);
  } else {
AttrInvoiceFileStruct = ssConectaProveedores.RestRecords.JSONST_7837994e68174a4794f15e4233b48555Structure.FromStructure(s.ssSTInvoiceFileStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92, RC_70fa652e74d85e31a0b3b094a20bcd92> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92 s) => ToStructure(s, config);
}
public static RC_70fa652e74d85e31a0b3b094a20bcd92 ToStructure(ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92 obj, IBehaviorsConfiguration config) { 
  RC_70fa652e74d85e31a0b3b094a20bcd92 s = new RC_70fa652e74d85e31a0b3b094a20bcd92();
  if(obj != null) {
  s.ssSTInvoiceFileStruct = ssConectaProveedores.RestRecords.JSONST_7837994e68174a4794f15e4233b48555Structure.ToStructure(obj.AttrInvoiceFileStruct, config);
  }
  return s;
}

public static Func<RC_70fa652e74d85e31a0b3b094a20bcd92, ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_70fa652e74d85e31a0b3b094a20bcd92 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92 FromStructure(RC_70fa652e74d85e31a0b3b094a20bcd92 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_70fa652e74d85e31a0b3b094a20bcd92(s, config);
}

}


