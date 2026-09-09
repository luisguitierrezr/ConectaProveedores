using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceFileStructRecord
public class RESTRC_70fa652e74d85e31a0b3b094a20bcd92 : AbstractRESTStructure<RC_70fa652e74d85e31a0b3b094a20bcd92> {
[JsonProperty("InvoiceFileStruct")]
public ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure AttrInvoiceFileStruct;

public RESTRC_70fa652e74d85e31a0b3b094a20bcd92() { }

public RESTRC_70fa652e74d85e31a0b3b094a20bcd92 (RC_70fa652e74d85e31a0b3b094a20bcd92 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoiceFileStruct = ConvertToRestWithoutDefaults(s.ssSTInvoiceFileStruct, new ST_7837994e68174a4794f15e4233b48555Structure(), ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.FromStructure, config);
  } else {
AttrInvoiceFileStruct = ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.FromStructure(s.ssSTInvoiceFileStruct, config);
  }
}

public static RC_70fa652e74d85e31a0b3b094a20bcd92 ToStructure(ssConectaProveedores.RestRecords.RESTRC_70fa652e74d85e31a0b3b094a20bcd92 obj) { 
  RC_70fa652e74d85e31a0b3b094a20bcd92 s = new RC_70fa652e74d85e31a0b3b094a20bcd92();
  if(obj != null) {
  s.ssSTInvoiceFileStruct = ssConectaProveedores.RestRecords.RESTST_7837994e68174a4794f15e4233b48555Structure.ToStructure(obj.AttrInvoiceFileStruct);
  }
  return s;
}

public static Func<RC_70fa652e74d85e31a0b3b094a20bcd92, ssConectaProveedores.RestRecords.RESTRC_70fa652e74d85e31a0b3b094a20bcd92> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_70fa652e74d85e31a0b3b094a20bcd92 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_70fa652e74d85e31a0b3b094a20bcd92 FromStructure(RC_70fa652e74d85e31a0b3b094a20bcd92 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_70fa652e74d85e31a0b3b094a20bcd92(s, config);
}

}


