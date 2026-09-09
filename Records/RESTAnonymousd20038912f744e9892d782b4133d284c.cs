using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApplicantTelcelDirectionRecord
public class RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 : AbstractRESTStructure<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> {
[JsonProperty("ApplicantTelcelDirection")]
public ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord AttrApplicantTelcelDirection;

public RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6() { }

public RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApplicantTelcelDirection = ConvertToRestWithoutDefaults(s.ssENApplicantTelcelDirection, new EN_b4df52993ebe05898d08c65589336b17EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure, config);
  } else {
AttrApplicantTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.FromStructure(s.ssENApplicantTelcelDirection, config);
  }
}

public static RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 ToStructure(ssConectaProveedores.RestRecords.RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 obj) { 
  RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s = new RC_67bdd68f4d7be547b9a3c6fcb61b6dc6();
  if(obj != null) {
  s.ssENApplicantTelcelDirection = ssConectaProveedores.RestRecords.RESTEN_b4df52993ebe05898d08c65589336b17EntityRecord.ToStructure(obj.AttrApplicantTelcelDirection);
  }
  return s;
}

public static Func<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6, ssConectaProveedores.RestRecords.RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6 FromStructure(RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_67bdd68f4d7be547b9a3c6fcb61b6dc6(s, config);
}

}


