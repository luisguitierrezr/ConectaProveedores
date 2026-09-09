using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantTelcelDirectionApplicantRecord
public class JSONRC_29a9641599166c3e50d86e7edc6e64aa : AbstractRESTStructure<RC_29a9641599166c3e50d86e7edc6e64aa> {
[JsonProperty("ApplicantTelcelDirection")]
[JsonPropertyName("ApplicantTelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord AttrApplicantTelcelDirection;

[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord AttrApplicant;

public JSONRC_29a9641599166c3e50d86e7edc6e64aa() { }

public JSONRC_29a9641599166c3e50d86e7edc6e64aa (RC_29a9641599166c3e50d86e7edc6e64aa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicantTelcelDirection = ConvertToRestWithoutDefaults(s.ssENApplicantTelcelDirection, new EN_b4df52993ebe05898d08c65589336b17EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure, config);
AttrApplicant = ConvertToRestWithoutDefaults(s.ssENApplicant, new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure, config);
  } else {
AttrApplicantTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure(s.ssENApplicantTelcelDirection, config);
AttrApplicant = ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure(s.ssENApplicant, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa, RC_29a9641599166c3e50d86e7edc6e64aa> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa s) => ToStructure(s, config);
}
public static RC_29a9641599166c3e50d86e7edc6e64aa ToStructure(ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa obj, IBehaviorsConfiguration config) { 
  RC_29a9641599166c3e50d86e7edc6e64aa s = new RC_29a9641599166c3e50d86e7edc6e64aa();
  if(obj != null) {
  s.ssENApplicantTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.ToStructure(obj.AttrApplicantTelcelDirection, config);
  s.ssENApplicant = ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.ToStructure(obj.AttrApplicant, config);
  }
  return s;
}

public static Func<RC_29a9641599166c3e50d86e7edc6e64aa, ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29a9641599166c3e50d86e7edc6e64aa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa FromStructure(RC_29a9641599166c3e50d86e7edc6e64aa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_29a9641599166c3e50d86e7edc6e64aa(s, config);
}

}


