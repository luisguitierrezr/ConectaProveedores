using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FormFormApprovalLevelRecord
public class RESTRC_9983883fbc26c5bf3e842f01355fd0c8 : AbstractRESTStructure<RC_9983883fbc26c5bf3e842f01355fd0c8> {
[JsonProperty("Form")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrForm;

[JsonProperty("FormApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord AttrFormApprovalLevel;

public RESTRC_9983883fbc26c5bf3e842f01355fd0c8() { }

public RESTRC_9983883fbc26c5bf3e842f01355fd0c8 (RC_9983883fbc26c5bf3e842f01355fd0c8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrForm = ConvertToRestWithoutDefaults(s.ssENForm, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFormApprovalLevel = ConvertToRestWithoutDefaults(s.ssENFormApprovalLevel, new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure, config);
  } else {
AttrForm = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENForm, config);
AttrFormApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.FromStructure(s.ssENFormApprovalLevel, config);
  }
}

public static RC_9983883fbc26c5bf3e842f01355fd0c8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_9983883fbc26c5bf3e842f01355fd0c8 obj) { 
  RC_9983883fbc26c5bf3e842f01355fd0c8 s = new RC_9983883fbc26c5bf3e842f01355fd0c8();
  if(obj != null) {
  s.ssENForm = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrForm);
  s.ssENFormApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord.ToStructure(obj.AttrFormApprovalLevel);
  }
  return s;
}

public static Func<RC_9983883fbc26c5bf3e842f01355fd0c8, ssConectaProveedores.RestRecords.RESTRC_9983883fbc26c5bf3e842f01355fd0c8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_9983883fbc26c5bf3e842f01355fd0c8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_9983883fbc26c5bf3e842f01355fd0c8 FromStructure(RC_9983883fbc26c5bf3e842f01355fd0c8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_9983883fbc26c5bf3e842f01355fd0c8(s, config);
}

}


