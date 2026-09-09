using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ChartLegendOptionalConfigsRecord
public class JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff : AbstractRESTStructure<RC_c38769c4e3f53c55790e6a4b2c81b7ff> {
[JsonProperty("ChartLegendOptionalConfigs")]
[JsonPropertyName("ChartLegendOptionalConfigs")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure AttrChartLegendOptionalConfigs;

public JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff() { }

public JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff (RC_c38769c4e3f53c55790e6a4b2c81b7ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChartLegendOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTChartLegendOptionalConfigs, new ST_24000c8fde24da45a0d83940a64dbbafStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure.FromStructure, config);
  } else {
AttrChartLegendOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure.FromStructure(s.ssSTChartLegendOptionalConfigs, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff, RC_c38769c4e3f53c55790e6a4b2c81b7ff> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff s) => ToStructure(s, config);
}
public static RC_c38769c4e3f53c55790e6a4b2c81b7ff ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff obj, IBehaviorsConfiguration config) { 
  RC_c38769c4e3f53c55790e6a4b2c81b7ff s = new RC_c38769c4e3f53c55790e6a4b2c81b7ff();
  if(obj != null) {
  s.ssSTChartLegendOptionalConfigs = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24000c8fde24da45a0d83940a64dbbafStructure.ToStructure(obj.AttrChartLegendOptionalConfigs, config);
  }
  return s;
}

public static Func<RC_c38769c4e3f53c55790e6a4b2c81b7ff, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c38769c4e3f53c55790e6a4b2c81b7ff s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff FromStructure(RC_c38769c4e3f53c55790e6a4b2c81b7ff s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_c38769c4e3f53c55790e6a4b2c81b7ff(s, config);
}

}


