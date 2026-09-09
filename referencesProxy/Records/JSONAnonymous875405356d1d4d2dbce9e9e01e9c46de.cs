using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AdvancePaymentTypeRecord
public class JSONRC_ba5df53107d79696b2775256d21bdd62 : AbstractRESTStructure<RC_ba5df53107d79696b2775256d21bdd62> {
[JsonProperty("AdvancePaymentType")]
[JsonPropertyName("AdvancePaymentType")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord AttrAdvancePaymentType;

public JSONRC_ba5df53107d79696b2775256d21bdd62() { }

public JSONRC_ba5df53107d79696b2775256d21bdd62 (RC_ba5df53107d79696b2775256d21bdd62 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAdvancePaymentType = ConvertToRestWithoutDefaults(s.ssENAdvancePaymentType, new EN_485b44f219737098b3b1029e90069935EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure, config);
  } else {
AttrAdvancePaymentType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.FromStructure(s.ssENAdvancePaymentType, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62, RC_ba5df53107d79696b2775256d21bdd62> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62 s) => ToStructure(s, config);
}
public static RC_ba5df53107d79696b2775256d21bdd62 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62 obj, IBehaviorsConfiguration config) { 
  RC_ba5df53107d79696b2775256d21bdd62 s = new RC_ba5df53107d79696b2775256d21bdd62();
  if(obj != null) {
  s.ssENAdvancePaymentType = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_485b44f219737098b3b1029e90069935EntityRecord.ToStructure(obj.AttrAdvancePaymentType, config);
  }
  return s;
}

public static Func<RC_ba5df53107d79696b2775256d21bdd62, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ba5df53107d79696b2775256d21bdd62 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62 FromStructure(RC_ba5df53107d79696b2775256d21bdd62 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ba5df53107d79696b2775256d21bdd62(s, config);
}

}


