using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AdvancePaymentTypeRecord
public class RESTRC_ba5df53107d79696b2775256d21bdd62 : AbstractRESTStructure<RC_ba5df53107d79696b2775256d21bdd62> {
[JsonProperty("AdvancePaymentType")]
public ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord AttrAdvancePaymentType;

public RESTRC_ba5df53107d79696b2775256d21bdd62() { }

public RESTRC_ba5df53107d79696b2775256d21bdd62 (RC_ba5df53107d79696b2775256d21bdd62 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAdvancePaymentType = ConvertToRestWithoutDefaults(s.ssENAdvancePaymentType, new EN_485b44f219737098b3b1029e90069935EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure, config);
  } else {
AttrAdvancePaymentType = ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure(s.ssENAdvancePaymentType, config);
  }
}

public static RC_ba5df53107d79696b2775256d21bdd62 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62 obj) { 
  RC_ba5df53107d79696b2775256d21bdd62 s = new RC_ba5df53107d79696b2775256d21bdd62();
  if(obj != null) {
  s.ssENAdvancePaymentType = ssConectaProveedores.RestRecords.RESTEN_485b44f219737098b3b1029e90069935EntityRecord.ToStructure(obj.AttrAdvancePaymentType);
  }
  return s;
}

public static Func<RC_ba5df53107d79696b2775256d21bdd62, ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba5df53107d79696b2775256d21bdd62 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62 FromStructure(RC_ba5df53107d79696b2775256d21bdd62 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62(s, config);
}

}


