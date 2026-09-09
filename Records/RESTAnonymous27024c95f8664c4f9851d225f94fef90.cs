using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TotalRecord
public class RESTRC_e733222bc824981c762ab14c37fad18d : AbstractRESTStructure<RC_e733222bc824981c762ab14c37fad18d> {
[JsonProperty("Total")]
public ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure AttrTotal;

public RESTRC_e733222bc824981c762ab14c37fad18d() { }

public RESTRC_e733222bc824981c762ab14c37fad18d (RC_e733222bc824981c762ab14c37fad18d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotal = ConvertToRestWithoutDefaults(s.ssSTTotal, new ST_18874ac0b41f9a239dad794ccac4f8d3Structure(), ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure, config);
  } else {
AttrTotal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.FromStructure(s.ssSTTotal, config);
  }
}

public static RC_e733222bc824981c762ab14c37fad18d ToStructure(ssConectaProveedores.RestRecords.RESTRC_e733222bc824981c762ab14c37fad18d obj) { 
  RC_e733222bc824981c762ab14c37fad18d s = new RC_e733222bc824981c762ab14c37fad18d();
  if(obj != null) {
  s.ssSTTotal = ssConectaProveedores.RestRecords.RESTST_18874ac0b41f9a239dad794ccac4f8d3Structure.ToStructure(obj.AttrTotal);
  }
  return s;
}

public static Func<RC_e733222bc824981c762ab14c37fad18d, ssConectaProveedores.RestRecords.RESTRC_e733222bc824981c762ab14c37fad18d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e733222bc824981c762ab14c37fad18d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e733222bc824981c762ab14c37fad18d FromStructure(RC_e733222bc824981c762ab14c37fad18d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e733222bc824981c762ab14c37fad18d(s, config);
}

}


