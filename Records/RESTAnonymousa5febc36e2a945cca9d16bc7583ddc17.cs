using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48Record
public class RESTRC_7317bc524644d05efff768dccb02d1e1 : AbstractRESTStructure<RC_7317bc524644d05efff768dccb02d1e1> {
[JsonProperty("InvoicesReport48")]
public ssConectaProveedores.RestRecords.RESTST_c882e4a9305466afcdc9cd6a9ad70f15Structure AttrInvoicesReport48;

public RESTRC_7317bc524644d05efff768dccb02d1e1() { }

public RESTRC_7317bc524644d05efff768dccb02d1e1 (RC_7317bc524644d05efff768dccb02d1e1 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48 = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48, new ST_c882e4a9305466afcdc9cd6a9ad70f15Structure(), ssConectaProveedores.RestRecords.RESTST_c882e4a9305466afcdc9cd6a9ad70f15Structure.FromStructure, config);
  } else {
AttrInvoicesReport48 = ssConectaProveedores.RestRecords.RESTST_c882e4a9305466afcdc9cd6a9ad70f15Structure.FromStructure(s.ssSTInvoicesReport48, config);
  }
}

public static RC_7317bc524644d05efff768dccb02d1e1 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7317bc524644d05efff768dccb02d1e1 obj) { 
  RC_7317bc524644d05efff768dccb02d1e1 s = new RC_7317bc524644d05efff768dccb02d1e1();
  if(obj != null) {
  s.ssSTInvoicesReport48 = ssConectaProveedores.RestRecords.RESTST_c882e4a9305466afcdc9cd6a9ad70f15Structure.ToStructure(obj.AttrInvoicesReport48);
  }
  return s;
}

public static Func<RC_7317bc524644d05efff768dccb02d1e1, ssConectaProveedores.RestRecords.RESTRC_7317bc524644d05efff768dccb02d1e1> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7317bc524644d05efff768dccb02d1e1 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7317bc524644d05efff768dccb02d1e1 FromStructure(RC_7317bc524644d05efff768dccb02d1e1 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7317bc524644d05efff768dccb02d1e1(s, config);
}

}


