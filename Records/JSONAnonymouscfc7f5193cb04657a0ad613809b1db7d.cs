using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantRecord
public class JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6 : AbstractRESTStructure<RC_9fd4d8d4a1a7da3e37ee97c8163946e6> {
[JsonProperty("Applicant")]
[JsonPropertyName("Applicant")]
public ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord AttrApplicant;

public JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6() { }

public JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6 (RC_9fd4d8d4a1a7da3e37ee97c8163946e6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicant = ConvertToRestWithoutDefaults(s.ssENApplicant, new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure, config);
  } else {
AttrApplicant = ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure(s.ssENApplicant, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6, RC_9fd4d8d4a1a7da3e37ee97c8163946e6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6 s) => ToStructure(s, config);
}
public static RC_9fd4d8d4a1a7da3e37ee97c8163946e6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6 obj, IBehaviorsConfiguration config) { 
  RC_9fd4d8d4a1a7da3e37ee97c8163946e6 s = new RC_9fd4d8d4a1a7da3e37ee97c8163946e6();
  if(obj != null) {
  s.ssENApplicant = ssConectaProveedores.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.ToStructure(obj.AttrApplicant, config);
  }
  return s;
}

public static Func<RC_9fd4d8d4a1a7da3e37ee97c8163946e6, ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9fd4d8d4a1a7da3e37ee97c8163946e6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6 FromStructure(RC_9fd4d8d4a1a7da3e37ee97c8163946e6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9fd4d8d4a1a7da3e37ee97c8163946e6(s, config);
}

}


