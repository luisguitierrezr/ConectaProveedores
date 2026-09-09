using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DepositTypeRecord
public class RESTRC_a8c523bc4a14ce1cf905293530597bc7 : AbstractRESTStructure<RC_a8c523bc4a14ce1cf905293530597bc7> {
[JsonProperty("DepositType")]
public ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord AttrDepositType;

public RESTRC_a8c523bc4a14ce1cf905293530597bc7() { }

public RESTRC_a8c523bc4a14ce1cf905293530597bc7 (RC_a8c523bc4a14ce1cf905293530597bc7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDepositType = ConvertToRestWithoutDefaults(s.ssENDepositType, new EN_784c408ed98e561e8741fa0e6e348ddcEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.FromStructure, config);
  } else {
AttrDepositType = ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.FromStructure(s.ssENDepositType, config);
  }
}

public static RC_a8c523bc4a14ce1cf905293530597bc7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7 obj) { 
  RC_a8c523bc4a14ce1cf905293530597bc7 s = new RC_a8c523bc4a14ce1cf905293530597bc7();
  if(obj != null) {
  s.ssENDepositType = ssConectaProveedores.RestRecords.RESTEN_784c408ed98e561e8741fa0e6e348ddcEntityRecord.ToStructure(obj.AttrDepositType);
  }
  return s;
}

public static Func<RC_a8c523bc4a14ce1cf905293530597bc7, ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a8c523bc4a14ce1cf905293530597bc7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7 FromStructure(RC_a8c523bc4a14ce1cf905293530597bc7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7(s, config);
}

}


