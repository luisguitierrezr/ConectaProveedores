using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48Record
public class JSONRC_7317bc524644d05efff768dccb02d1e1 : AbstractRESTStructure<RC_7317bc524644d05efff768dccb02d1e1> {
[JsonProperty("InvoicesReport48")]
[JsonPropertyName("InvoicesReport48")]
public ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure AttrInvoicesReport48;

public JSONRC_7317bc524644d05efff768dccb02d1e1() { }

public JSONRC_7317bc524644d05efff768dccb02d1e1 (RC_7317bc524644d05efff768dccb02d1e1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48 = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48, new ST_c882e4a9305466afcdc9cd6a9ad70f15Structure(), ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure.FromStructure, config);
  } else {
AttrInvoicesReport48 = ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure.FromStructure(s.ssSTInvoicesReport48, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1, RC_7317bc524644d05efff768dccb02d1e1> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1 s) => ToStructure(s, config);
}
public static RC_7317bc524644d05efff768dccb02d1e1 ToStructure(ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1 obj, IBehaviorsConfiguration config) { 
  RC_7317bc524644d05efff768dccb02d1e1 s = new RC_7317bc524644d05efff768dccb02d1e1();
  if(obj != null) {
  s.ssSTInvoicesReport48 = ssConectaProveedores.RestRecords.JSONST_c882e4a9305466afcdc9cd6a9ad70f15Structure.ToStructure(obj.AttrInvoicesReport48, config);
  }
  return s;
}

public static Func<RC_7317bc524644d05efff768dccb02d1e1, ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7317bc524644d05efff768dccb02d1e1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1 FromStructure(RC_7317bc524644d05efff768dccb02d1e1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_7317bc524644d05efff768dccb02d1e1(s, config);
}

}


