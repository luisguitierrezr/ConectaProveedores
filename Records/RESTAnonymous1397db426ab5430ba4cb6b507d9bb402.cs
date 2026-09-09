using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantTelcelDirectionApplicantRecord
public class RESTRC_29a9641599166c3e50d86e7edc6e64aa : AbstractRESTStructure<RC_29a9641599166c3e50d86e7edc6e64aa> {
[JsonProperty("ApplicantTelcelDirection")]
public ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord AttrApplicantTelcelDirection;

[JsonProperty("Applicant")]
public ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord AttrApplicant;

public RESTRC_29a9641599166c3e50d86e7edc6e64aa() { }

public RESTRC_29a9641599166c3e50d86e7edc6e64aa (RC_29a9641599166c3e50d86e7edc6e64aa s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicantTelcelDirection = ConvertToRestWithoutDefaults(s.ssENApplicantTelcelDirection, new EN_b4df52993ebe05898d08c65589336b17EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure, config);
AttrApplicant = ConvertToRestWithoutDefaults(s.ssENApplicant, new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure, config);
  } else {
AttrApplicantTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure(s.ssENApplicantTelcelDirection, config);
AttrApplicant = ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure(s.ssENApplicant, config);
  }
}

public static RC_29a9641599166c3e50d86e7edc6e64aa ToStructure(ssConectaProveedores.RestRecords.RESTRC_29a9641599166c3e50d86e7edc6e64aa obj) { 
  RC_29a9641599166c3e50d86e7edc6e64aa s = new RC_29a9641599166c3e50d86e7edc6e64aa();
  if(obj != null) {
  s.ssENApplicantTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.ToStructure(obj.AttrApplicantTelcelDirection);
  s.ssENApplicant = ssConectaProveedores.RestRecords.RESTEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.ToStructure(obj.AttrApplicant);
  }
  return s;
}

public static Func<RC_29a9641599166c3e50d86e7edc6e64aa, ssConectaProveedores.RestRecords.RESTRC_29a9641599166c3e50d86e7edc6e64aa> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_29a9641599166c3e50d86e7edc6e64aa s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_29a9641599166c3e50d86e7edc6e64aa FromStructure(RC_29a9641599166c3e50d86e7edc6e64aa s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_29a9641599166c3e50d86e7edc6e64aa(s, config);
}

}


