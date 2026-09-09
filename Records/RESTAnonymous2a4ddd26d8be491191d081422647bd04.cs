using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccountableGuideRecord
public class RESTRC_5529030b7e85f68f6007e4d32f650ef7 : AbstractRESTStructure<RC_5529030b7e85f68f6007e4d32f650ef7> {
[JsonProperty("AccountableGuide")]
public ssConectaProveedores.RestRecords.RESTEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord AttrAccountableGuide;

public RESTRC_5529030b7e85f68f6007e4d32f650ef7() { }

public RESTRC_5529030b7e85f68f6007e4d32f650ef7 (RC_5529030b7e85f68f6007e4d32f650ef7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountableGuide = ConvertToRestWithoutDefaults(s.ssENAccountableGuide, new EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.FromStructure, config);
  } else {
AttrAccountableGuide = ssConectaProveedores.RestRecords.RESTEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.FromStructure(s.ssENAccountableGuide, config);
  }
}

public static RC_5529030b7e85f68f6007e4d32f650ef7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7 obj) { 
  RC_5529030b7e85f68f6007e4d32f650ef7 s = new RC_5529030b7e85f68f6007e4d32f650ef7();
  if(obj != null) {
  s.ssENAccountableGuide = ssConectaProveedores.RestRecords.RESTEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.ToStructure(obj.AttrAccountableGuide);
  }
  return s;
}

public static Func<RC_5529030b7e85f68f6007e4d32f650ef7, ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5529030b7e85f68f6007e4d32f650ef7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7 FromStructure(RC_5529030b7e85f68f6007e4d32f650ef7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7(s, config);
}

}


