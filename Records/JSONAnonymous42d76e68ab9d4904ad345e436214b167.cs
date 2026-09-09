using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ResultRecord
public class JSONRC_ea55d9469159caabdb6018b439e3950d : AbstractRESTStructure<RC_ea55d9469159caabdb6018b439e3950d> {
[JsonProperty("Result")]
[JsonPropertyName("Result")]
public ssConectaProveedores.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure AttrResult;

public JSONRC_ea55d9469159caabdb6018b439e3950d() { }

public JSONRC_ea55d9469159caabdb6018b439e3950d (RC_ea55d9469159caabdb6018b439e3950d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrResult = ConvertToRestWithoutDefaults(s.ssSTResult, new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure(), ssConectaProveedores.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure.FromStructure, config);
  } else {
AttrResult = ssConectaProveedores.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure.FromStructure(s.ssSTResult, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d, RC_ea55d9469159caabdb6018b439e3950d> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d s) => ToStructure(s, config);
}
public static RC_ea55d9469159caabdb6018b439e3950d ToStructure(ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d obj, IBehaviorsConfiguration config) { 
  RC_ea55d9469159caabdb6018b439e3950d s = new RC_ea55d9469159caabdb6018b439e3950d();
  if(obj != null) {
  s.ssSTResult = ssConectaProveedores.RestRecords.JSONST_38509e9fbd36a9b928c2f4e34a1342aeStructure.ToStructure(obj.AttrResult, config);
  }
  return s;
}

public static Func<RC_ea55d9469159caabdb6018b439e3950d, ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ea55d9469159caabdb6018b439e3950d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d FromStructure(RC_ea55d9469159caabdb6018b439e3950d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_ea55d9469159caabdb6018b439e3950d(s, config);
}

}


