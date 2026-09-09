using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRequestFileOrderMainRecord
public class RESTRC_924fb1c0e7e255405c78f78b86a50c36 : AbstractRESTStructure<RC_924fb1c0e7e255405c78f78b86a50c36> {
[JsonProperty("OrderRequestFile")]
public ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord AttrOrderRequestFile;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_924fb1c0e7e255405c78f78b86a50c36() { }

public RESTRC_924fb1c0e7e255405c78f78b86a50c36 (RC_924fb1c0e7e255405c78f78b86a50c36 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRequestFile = ConvertToRestWithoutDefaults(s.ssENOrderRequestFile, new EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.FromStructure(s.ssENOrderRequestFile, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_924fb1c0e7e255405c78f78b86a50c36 ToStructure(ssConectaProveedores.RestRecords.RESTRC_924fb1c0e7e255405c78f78b86a50c36 obj) { 
  RC_924fb1c0e7e255405c78f78b86a50c36 s = new RC_924fb1c0e7e255405c78f78b86a50c36();
  if(obj != null) {
  s.ssENOrderRequestFile = ssConectaProveedores.RestRecords.RESTEN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord.ToStructure(obj.AttrOrderRequestFile);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_924fb1c0e7e255405c78f78b86a50c36, ssConectaProveedores.RestRecords.RESTRC_924fb1c0e7e255405c78f78b86a50c36> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_924fb1c0e7e255405c78f78b86a50c36 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_924fb1c0e7e255405c78f78b86a50c36 FromStructure(RC_924fb1c0e7e255405c78f78b86a50c36 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_924fb1c0e7e255405c78f78b86a50c36(s, config);
}

}


