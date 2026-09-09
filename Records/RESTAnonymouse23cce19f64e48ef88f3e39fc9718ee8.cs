using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TelcelDirectionIdRecord
public class RESTRC_3756803ceb487b3262b6a7da245b8a74 : AbstractRESTStructure<RC_3756803ceb487b3262b6a7da245b8a74> {
[JsonProperty("TelcelDirectionId")]
public long? AttrTelcelDirectionId;

public RESTRC_3756803ceb487b3262b6a7da245b8a74() { }

public RESTRC_3756803ceb487b3262b6a7da245b8a74 (RC_3756803ceb487b3262b6a7da245b8a74 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTelcelDirectionId = ConvertToRestWithoutDefaults(s.ssTelcelDirectionId, 0L);
  } else {
AttrTelcelDirectionId = (long?) s.ssTelcelDirectionId;
  }
}

public static RC_3756803ceb487b3262b6a7da245b8a74 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3756803ceb487b3262b6a7da245b8a74 obj) { 
  RC_3756803ceb487b3262b6a7da245b8a74 s = new RC_3756803ceb487b3262b6a7da245b8a74();
  if(obj != null) {
  s.ssTelcelDirectionId = obj.AttrTelcelDirectionId == null ? 0L : obj.AttrTelcelDirectionId.Value;
  }
  return s;
}

public static Func<RC_3756803ceb487b3262b6a7da245b8a74, ssConectaProveedores.RestRecords.RESTRC_3756803ceb487b3262b6a7da245b8a74> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3756803ceb487b3262b6a7da245b8a74 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3756803ceb487b3262b6a7da245b8a74 FromStructure(RC_3756803ceb487b3262b6a7da245b8a74 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3756803ceb487b3262b6a7da245b8a74(s, config);
}

}


