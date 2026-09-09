using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AppConceptRecord
public class JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd : AbstractRESTStructure<RC_b1b68bfd06a9e65c076da1c0201cd9dd> {
[JsonProperty("AppConcept")]
[JsonPropertyName("AppConcept")]
public ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord AttrAppConcept;

public JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd() { }

public JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd (RC_b1b68bfd06a9e65c076da1c0201cd9dd s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAppConcept = ConvertToRestWithoutDefaults(s.ssENAppConcept, new EN_01808938be8d2f648d79d661d64023eaEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure, config);
  } else {
AttrAppConcept = ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.FromStructure(s.ssENAppConcept, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd, RC_b1b68bfd06a9e65c076da1c0201cd9dd> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd s) => ToStructure(s, config);
}
public static RC_b1b68bfd06a9e65c076da1c0201cd9dd ToStructure(ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd obj, IBehaviorsConfiguration config) { 
  RC_b1b68bfd06a9e65c076da1c0201cd9dd s = new RC_b1b68bfd06a9e65c076da1c0201cd9dd();
  if(obj != null) {
  s.ssENAppConcept = ssConectaProveedores.RestRecords.JSONEN_01808938be8d2f648d79d661d64023eaEntityRecord.ToStructure(obj.AttrAppConcept, config);
  }
  return s;
}

public static Func<RC_b1b68bfd06a9e65c076da1c0201cd9dd, ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b1b68bfd06a9e65c076da1c0201cd9dd s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd FromStructure(RC_b1b68bfd06a9e65c076da1c0201cd9dd s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b1b68bfd06a9e65c076da1c0201cd9dd(s, config);
}

}


