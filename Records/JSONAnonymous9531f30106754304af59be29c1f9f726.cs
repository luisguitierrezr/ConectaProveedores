using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OutputRecord
public class JSONRC_e458ee413a96cac672bdf352274f2a60 : AbstractRESTStructure<RC_e458ee413a96cac672bdf352274f2a60> {
[JsonProperty("Output")]
[JsonPropertyName("Output")]
public ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure AttrOutput;

public JSONRC_e458ee413a96cac672bdf352274f2a60() { }

public JSONRC_e458ee413a96cac672bdf352274f2a60 (RC_e458ee413a96cac672bdf352274f2a60 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOutput = ConvertToRestWithoutDefaults(s.ssSTOutput, new ST_046fb53ebbe142526d95e87ef1ae9711Structure(), ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure, config);
  } else {
AttrOutput = ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(s.ssSTOutput, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60, RC_e458ee413a96cac672bdf352274f2a60> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60 s) => ToStructure(s, config);
}
public static RC_e458ee413a96cac672bdf352274f2a60 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60 obj, IBehaviorsConfiguration config) { 
  RC_e458ee413a96cac672bdf352274f2a60 s = new RC_e458ee413a96cac672bdf352274f2a60();
  if(obj != null) {
  s.ssSTOutput = ssConectaProveedores.RestRecords.JSONST_046fb53ebbe142526d95e87ef1ae9711Structure.ToStructure(obj.AttrOutput, config);
  }
  return s;
}

public static Func<RC_e458ee413a96cac672bdf352274f2a60, ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e458ee413a96cac672bdf352274f2a60 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60 FromStructure(RC_e458ee413a96cac672bdf352274f2a60 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e458ee413a96cac672bdf352274f2a60(s, config);
}

}


