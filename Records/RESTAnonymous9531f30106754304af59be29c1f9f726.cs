using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OutputRecord
public class RESTRC_e458ee413a96cac672bdf352274f2a60 : AbstractRESTStructure<RC_e458ee413a96cac672bdf352274f2a60> {
[JsonProperty("Output")]
public ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure AttrOutput;

public RESTRC_e458ee413a96cac672bdf352274f2a60() { }

public RESTRC_e458ee413a96cac672bdf352274f2a60 (RC_e458ee413a96cac672bdf352274f2a60 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOutput = ConvertToRestWithoutDefaults(s.ssSTOutput, new ST_046fb53ebbe142526d95e87ef1ae9711Structure(), ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure, config);
  } else {
AttrOutput = ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure.FromStructure(s.ssSTOutput, config);
  }
}

public static RC_e458ee413a96cac672bdf352274f2a60 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e458ee413a96cac672bdf352274f2a60 obj) { 
  RC_e458ee413a96cac672bdf352274f2a60 s = new RC_e458ee413a96cac672bdf352274f2a60();
  if(obj != null) {
  s.ssSTOutput = ssConectaProveedores.RestRecords.RESTST_046fb53ebbe142526d95e87ef1ae9711Structure.ToStructure(obj.AttrOutput);
  }
  return s;
}

public static Func<RC_e458ee413a96cac672bdf352274f2a60, ssConectaProveedores.RestRecords.RESTRC_e458ee413a96cac672bdf352274f2a60> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e458ee413a96cac672bdf352274f2a60 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e458ee413a96cac672bdf352274f2a60 FromStructure(RC_e458ee413a96cac672bdf352274f2a60 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e458ee413a96cac672bdf352274f2a60(s, config);
}

}


