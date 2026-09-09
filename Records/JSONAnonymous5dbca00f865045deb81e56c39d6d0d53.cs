using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportAuthorizationRecord
public class JSONRC_e63ebb69a9e232a6817f4ea671f315f7 : AbstractRESTStructure<RC_e63ebb69a9e232a6817f4ea671f315f7> {
[JsonProperty("ValidationReportAuthorization")]
[JsonPropertyName("ValidationReportAuthorization")]
public ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure AttrValidationReportAuthorization;

public JSONRC_e63ebb69a9e232a6817f4ea671f315f7() { }

public JSONRC_e63ebb69a9e232a6817f4ea671f315f7 (RC_e63ebb69a9e232a6817f4ea671f315f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidationReportAuthorization = ConvertToRestWithoutDefaults(s.ssSTValidationReportAuthorization, new ST_2667ad63792f2349dc9e4a818559d9ecStructure(), ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructure, config);
  } else {
AttrValidationReportAuthorization = ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructure(s.ssSTValidationReportAuthorization, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7, RC_e63ebb69a9e232a6817f4ea671f315f7> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7 s) => ToStructure(s, config);
}
public static RC_e63ebb69a9e232a6817f4ea671f315f7 ToStructure(ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7 obj, IBehaviorsConfiguration config) { 
  RC_e63ebb69a9e232a6817f4ea671f315f7 s = new RC_e63ebb69a9e232a6817f4ea671f315f7();
  if(obj != null) {
  s.ssSTValidationReportAuthorization = ssConectaProveedores.RestRecords.JSONST_2667ad63792f2349dc9e4a818559d9ecStructure.ToStructure(obj.AttrValidationReportAuthorization, config);
  }
  return s;
}

public static Func<RC_e63ebb69a9e232a6817f4ea671f315f7, ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e63ebb69a9e232a6817f4ea671f315f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7 FromStructure(RC_e63ebb69a9e232a6817f4ea671f315f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_e63ebb69a9e232a6817f4ea671f315f7(s, config);
}

}


