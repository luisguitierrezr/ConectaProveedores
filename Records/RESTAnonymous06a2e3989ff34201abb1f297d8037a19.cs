using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ActionTimestampsRecord
public class RESTRC_00310a262abd8758c59d6849f2a2be40 : AbstractRESTStructure<RC_00310a262abd8758c59d6849f2a2be40> {
[JsonProperty("ActionTimestamps")]
public ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord AttrActionTimestamps;

public RESTRC_00310a262abd8758c59d6849f2a2be40() { }

public RESTRC_00310a262abd8758c59d6849f2a2be40 (RC_00310a262abd8758c59d6849f2a2be40 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrActionTimestamps = ConvertToRestWithoutDefaults(s.ssENActionTimestamps, new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord.FromStructure, config);
  } else {
AttrActionTimestamps = ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord.FromStructure(s.ssENActionTimestamps, config);
  }
}

public static RC_00310a262abd8758c59d6849f2a2be40 ToStructure(ssConectaProveedores.RestRecords.RESTRC_00310a262abd8758c59d6849f2a2be40 obj) { 
  RC_00310a262abd8758c59d6849f2a2be40 s = new RC_00310a262abd8758c59d6849f2a2be40();
  if(obj != null) {
  s.ssENActionTimestamps = ssConectaProveedores.RestRecords.RESTEN_b22d64c90281d09a316b6f4502a74326EntityRecord.ToStructure(obj.AttrActionTimestamps);
  }
  return s;
}

public static Func<RC_00310a262abd8758c59d6849f2a2be40, ssConectaProveedores.RestRecords.RESTRC_00310a262abd8758c59d6849f2a2be40> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_00310a262abd8758c59d6849f2a2be40 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_00310a262abd8758c59d6849f2a2be40 FromStructure(RC_00310a262abd8758c59d6849f2a2be40 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_00310a262abd8758c59d6849f2a2be40(s, config);
}

}


