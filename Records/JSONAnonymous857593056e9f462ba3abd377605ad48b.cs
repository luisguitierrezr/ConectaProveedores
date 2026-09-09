using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FormFormApprovalLevelRecord
public class JSONRC_9983883fbc26c5bf3e842f01355fd0c8 : AbstractRESTStructure<RC_9983883fbc26c5bf3e842f01355fd0c8> {
[JsonProperty("Form")]
[JsonPropertyName("Form")]
public ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrForm;

[JsonProperty("FormApprovalLevel")]
[JsonPropertyName("FormApprovalLevel")]
public ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFormApprovalLevel;

public JSONRC_9983883fbc26c5bf3e842f01355fd0c8() { }

public JSONRC_9983883fbc26c5bf3e842f01355fd0c8 (RC_9983883fbc26c5bf3e842f01355fd0c8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrForm = ConvertToRestWithoutDefaults(s.ssENForm, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFormApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFormApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrForm = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENForm, config);
AttrFormApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFormApprovalLevel, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8, RC_9983883fbc26c5bf3e842f01355fd0c8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8 s) => ToStructure(s, config);
}
public static RC_9983883fbc26c5bf3e842f01355fd0c8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8 obj, IBehaviorsConfiguration config) { 
  RC_9983883fbc26c5bf3e842f01355fd0c8 s = new RC_9983883fbc26c5bf3e842f01355fd0c8();
  if(obj != null) {
  s.ssENForm = ssConectaProveedores.RestRecords.JSONEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrForm, config);
  s.ssENFormApprovalLevel = ssConectaProveedores.RestRecords.JSONEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFormApprovalLevel, config);
  }
  return s;
}

public static Func<RC_9983883fbc26c5bf3e842f01355fd0c8, ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9983883fbc26c5bf3e842f01355fd0c8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8 FromStructure(RC_9983883fbc26c5bf3e842f01355fd0c8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_9983883fbc26c5bf3e842f01355fd0c8(s, config);
}

}


