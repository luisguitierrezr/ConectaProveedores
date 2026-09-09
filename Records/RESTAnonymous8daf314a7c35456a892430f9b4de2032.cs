using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RowsRecord
public class RESTRC_90f26addd0e4ccd849615a93fb01d4c5 : AbstractRESTStructure<RC_90f26addd0e4ccd849615a93fb01d4c5> {
[JsonProperty("Rows")]
public ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure AttrRows;

public RESTRC_90f26addd0e4ccd849615a93fb01d4c5() { }

public RESTRC_90f26addd0e4ccd849615a93fb01d4c5 (RC_90f26addd0e4ccd849615a93fb01d4c5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRows = ConvertToRestWithoutDefaults(s.ssSTRows, new ST_3fd667dc2513888f6027df59e05def3fStructure(), ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.FromStructure, config);
  } else {
AttrRows = ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.FromStructure(s.ssSTRows, config);
  }
}

public static RC_90f26addd0e4ccd849615a93fb01d4c5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_90f26addd0e4ccd849615a93fb01d4c5 obj) { 
  RC_90f26addd0e4ccd849615a93fb01d4c5 s = new RC_90f26addd0e4ccd849615a93fb01d4c5();
  if(obj != null) {
  s.ssSTRows = ssConectaProveedores.RestRecords.RESTST_3fd667dc2513888f6027df59e05def3fStructure.ToStructure(obj.AttrRows);
  }
  return s;
}

public static Func<RC_90f26addd0e4ccd849615a93fb01d4c5, ssConectaProveedores.RestRecords.RESTRC_90f26addd0e4ccd849615a93fb01d4c5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_90f26addd0e4ccd849615a93fb01d4c5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_90f26addd0e4ccd849615a93fb01d4c5 FromStructure(RC_90f26addd0e4ccd849615a93fb01d4c5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_90f26addd0e4ccd849615a93fb01d4c5(s, config);
}

}


