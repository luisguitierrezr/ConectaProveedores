using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportAuthorizationRecord
public class RESTRC_e63ebb69a9e232a6817f4ea671f315f7 : AbstractRESTStructure<RC_e63ebb69a9e232a6817f4ea671f315f7> {
[JsonProperty("ValidationReportAuthorization")]
public ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure AttrValidationReportAuthorization;

public RESTRC_e63ebb69a9e232a6817f4ea671f315f7() { }

public RESTRC_e63ebb69a9e232a6817f4ea671f315f7 (RC_e63ebb69a9e232a6817f4ea671f315f7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidationReportAuthorization = ConvertToRestWithoutDefaults(s.ssSTValidationReportAuthorization, new ST_2667ad63792f2349dc9e4a818559d9ecStructure(), ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructure, config);
  } else {
AttrValidationReportAuthorization = ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.FromStructure(s.ssSTValidationReportAuthorization, config);
  }
}

public static RC_e63ebb69a9e232a6817f4ea671f315f7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e63ebb69a9e232a6817f4ea671f315f7 obj) { 
  RC_e63ebb69a9e232a6817f4ea671f315f7 s = new RC_e63ebb69a9e232a6817f4ea671f315f7();
  if(obj != null) {
  s.ssSTValidationReportAuthorization = ssConectaProveedores.RestRecords.RESTST_2667ad63792f2349dc9e4a818559d9ecStructure.ToStructure(obj.AttrValidationReportAuthorization);
  }
  return s;
}

public static Func<RC_e63ebb69a9e232a6817f4ea671f315f7, ssConectaProveedores.RestRecords.RESTRC_e63ebb69a9e232a6817f4ea671f315f7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e63ebb69a9e232a6817f4ea671f315f7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e63ebb69a9e232a6817f4ea671f315f7 FromStructure(RC_e63ebb69a9e232a6817f4ea671f315f7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e63ebb69a9e232a6817f4ea671f315f7(s, config);
}

}


