using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Trigger
public class RESTEN_52e55d60c515b6016f81404afb220594EntityRecord : AbstractRESTStructure<EN_52e55d60c515b6016f81404afb220594EntityRecord> {
[JsonProperty("Trigger")]
public string AttrTrigger;

public RESTEN_52e55d60c515b6016f81404afb220594EntityRecord() { }

public RESTEN_52e55d60c515b6016f81404afb220594EntityRecord (EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTrigger = s.ssTrigger;
  } else {
AttrTrigger = s.ssTrigger;
  }
}

public static EN_52e55d60c515b6016f81404afb220594EntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord obj) { 
  EN_52e55d60c515b6016f81404afb220594EntityRecord s = new EN_52e55d60c515b6016f81404afb220594EntityRecord();
  if(obj != null) {
  s.ssTrigger = obj.AttrTrigger == null ? "" : obj.AttrTrigger;
  }
  return s;
}

public static Func<EN_52e55d60c515b6016f81404afb220594EntityRecord, ssConectaProveedores.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_52e55d60c515b6016f81404afb220594EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord FromStructure(EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_52e55d60c515b6016f81404afb220594EntityRecord(s, config);
}

}


