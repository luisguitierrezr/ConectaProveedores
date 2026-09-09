using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RowsRecord
public class JSONRC_90f26addd0e4ccd849615a93fb01d4c5 : AbstractRESTStructure<RC_90f26addd0e4ccd849615a93fb01d4c5> {
[JsonProperty("Rows")]
[JsonPropertyName("Rows")]
public ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure AttrRows;

public JSONRC_90f26addd0e4ccd849615a93fb01d4c5() { }

public JSONRC_90f26addd0e4ccd849615a93fb01d4c5 (RC_90f26addd0e4ccd849615a93fb01d4c5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRows = ConvertToRestWithoutDefaults(s.ssSTRows, new ST_3fd667dc2513888f6027df59e05def3fStructure(), ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.FromStructure, config);
  } else {
AttrRows = ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.FromStructure(s.ssSTRows, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5, RC_90f26addd0e4ccd849615a93fb01d4c5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5 s) => ToStructure(s, config);
}
public static RC_90f26addd0e4ccd849615a93fb01d4c5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5 obj, IBehaviorsConfiguration config) { 
  RC_90f26addd0e4ccd849615a93fb01d4c5 s = new RC_90f26addd0e4ccd849615a93fb01d4c5();
  if(obj != null) {
  s.ssSTRows = ssConectaProveedores.RestRecords.JSONST_3fd667dc2513888f6027df59e05def3fStructure.ToStructure(obj.AttrRows, config);
  }
  return s;
}

public static Func<RC_90f26addd0e4ccd849615a93fb01d4c5, ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90f26addd0e4ccd849615a93fb01d4c5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5 FromStructure(RC_90f26addd0e4ccd849615a93fb01d4c5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_90f26addd0e4ccd849615a93fb01d4c5(s, config);
}

}


