using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_OBT_TIP_CAMReqRecord
public class JSONRC_4b108b87f78506440b6fe2b6ab61c481 : AbstractRESTStructure<RC_4b108b87f78506440b6fe2b6ab61c481> {
[JsonProperty("ZMXFFIMF_OBT_TIP_CAMReq")]
[JsonPropertyName("ZMXFFIMF_OBT_TIP_CAMReq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure AttrZMXFFIMF_OBT_TIP_CAMReq;

public JSONRC_4b108b87f78506440b6fe2b6ab61c481() { }

public JSONRC_4b108b87f78506440b6fe2b6ab61c481 (RC_4b108b87f78506440b6fe2b6ab61c481 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_OBT_TIP_CAMReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_OBT_TIP_CAMReq, new ST_694abc44952847f050feca404fbee9c5Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_OBT_TIP_CAMReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure.FromStructure(s.ssSTZMXFFIMF_OBT_TIP_CAMReq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481, RC_4b108b87f78506440b6fe2b6ab61c481> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481 s) => ToStructure(s, config);
}
public static RC_4b108b87f78506440b6fe2b6ab61c481 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481 obj, IBehaviorsConfiguration config) { 
  RC_4b108b87f78506440b6fe2b6ab61c481 s = new RC_4b108b87f78506440b6fe2b6ab61c481();
  if(obj != null) {
  s.ssSTZMXFFIMF_OBT_TIP_CAMReq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure.ToStructure(obj.AttrZMXFFIMF_OBT_TIP_CAMReq, config);
  }
  return s;
}

public static Func<RC_4b108b87f78506440b6fe2b6ab61c481, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4b108b87f78506440b6fe2b6ab61c481 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481 FromStructure(RC_4b108b87f78506440b6fe2b6ab61c481 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_4b108b87f78506440b6fe2b6ab61c481(s, config);
}

}


