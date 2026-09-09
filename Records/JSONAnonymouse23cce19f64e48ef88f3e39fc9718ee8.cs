using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TelcelDirectionIdRecord
public class JSONRC_3756803ceb487b3262b6a7da245b8a74 : AbstractRESTStructure<RC_3756803ceb487b3262b6a7da245b8a74> {
[JsonProperty("TelcelDirectionId")]
[JsonPropertyName("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

public JSONRC_3756803ceb487b3262b6a7da245b8a74() { }

public JSONRC_3756803ceb487b3262b6a7da245b8a74 (RC_3756803ceb487b3262b6a7da245b8a74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
  } else {
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74, RC_3756803ceb487b3262b6a7da245b8a74> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74 s) => ToStructure(s, config);
}
public static RC_3756803ceb487b3262b6a7da245b8a74 ToStructure(ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74 obj, IBehaviorsConfiguration config) { 
  RC_3756803ceb487b3262b6a7da245b8a74 s = new RC_3756803ceb487b3262b6a7da245b8a74();
  if(obj != null) {
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  }
  return s;
}

public static Func<RC_3756803ceb487b3262b6a7da245b8a74, ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3756803ceb487b3262b6a7da245b8a74 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74 FromStructure(RC_3756803ceb487b3262b6a7da245b8a74 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_3756803ceb487b3262b6a7da245b8a74(s, config);
}

}


