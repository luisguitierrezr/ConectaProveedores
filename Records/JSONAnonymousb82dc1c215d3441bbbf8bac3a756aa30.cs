using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRetentionTypeRecord
public class JSONRC_59361fc2fe27e83d1af47e8e07392a42 : AbstractRESTStructure<RC_59361fc2fe27e83d1af47e8e07392a42> {
[JsonProperty("OrderRetentionType")]
[JsonPropertyName("OrderRetentionType")]
public ssConectaProveedores.RestRecords.JSONEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord AttrOrderRetentionType;

public JSONRC_59361fc2fe27e83d1af47e8e07392a42() { }

public JSONRC_59361fc2fe27e83d1af47e8e07392a42 (RC_59361fc2fe27e83d1af47e8e07392a42 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRetentionType = ConvertToRestWithoutDefaults(s.ssENOrderRetentionType, new EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.FromStructure, config);
  } else {
AttrOrderRetentionType = ssConectaProveedores.RestRecords.JSONEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.FromStructure(s.ssENOrderRetentionType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42, RC_59361fc2fe27e83d1af47e8e07392a42> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42 s) => ToStructure(s, config);
}
public static RC_59361fc2fe27e83d1af47e8e07392a42 ToStructure(ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42 obj, IBehaviorsConfiguration config) { 
  RC_59361fc2fe27e83d1af47e8e07392a42 s = new RC_59361fc2fe27e83d1af47e8e07392a42();
  if(obj != null) {
  s.ssENOrderRetentionType = ssConectaProveedores.RestRecords.JSONEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.ToStructure(obj.AttrOrderRetentionType, config);
  }
  return s;
}

public static Func<RC_59361fc2fe27e83d1af47e8e07392a42, ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_59361fc2fe27e83d1af47e8e07392a42 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42 FromStructure(RC_59361fc2fe27e83d1af47e8e07392a42 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_59361fc2fe27e83d1af47e8e07392a42(s, config);
}

}


