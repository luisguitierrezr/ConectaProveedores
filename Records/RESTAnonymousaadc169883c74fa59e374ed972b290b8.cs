using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemEM_MORecord
public class RESTRC_6db7d963170551ccb632da4db036570c : AbstractRESTStructure<RC_6db7d963170551ccb632da4db036570c> {
[JsonProperty("ItemEM_MO")]
public ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure AttrItemEM_MO;

public RESTRC_6db7d963170551ccb632da4db036570c() { }

public RESTRC_6db7d963170551ccb632da4db036570c (RC_6db7d963170551ccb632da4db036570c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemEM_MO = ConvertToRestWithoutDefaults(s.ssSTItemEM_MO, new ST_8367d678111f49d602545a0a640615d6Structure(), ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure.FromStructure, config);
  } else {
AttrItemEM_MO = ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure.FromStructure(s.ssSTItemEM_MO, config);
  }
}

public static RC_6db7d963170551ccb632da4db036570c ToStructure(ssConectaProveedores.RestRecords.RESTRC_6db7d963170551ccb632da4db036570c obj) { 
  RC_6db7d963170551ccb632da4db036570c s = new RC_6db7d963170551ccb632da4db036570c();
  if(obj != null) {
  s.ssSTItemEM_MO = ssConectaProveedores.RestRecords.RESTST_8367d678111f49d602545a0a640615d6Structure.ToStructure(obj.AttrItemEM_MO);
  }
  return s;
}

public static Func<RC_6db7d963170551ccb632da4db036570c, ssConectaProveedores.RestRecords.RESTRC_6db7d963170551ccb632da4db036570c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6db7d963170551ccb632da4db036570c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6db7d963170551ccb632da4db036570c FromStructure(RC_6db7d963170551ccb632da4db036570c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6db7d963170551ccb632da4db036570c(s, config);
}

}


