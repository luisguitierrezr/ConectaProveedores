using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileOrderMainRecord
public class JSONRC_924fb1c0e7e255405c78f78b86a50c36 : AbstractRESTStructure<RC_924fb1c0e7e255405c78f78b86a50c36> {
[JsonProperty("OrderRequestFile")]
[JsonPropertyName("OrderRequestFile")]
public ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_924fb1c0e7e255405c78f78b86a50c36() { }

public JSONRC_924fb1c0e7e255405c78f78b86a50c36 (RC_924fb1c0e7e255405c78f78b86a50c36 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36, RC_924fb1c0e7e255405c78f78b86a50c36> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36 s) => ToStructure(s, config);
}
public static RC_924fb1c0e7e255405c78f78b86a50c36 ToStructure(ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36 obj, IBehaviorsConfiguration config) { 
  RC_924fb1c0e7e255405c78f78b86a50c36 s = new RC_924fb1c0e7e255405c78f78b86a50c36();
  if(obj != null) {
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.JSONEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_924fb1c0e7e255405c78f78b86a50c36, ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_924fb1c0e7e255405c78f78b86a50c36 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36 FromStructure(RC_924fb1c0e7e255405c78f78b86a50c36 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_924fb1c0e7e255405c78f78b86a50c36(s, config);
}

}


