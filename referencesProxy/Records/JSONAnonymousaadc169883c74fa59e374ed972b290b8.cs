using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ItemEM_MORecord
public class JSONRC_6db7d963170551ccb632da4db036570c : AbstractRESTStructure<RC_6db7d963170551ccb632da4db036570c> {
[JsonProperty("ItemEM_MO")]
[JsonPropertyName("ItemEM_MO")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure AttrItemEM_MO;

public JSONRC_6db7d963170551ccb632da4db036570c() { }

public JSONRC_6db7d963170551ccb632da4db036570c (RC_6db7d963170551ccb632da4db036570c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemEM_MO = ConvertToRestWithoutDefaults(s.ssSTItemEM_MO, new ST_8367d678111f49d602545a0a640615d6Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.FromStructure, config);
  } else {
AttrItemEM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.FromStructure(s.ssSTItemEM_MO, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c, RC_6db7d963170551ccb632da4db036570c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c s) => ToStructure(s, config);
}
public static RC_6db7d963170551ccb632da4db036570c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c obj, IBehaviorsConfiguration config) { 
  RC_6db7d963170551ccb632da4db036570c s = new RC_6db7d963170551ccb632da4db036570c();
  if(obj != null) {
  s.ssSTItemEM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_8367d678111f49d602545a0a640615d6Structure.ToStructure(obj.AttrItemEM_MO, config);
  }
  return s;
}

public static Func<RC_6db7d963170551ccb632da4db036570c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6db7d963170551ccb632da4db036570c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c FromStructure(RC_6db7d963170551ccb632da4db036570c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_6db7d963170551ccb632da4db036570c(s, config);
}

}


