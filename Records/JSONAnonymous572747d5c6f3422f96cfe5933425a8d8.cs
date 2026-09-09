using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DepositTypeRecord
public class JSONRC_a8c523bc4a14ce1cf905293530597bc7 : AbstractRESTStructure<RC_a8c523bc4a14ce1cf905293530597bc7> {
[JsonProperty("DepositType")]
[JsonPropertyName("DepositType")]
public ssConectaProveedores.RestRecords.JSONEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord AttrDepositType;

public JSONRC_a8c523bc4a14ce1cf905293530597bc7() { }

public JSONRC_a8c523bc4a14ce1cf905293530597bc7 (RC_a8c523bc4a14ce1cf905293530597bc7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDepositType = ConvertToRestWithoutDefaults(s.ssENDepositType, new EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.FromStructure, config);
  } else {
AttrDepositType = ssConectaProveedores.RestRecords.JSONEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.FromStructure(s.ssENDepositType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7, RC_a8c523bc4a14ce1cf905293530597bc7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7 s) => ToStructure(s, config);
}
public static RC_a8c523bc4a14ce1cf905293530597bc7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7 obj, IBehaviorsConfiguration config) { 
  RC_a8c523bc4a14ce1cf905293530597bc7 s = new RC_a8c523bc4a14ce1cf905293530597bc7();
  if(obj != null) {
  s.ssENDepositType = ssConectaProveedores.RestRecords.JSONEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.ToStructure(obj.AttrDepositType, config);
  }
  return s;
}

public static Func<RC_a8c523bc4a14ce1cf905293530597bc7, ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a8c523bc4a14ce1cf905293530597bc7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7 FromStructure(RC_a8c523bc4a14ce1cf905293530597bc7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a8c523bc4a14ce1cf905293530597bc7(s, config);
}

}


