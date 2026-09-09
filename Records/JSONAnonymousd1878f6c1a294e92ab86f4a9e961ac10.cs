using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ValidationReportRecord
public class JSONRC_de8617412b322377b0b7d994b41f18b6 : AbstractRESTStructure<RC_de8617412b322377b0b7d994b41f18b6> {
[JsonProperty("ValidationReport")]
[JsonPropertyName("ValidationReport")]
public ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure AttrValidationReport;

public JSONRC_de8617412b322377b0b7d994b41f18b6() { }

public JSONRC_de8617412b322377b0b7d994b41f18b6 (RC_de8617412b322377b0b7d994b41f18b6 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrValidationReport = ConvertToRestWithoutDefaults(s.ssSTValidationReport, new ST_f54c1d1bac41c2667837ac97bb484830Structure(), ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure.FromStructure, config);
  } else {
AttrValidationReport = ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure.FromStructure(s.ssSTValidationReport, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6, RC_de8617412b322377b0b7d994b41f18b6> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6 s) => ToStructure(s, config);
}
public static RC_de8617412b322377b0b7d994b41f18b6 ToStructure(ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6 obj, IBehaviorsConfiguration config) { 
  RC_de8617412b322377b0b7d994b41f18b6 s = new RC_de8617412b322377b0b7d994b41f18b6();
  if(obj != null) {
  s.ssSTValidationReport = ssConectaProveedores.RestRecords.JSONST_f54c1d1bac41c2667837ac97bb484830Structure.ToStructure(obj.AttrValidationReport, config);
  }
  return s;
}

public static Func<RC_de8617412b322377b0b7d994b41f18b6, ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_de8617412b322377b0b7d994b41f18b6 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6 FromStructure(RC_de8617412b322377b0b7d994b41f18b6 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_de8617412b322377b0b7d994b41f18b6(s, config);
}

}


