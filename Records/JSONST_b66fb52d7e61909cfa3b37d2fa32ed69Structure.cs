using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_MO
public class JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure : AbstractRESTStructure<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> {
[JsonProperty("item")]
[JsonPropertyName("item")]
public ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure[] AttrItem;

public JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure() { }

public JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToArray<ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure>(ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToArray<ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure>(ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure, ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure s) => ToStructure(s, config);
}
public static ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure obj, IBehaviorsConfiguration config) { 
  ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure s = new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure();
  if(obj != null) {
  s.ssItem = RL_4d0d602433bf72956981903b88f22e91.ToList(obj.AttrItem, ssConectaProveedores.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure, ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure FromStructure(ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure(s, config);
}

}


