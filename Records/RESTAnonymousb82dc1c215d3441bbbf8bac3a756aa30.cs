using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderRetentionTypeRecord
public class RESTRC_59361fc2fe27e83d1af47e8e07392a42 : AbstractRESTStructure<RC_59361fc2fe27e83d1af47e8e07392a42> {
[JsonProperty("OrderRetentionType")]
public ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord AttrOrderRetentionType;

public RESTRC_59361fc2fe27e83d1af47e8e07392a42() { }

public RESTRC_59361fc2fe27e83d1af47e8e07392a42 (RC_59361fc2fe27e83d1af47e8e07392a42 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderRetentionType = ConvertToRestWithoutDefaults(s.ssENOrderRetentionType, new EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.FromStructure, config);
  } else {
AttrOrderRetentionType = ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.FromStructure(s.ssENOrderRetentionType, config);
  }
}

public static RC_59361fc2fe27e83d1af47e8e07392a42 ToStructure(ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42 obj) { 
  RC_59361fc2fe27e83d1af47e8e07392a42 s = new RC_59361fc2fe27e83d1af47e8e07392a42();
  if(obj != null) {
  s.ssENOrderRetentionType = ssConectaProveedores.RestRecords.RESTEN_4687fb2520dfeecb0ed6626cf8701229EntityRecord.ToStructure(obj.AttrOrderRetentionType);
  }
  return s;
}

public static Func<RC_59361fc2fe27e83d1af47e8e07392a42, ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_59361fc2fe27e83d1af47e8e07392a42 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42 FromStructure(RC_59361fc2fe27e83d1af47e8e07392a42 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42(s, config);
}

}


