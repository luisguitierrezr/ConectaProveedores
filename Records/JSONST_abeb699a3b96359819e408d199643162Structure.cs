using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_Request
public class JSONST_abeb699a3b96359819e408d199643162Structure : AbstractRESTStructure<ST_abeb699a3b96359819e408d199643162Structure> {
[JsonProperty("ZMXMIMMF_EM_SM_CECO_COSMOZ")]
[JsonPropertyName("ZMXMIMMF_EM_SM_CECO_COSMOZ")]
public ssConectaProveedores.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure AttrEM_SM_CECO_COSMOZ_Request_Struct;

public JSONST_abeb699a3b96359819e408d199643162Structure() { }

public JSONST_abeb699a3b96359819e408d199643162Structure (ST_abeb699a3b96359819e408d199643162Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Request_Struct = ConvertToRestWithoutDefaults(s.ssEM_SM_CECO_COSMOZ_Request_Struct, new ST_883584831b34399a326748c4b1ce95c9Structure(), ssConectaProveedores.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.FromStructure(s.ssEM_SM_CECO_COSMOZ_Request_Struct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure, ST_abeb699a3b96359819e408d199643162Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure s) => ToStructure(s, config);
}
public static ST_abeb699a3b96359819e408d199643162Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure obj, IBehaviorsConfiguration config) { 
  ST_abeb699a3b96359819e408d199643162Structure s = new ST_abeb699a3b96359819e408d199643162Structure();
  if(obj != null) {
  s.ssEM_SM_CECO_COSMOZ_Request_Struct = ssConectaProveedores.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Request_Struct, config);
  }
  return s;
}

public static Func<ST_abeb699a3b96359819e408d199643162Structure, ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_abeb699a3b96359819e408d199643162Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure FromStructure(ST_abeb699a3b96359819e408d199643162Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure(s, config);
}

}


