using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DatePickerRangeOptionalConfigsRecord
public class RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e : AbstractRESTStructure<RC_310dae2b4d3a1f1ded7570a6ee74f16e> {
[JsonProperty("DatePickerRangeOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure AttrDatePickerRangeOptionalConfigs;

public RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e() { }

public RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e (RC_310dae2b4d3a1f1ded7570a6ee74f16e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDatePickerRangeOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTDatePickerRangeOptionalConfigs, new ST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure(), ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.FromStructure, config);
  } else {
AttrDatePickerRangeOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.FromStructure(s.ssSTDatePickerRangeOptionalConfigs, config);
  }
}

public static RC_310dae2b4d3a1f1ded7570a6ee74f16e ToStructure(ssConectaProveedores.RestRecords.RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e obj) { 
  RC_310dae2b4d3a1f1ded7570a6ee74f16e s = new RC_310dae2b4d3a1f1ded7570a6ee74f16e();
  if(obj != null) {
  s.ssSTDatePickerRangeOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_ba5b17ae5b3fdd9318ea2b4cf18c7d4dStructure.ToStructure(obj.AttrDatePickerRangeOptionalConfigs);
  }
  return s;
}

public static Func<RC_310dae2b4d3a1f1ded7570a6ee74f16e, ssConectaProveedores.RestRecords.RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_310dae2b4d3a1f1ded7570a6ee74f16e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e FromStructure(RC_310dae2b4d3a1f1ded7570a6ee74f16e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_310dae2b4d3a1f1ded7570a6ee74f16e(s, config);
}

}


