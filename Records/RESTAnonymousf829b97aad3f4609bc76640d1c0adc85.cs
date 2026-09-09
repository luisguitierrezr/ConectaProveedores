using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_OBT_TIP_CAMReqRecord
public class RESTRC_4b108b87f78506440b6fe2b6ab61c481 : AbstractRESTStructure<RC_4b108b87f78506440b6fe2b6ab61c481> {
[JsonProperty("ZMXFFIMF_OBT_TIP_CAMReq")]
public ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure AttrZMXFFIMF_OBT_TIP_CAMReq;

public RESTRC_4b108b87f78506440b6fe2b6ab61c481() { }

public RESTRC_4b108b87f78506440b6fe2b6ab61c481 (RC_4b108b87f78506440b6fe2b6ab61c481 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_OBT_TIP_CAMReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_OBT_TIP_CAMReq, new ST_694abc44952847f050feca404fbee9c5Structure(), ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_OBT_TIP_CAMReq = ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure.FromStructure(s.ssSTZMXFFIMF_OBT_TIP_CAMReq, config);
  }
}

public static RC_4b108b87f78506440b6fe2b6ab61c481 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4b108b87f78506440b6fe2b6ab61c481 obj) { 
  RC_4b108b87f78506440b6fe2b6ab61c481 s = new RC_4b108b87f78506440b6fe2b6ab61c481();
  if(obj != null) {
  s.ssSTZMXFFIMF_OBT_TIP_CAMReq = ssConectaProveedores.RestRecords.RESTST_694abc44952847f050feca404fbee9c5Structure.ToStructure(obj.AttrZMXFFIMF_OBT_TIP_CAMReq);
  }
  return s;
}

public static Func<RC_4b108b87f78506440b6fe2b6ab61c481, ssConectaProveedores.RestRecords.RESTRC_4b108b87f78506440b6fe2b6ab61c481> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4b108b87f78506440b6fe2b6ab61c481 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4b108b87f78506440b6fe2b6ab61c481 FromStructure(RC_4b108b87f78506440b6fe2b6ab61c481 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4b108b87f78506440b6fe2b6ab61c481(s, config);
}

}


