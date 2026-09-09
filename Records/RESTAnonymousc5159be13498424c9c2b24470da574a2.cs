using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ProcessTypeDatesAllowedRecord
public class RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b : AbstractRESTStructure<RC_c808f777f2a76c70ea9a3f0e560c6a3b> {
[JsonProperty("ProcessTypeDatesAllowed")]
public ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord AttrProcessTypeDatesAllowed;

public RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b() { }

public RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b (RC_c808f777f2a76c70ea9a3f0e560c6a3b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrProcessTypeDatesAllowed = ConvertToRestWithoutDefaults(s.ssENProcessTypeDatesAllowed, new EN_280cfaefc7654494be27c153014e657dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord.FromStructure, config);
  } else {
AttrProcessTypeDatesAllowed = ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord.FromStructure(s.ssENProcessTypeDatesAllowed, config);
  }
}

public static RC_c808f777f2a76c70ea9a3f0e560c6a3b ToStructure(ssConectaProveedores.RestRecords.RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b obj) { 
  RC_c808f777f2a76c70ea9a3f0e560c6a3b s = new RC_c808f777f2a76c70ea9a3f0e560c6a3b();
  if(obj != null) {
  s.ssENProcessTypeDatesAllowed = ssConectaProveedores.RestRecords.RESTEN_280cfaefc7654494be27c153014e657dEntityRecord.ToStructure(obj.AttrProcessTypeDatesAllowed);
  }
  return s;
}

public static Func<RC_c808f777f2a76c70ea9a3f0e560c6a3b, ssConectaProveedores.RestRecords.RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c808f777f2a76c70ea9a3f0e560c6a3b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b FromStructure(RC_c808f777f2a76c70ea9a3f0e560c6a3b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c808f777f2a76c70ea9a3f0e560c6a3b(s, config);
}

}


