using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FinishUpdateEmailFailureReason
public class RESTST_23034956e06e8e0a2169e5e731331735Structure : AbstractRESTStructure<ST_23034956e06e8e0a2169e5e731331735Structure> {
[JsonProperty("InvalidVerificationCode")]
public bool? AttrInvalidVerificationCode;

public RESTST_23034956e06e8e0a2169e5e731331735Structure() { }

public RESTST_23034956e06e8e0a2169e5e731331735Structure (ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvalidVerificationCode = ConvertToRestWithoutDefaults(s.ssInvalidVerificationCode, false);
  } else {
AttrInvalidVerificationCode = (bool?) s.ssInvalidVerificationCode;
  }
}

public static ST_23034956e06e8e0a2169e5e731331735Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure obj) { 
  ST_23034956e06e8e0a2169e5e731331735Structure s = new ST_23034956e06e8e0a2169e5e731331735Structure();
  if(obj != null) {
  s.ssInvalidVerificationCode = obj.AttrInvalidVerificationCode == null ? false : obj.AttrInvalidVerificationCode.Value;
  }
  return s;
}

public static Func<ST_23034956e06e8e0a2169e5e731331735Structure, ssConectaProveedores.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_23034956e06e8e0a2169e5e731331735Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure FromStructure(ST_23034956e06e8e0a2169e5e731331735Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_23034956e06e8e0a2169e5e731331735Structure(s, config);
}

}


