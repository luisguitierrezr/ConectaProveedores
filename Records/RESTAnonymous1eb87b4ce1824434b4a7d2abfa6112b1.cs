using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalProcessIdProcessTypeCodeVersionIsSpecialRecord
public class RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b : AbstractRESTStructure<RC_3bc764f67e81a7d7cfa96c1a97a8c95b> {
[JsonProperty("ApprovalProcessId")]
public long? AttrApprovalProcessId;

[JsonProperty("ProcessTypeCode")]
public string AttrProcessTypeCode;

[JsonProperty("Version")]
public string AttrVersion;

[JsonProperty("IsSpecial")]
public bool? AttrIsSpecial;

public RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b() { }

public RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b (RC_3bc764f67e81a7d7cfa96c1a97a8c95b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrApprovalProcessId = ConvertToRestWithoutDefaults(s.ssApprovalProcessId, 0L);
AttrProcessTypeCode = ConvertToRestWithoutDefaults(s.ssProcessTypeCode, "");
AttrVersion = ConvertToRestWithoutDefaults(s.ssVersion, "");
AttrIsSpecial = ConvertToRestWithoutDefaults(s.ssIsSpecial, false);
  } else {
AttrApprovalProcessId = (long?) s.ssApprovalProcessId;
AttrProcessTypeCode = s.ssProcessTypeCode;
AttrVersion = s.ssVersion;
AttrIsSpecial = (bool?) s.ssIsSpecial;
  }
}

public static RC_3bc764f67e81a7d7cfa96c1a97a8c95b ToStructure(ssConectaProveedores.RestRecords.RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b obj) { 
  RC_3bc764f67e81a7d7cfa96c1a97a8c95b s = new RC_3bc764f67e81a7d7cfa96c1a97a8c95b();
  if(obj != null) {
  s.ssApprovalProcessId = obj.AttrApprovalProcessId == null ? 0L : obj.AttrApprovalProcessId.Value;
  s.ssProcessTypeCode = obj.AttrProcessTypeCode == null ? "" : obj.AttrProcessTypeCode;
  s.ssVersion = obj.AttrVersion == null ? "" : obj.AttrVersion;
  s.ssIsSpecial = obj.AttrIsSpecial == null ? false : obj.AttrIsSpecial.Value;
  }
  return s;
}

public static Func<RC_3bc764f67e81a7d7cfa96c1a97a8c95b, ssConectaProveedores.RestRecords.RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3bc764f67e81a7d7cfa96c1a97a8c95b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b FromStructure(RC_3bc764f67e81a7d7cfa96c1a97a8c95b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3bc764f67e81a7d7cfa96c1a97a8c95b(s, config);
}

}


