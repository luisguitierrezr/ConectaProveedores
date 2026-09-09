using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionsListInternalTableStructureRecord
public class RESTRC_105c7a29498e4d7d103db2d1d51b10b3 : AbstractRESTStructure<RC_105c7a29498e4d7d103db2d1d51b10b3> {
[JsonProperty("RequisitionsListInternalTableStructure")]
public ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure AttrRequisitionsListInternalTableStructure;

public RESTRC_105c7a29498e4d7d103db2d1d51b10b3() { }

public RESTRC_105c7a29498e4d7d103db2d1d51b10b3 (RC_105c7a29498e4d7d103db2d1d51b10b3 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionsListInternalTableStructure = ConvertToRestWithoutDefaults(s.ssSTRequisitionsListInternalTableStructure, new ST_291bf3fef8932fa1af5104e6982c4da9Structure(), ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure.FromStructure, config);
  } else {
AttrRequisitionsListInternalTableStructure = ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure.FromStructure(s.ssSTRequisitionsListInternalTableStructure, config);
  }
}

public static RC_105c7a29498e4d7d103db2d1d51b10b3 ToStructure(ssConectaProveedores.RestRecords.RESTRC_105c7a29498e4d7d103db2d1d51b10b3 obj) { 
  RC_105c7a29498e4d7d103db2d1d51b10b3 s = new RC_105c7a29498e4d7d103db2d1d51b10b3();
  if(obj != null) {
  s.ssSTRequisitionsListInternalTableStructure = ssConectaProveedores.RestRecords.RESTST_291bf3fef8932fa1af5104e6982c4da9Structure.ToStructure(obj.AttrRequisitionsListInternalTableStructure);
  }
  return s;
}

public static Func<RC_105c7a29498e4d7d103db2d1d51b10b3, ssConectaProveedores.RestRecords.RESTRC_105c7a29498e4d7d103db2d1d51b10b3> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_105c7a29498e4d7d103db2d1d51b10b3 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_105c7a29498e4d7d103db2d1d51b10b3 FromStructure(RC_105c7a29498e4d7d103db2d1d51b10b3 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_105c7a29498e4d7d103db2d1d51b10b3(s, config);
}

}


