using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// GetErrorDistributionOutStructureRecord
public class JSONRC_b75e1542aa6c3f9562684d933180c07c : AbstractRESTStructure<RC_b75e1542aa6c3f9562684d933180c07c> {
[JsonProperty("GetErrorDistributionOutStructure")]
[JsonPropertyName("GetErrorDistributionOutStructure")]
public ssConectaProveedores.RestRecords.JSONST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure AttrGetErrorDistributionOutStructure;

public JSONRC_b75e1542aa6c3f9562684d933180c07c() { }

public JSONRC_b75e1542aa6c3f9562684d933180c07c (RC_b75e1542aa6c3f9562684d933180c07c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrGetErrorDistributionOutStructure = ConvertToRestWithoutDefaults(s.ssSTGetErrorDistributionOutStructure, new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure(), ssConectaProveedores.RestRecords.JSONST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure.FromStructure, config);
  } else {
AttrGetErrorDistributionOutStructure = ssConectaProveedores.RestRecords.JSONST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure.FromStructure(s.ssSTGetErrorDistributionOutStructure, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c, RC_b75e1542aa6c3f9562684d933180c07c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c s) => ToStructure(s, config);
}
public static RC_b75e1542aa6c3f9562684d933180c07c ToStructure(ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c obj, IBehaviorsConfiguration config) { 
  RC_b75e1542aa6c3f9562684d933180c07c s = new RC_b75e1542aa6c3f9562684d933180c07c();
  if(obj != null) {
  s.ssSTGetErrorDistributionOutStructure = ssConectaProveedores.RestRecords.JSONST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure.ToStructure(obj.AttrGetErrorDistributionOutStructure, config);
  }
  return s;
}

public static Func<RC_b75e1542aa6c3f9562684d933180c07c, ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b75e1542aa6c3f9562684d933180c07c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c FromStructure(RC_b75e1542aa6c3f9562684d933180c07c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b75e1542aa6c3f9562684d933180c07c(s, config);
}

}


