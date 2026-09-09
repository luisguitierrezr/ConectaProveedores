using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ChartLegendOptionalConfigsRecord
public class RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff : AbstractRESTStructure<RC_c38769c4e3f53c55790e6a4b2c81b7ff> {
[JsonProperty("ChartLegendOptionalConfigs")]
public ssConectaProveedores.RestRecords.RESTST_24000c8fde24da45a0d83940a64dbbafStructure AttrChartLegendOptionalConfigs;

public RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff() { }

public RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff (RC_c38769c4e3f53c55790e6a4b2c81b7ff s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrChartLegendOptionalConfigs = ConvertToRestWithoutDefaults(s.ssSTChartLegendOptionalConfigs, new ST_24000c8fde24da45a0d83940a64dbbafStructure(), ssConectaProveedores.RestRecords.RESTST_24000c8fde24da45a0d83940a64dbbafStructure.FromStructure, config);
  } else {
AttrChartLegendOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_24000c8fde24da45a0d83940a64dbbafStructure.FromStructure(s.ssSTChartLegendOptionalConfigs, config);
  }
}

public static RC_c38769c4e3f53c55790e6a4b2c81b7ff ToStructure(ssConectaProveedores.RestRecords.RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff obj) { 
  RC_c38769c4e3f53c55790e6a4b2c81b7ff s = new RC_c38769c4e3f53c55790e6a4b2c81b7ff();
  if(obj != null) {
  s.ssSTChartLegendOptionalConfigs = ssConectaProveedores.RestRecords.RESTST_24000c8fde24da45a0d83940a64dbbafStructure.ToStructure(obj.AttrChartLegendOptionalConfigs);
  }
  return s;
}

public static Func<RC_c38769c4e3f53c55790e6a4b2c81b7ff, ssConectaProveedores.RestRecords.RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_c38769c4e3f53c55790e6a4b2c81b7ff s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff FromStructure(RC_c38769c4e3f53c55790e6a4b2c81b7ff s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_c38769c4e3f53c55790e6a4b2c81b7ff(s, config);
}

}


