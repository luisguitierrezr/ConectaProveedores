using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// Trigger
public class JSONEN_52e55d60c515b6016f81404afb220594EntityRecord : AbstractRESTStructure<EN_52e55d60c515b6016f81404afb220594EntityRecord> {
[JsonProperty("Trigger")]
[JsonPropertyName("Trigger")]
public string AttrTrigger;

public JSONEN_52e55d60c515b6016f81404afb220594EntityRecord() { }

public JSONEN_52e55d60c515b6016f81404afb220594EntityRecord (EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTrigger = s.ssTrigger;
  } else {
AttrTrigger = s.ssTrigger;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord, EN_52e55d60c515b6016f81404afb220594EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord s) => ToStructure(s, config);
}
public static EN_52e55d60c515b6016f81404afb220594EntityRecord ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_52e55d60c515b6016f81404afb220594EntityRecord s = new EN_52e55d60c515b6016f81404afb220594EntityRecord();
  if(obj != null) {
  s.ssTrigger = obj.AttrTrigger == null ? "" : obj.AttrTrigger;
  }
  return s;
}

public static Func<EN_52e55d60c515b6016f81404afb220594EntityRecord, ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_52e55d60c515b6016f81404afb220594EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord FromStructure(EN_52e55d60c515b6016f81404afb220594EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_52e55d60c515b6016f81404afb220594EntityRecord(s, config);
}

}


