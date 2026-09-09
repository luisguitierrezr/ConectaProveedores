using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ProcessTypeDatesAllowedRecord
public class JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b : AbstractRESTStructure<RC_c808f777f2a76c70ea9a3f0e560c6a3b> {
[JsonProperty("ProcessTypeDatesAllowed")]
[JsonPropertyName("ProcessTypeDatesAllowed")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_280cfaefc7654494be27c153014e657dEntityRecord AttrProcessTypeDatesAllowed;

public JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b() { }

public JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b (RC_c808f777f2a76c70ea9a3f0e560c6a3b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessTypeDatesAllowed = ConvertToRestWithoutDefaults(s.ssENProcessTypeDatesAllowed, new EN_280cfaefc7654494be27c153014e657dEntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_280cfaefc7654494be27c153014e657dEntityRecord.FromStructure, config);
  } else {
AttrProcessTypeDatesAllowed = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_280cfaefc7654494be27c153014e657dEntityRecord.FromStructure(s.ssENProcessTypeDatesAllowed, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b, RC_c808f777f2a76c70ea9a3f0e560c6a3b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b s) => ToStructure(s, config);
}
public static RC_c808f777f2a76c70ea9a3f0e560c6a3b ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b obj, IBehaviorsConfiguration config) { 
  RC_c808f777f2a76c70ea9a3f0e560c6a3b s = new RC_c808f777f2a76c70ea9a3f0e560c6a3b();
  if(obj != null) {
  s.ssENProcessTypeDatesAllowed = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_280cfaefc7654494be27c153014e657dEntityRecord.ToStructure(obj.AttrProcessTypeDatesAllowed, config);
  }
  return s;
}

public static Func<RC_c808f777f2a76c70ea9a3f0e560c6a3b, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c808f777f2a76c70ea9a3f0e560c6a3b s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b FromStructure(RC_c808f777f2a76c70ea9a3f0e560c6a3b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c808f777f2a76c70ea9a3f0e560c6a3b(s, config);
}

}


