using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AppConceptRecord
public class RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd : AbstractRESTStructure<RC_b1b68bfd06a9e65c076da1c0201cd9dd> {
[JsonProperty("AppConcept")]
public ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord AttrAppConcept;

public RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd() { }

public RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd (RC_b1b68bfd06a9e65c076da1c0201cd9dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAppConcept = ConvertToRestWithoutDefaults(s.ssENAppConcept, new EN_01808938be8d2f648d79d661d64023eaEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure, config);
  } else {
AttrAppConcept = ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure(s.ssENAppConcept, config);
  }
}

public static RC_b1b68bfd06a9e65c076da1c0201cd9dd ToStructure(ssConectaProveedores.RestRecords.RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd obj) { 
  RC_b1b68bfd06a9e65c076da1c0201cd9dd s = new RC_b1b68bfd06a9e65c076da1c0201cd9dd();
  if(obj != null) {
  s.ssENAppConcept = ssConectaProveedores.RestRecords.RESTEN_01808938be8d2f648d79d661d64023eaEntityRecord.ToStructure(obj.AttrAppConcept);
  }
  return s;
}

public static Func<RC_b1b68bfd06a9e65c076da1c0201cd9dd, ssConectaProveedores.RestRecords.RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1b68bfd06a9e65c076da1c0201cd9dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd FromStructure(RC_b1b68bfd06a9e65c076da1c0201cd9dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b1b68bfd06a9e65c076da1c0201cd9dd(s, config);
}

}


