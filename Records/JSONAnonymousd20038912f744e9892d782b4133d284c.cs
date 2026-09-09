using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantTelcelDirectionRecord
public class JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 : AbstractRESTStructure<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> {
[JsonProperty("ApplicantTelcelDirection")]
[JsonPropertyName("ApplicantTelcelDirection")]
public ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord AttrApplicantTelcelDirection;

public JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6() { }

public JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicantTelcelDirection = ConvertToRestWithoutDefaults(s.ssENApplicantTelcelDirection, new EN_b4df52993ebe05898d08c65589336b17EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure, config);
  } else {
AttrApplicantTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure(s.ssENApplicantTelcelDirection, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6, RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s) => ToStructure(s, config);
}
public static RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 obj, IBehaviorsConfiguration config) { 
  RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s = new RC_67bdd68f4d7be547b9a3c6fcb61b6dc6();
  if(obj != null) {
  s.ssENApplicantTelcelDirection = ssConectaProveedores.RestRecords.JSONEN_b4df52993ebe05898d08c65589336b17EntityRecord.ToStructure(obj.AttrApplicantTelcelDirection, config);
  }
  return s;
}

public static Func<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6, ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 FromStructure(RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_67bdd68f4d7be547b9a3c6fcb61b6dc6(s, config);
}

}


