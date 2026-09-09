using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AccountableGuideRecord
public class JSONRC_5529030b7e85f68f6007e4d32f650ef7 : AbstractRESTStructure<RC_5529030b7e85f68f6007e4d32f650ef7> {
[JsonProperty("AccountableGuide")]
[JsonPropertyName("AccountableGuide")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord AttrAccountableGuide;

public JSONRC_5529030b7e85f68f6007e4d32f650ef7() { }

public JSONRC_5529030b7e85f68f6007e4d32f650ef7 (RC_5529030b7e85f68f6007e4d32f650ef7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccountableGuide = ConvertToRestWithoutDefaults(s.ssENAccountableGuide, new EN_5330eb9d72d4150e1f1663e553394fb3EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.FromStructure, config);
  } else {
AttrAccountableGuide = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.FromStructure(s.ssENAccountableGuide, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7, RC_5529030b7e85f68f6007e4d32f650ef7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7 s) => ToStructure(s, config);
}
public static RC_5529030b7e85f68f6007e4d32f650ef7 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7 obj, IBehaviorsConfiguration config) { 
  RC_5529030b7e85f68f6007e4d32f650ef7 s = new RC_5529030b7e85f68f6007e4d32f650ef7();
  if(obj != null) {
  s.ssENAccountableGuide = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_5330eb9d72d4150e1f1663e553394fb3EntityRecord.ToStructure(obj.AttrAccountableGuide, config);
  }
  return s;
}

public static Func<RC_5529030b7e85f68f6007e4d32f650ef7, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5529030b7e85f68f6007e4d32f650ef7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7 FromStructure(RC_5529030b7e85f68f6007e4d32f650ef7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5529030b7e85f68f6007e4d32f650ef7(s, config);
}

}


