using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ResultRecord
public class RESTRC_ea55d9469159caabdb6018b439e3950d : AbstractRESTStructure<RC_ea55d9469159caabdb6018b439e3950d> {
[JsonProperty("Result")]
public ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure AttrResult;

public RESTRC_ea55d9469159caabdb6018b439e3950d() { }

public RESTRC_ea55d9469159caabdb6018b439e3950d (RC_ea55d9469159caabdb6018b439e3950d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrResult = ConvertToRestWithoutDefaults(s.ssSTResult, new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure(), ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure.FromStructure, config);
  } else {
AttrResult = ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure.FromStructure(s.ssSTResult, config);
  }
}

public static RC_ea55d9469159caabdb6018b439e3950d ToStructure(ssConectaProveedores.RestRecords.RESTRC_ea55d9469159caabdb6018b439e3950d obj) { 
  RC_ea55d9469159caabdb6018b439e3950d s = new RC_ea55d9469159caabdb6018b439e3950d();
  if(obj != null) {
  s.ssSTResult = ssConectaProveedores.RestRecords.RESTST_38509e9fbd36a9b928c2f4e34a1342aeStructure.ToStructure(obj.AttrResult);
  }
  return s;
}

public static Func<RC_ea55d9469159caabdb6018b439e3950d, ssConectaProveedores.RestRecords.RESTRC_ea55d9469159caabdb6018b439e3950d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ea55d9469159caabdb6018b439e3950d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ea55d9469159caabdb6018b439e3950d FromStructure(RC_ea55d9469159caabdb6018b439e3950d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ea55d9469159caabdb6018b439e3950d(s, config);
}

}


