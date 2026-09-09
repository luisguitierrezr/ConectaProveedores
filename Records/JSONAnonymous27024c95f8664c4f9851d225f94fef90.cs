using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TotalRecord
public class JSONRC_e733222bc824981c762ab14c37fad18d : AbstractRESTStructure<RC_e733222bc824981c762ab14c37fad18d> {
[JsonProperty("Total")]
[JsonPropertyName("Total")]
public ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrTotal;

public JSONRC_e733222bc824981c762ab14c37fad18d() { }

public JSONRC_e733222bc824981c762ab14c37fad18d (RC_e733222bc824981c762ab14c37fad18d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotal = ConvertToRestWithoutDefaults(s.ssSTTotal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
  } else {
AttrTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTTotal, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d, RC_e733222bc824981c762ab14c37fad18d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d s) => ToStructure(s, config);
}
public static RC_e733222bc824981c762ab14c37fad18d ToStructure(ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d obj, IBehaviorsConfiguration config) { 
  RC_e733222bc824981c762ab14c37fad18d s = new RC_e733222bc824981c762ab14c37fad18d();
  if(obj != null) {
  s.ssSTTotal = ssConectaProveedores.RestRecords.JSONST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrTotal, config);
  }
  return s;
}

public static Func<RC_e733222bc824981c762ab14c37fad18d, ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e733222bc824981c762ab14c37fad18d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d FromStructure(RC_e733222bc824981c762ab14c37fad18d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e733222bc824981c762ab14c37fad18d(s, config);
}

}


