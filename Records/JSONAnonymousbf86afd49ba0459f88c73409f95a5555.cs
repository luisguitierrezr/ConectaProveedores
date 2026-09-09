using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerRangeOptionalConfigsRecord
public class JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e : AbstractRESTStructure<RC_310dae2b4d3a1f1ded7570a6ee74f16e> {
[JsonProperty("DatePickerRangeOptionalConfigs")]
[JsonPropertyName("DatePickerRangeOptionalConfigs")]
public ssConectaProveedores.RestRecords.JSONST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure AttrDatePickerRangeOptionalConfigs;

public JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e() { }

public JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e (RC_310dae2b4d3a1f1ded7570a6ee74f16e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerRangeOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDatePickerRangeOptionalConfigs, new ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure(), ssConectaProveedores.RestRecords.JSONST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.FromStructure, config);
  } else {
AttrDatePickerRangeOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.FromStructure(s.ssSTDatePickerRangeOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e, RC_310dae2b4d3a1f1ded7570a6ee74f16e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e s) => ToStructure(s, config);
}
public static RC_310dae2b4d3a1f1ded7570a6ee74f16e ToStructure(ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e obj, IBehaviorsConfiguration config) { 
  RC_310dae2b4d3a1f1ded7570a6ee74f16e s = new RC_310dae2b4d3a1f1ded7570a6ee74f16e();
  if(obj != null) {
  s.ssSTDatePickerRangeOptionalConfigs = ssConectaProveedores.RestRecords.JSONST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.ToStructure(obj.AttrDatePickerRangeOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_310dae2b4d3a1f1ded7570a6ee74f16e, ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_310dae2b4d3a1f1ded7570a6ee74f16e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e FromStructure(RC_310dae2b4d3a1f1ded7570a6ee74f16e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_310dae2b4d3a1f1ded7570a6ee74f16e(s, config);
}

}


