using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileApprovalRecord
public class JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5 : AbstractRESTStructure<RC_64c70b8a3f72d1283f18a3da8f8eb3d5> {
[JsonProperty("OrderRequestFileApproval")]
[JsonPropertyName("OrderRequestFileApproval")]
public ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord AttrOrderRequestFileApproval;

public JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5() { }

public JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5 (RC_64c70b8a3f72d1283f18a3da8f8eb3d5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFileApproval = ConvertToRestWithoutDefaults(s.ssENOrderRequestFileApproval, new EN_1710c672f4d7138b664ee1411114271eEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.FromStructure(s.ssENOrderRequestFileApproval, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5, RC_64c70b8a3f72d1283f18a3da8f8eb3d5> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5 s) => ToStructure(s, config);
}
public static RC_64c70b8a3f72d1283f18a3da8f8eb3d5 ToStructure(ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5 obj, IBehaviorsConfiguration config) { 
  RC_64c70b8a3f72d1283f18a3da8f8eb3d5 s = new RC_64c70b8a3f72d1283f18a3da8f8eb3d5();
  if(obj != null) {
  s.ssENOrderRequestFileApproval = ssConectaProveedores.RestRecords.JSONEN_1710c672f4d7138b664ee1411114271eEntityRecord.ToStructure(obj.AttrOrderRequestFileApproval, config);
  }
  return s;
}

public static Func<RC_64c70b8a3f72d1283f18a3da8f8eb3d5, ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_64c70b8a3f72d1283f18a3da8f8eb3d5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5 FromStructure(RC_64c70b8a3f72d1283f18a3da8f8eb3d5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_64c70b8a3f72d1283f18a3da8f8eb3d5(s, config);
}

}


