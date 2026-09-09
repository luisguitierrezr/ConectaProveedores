using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// DayOfWeekRecord
public class JSONRC_b80982ac17cf476fb15d90ab7992f505 : AbstractRESTStructure<RC_b80982ac17cf476fb15d90ab7992f505> {
[JsonProperty("DayOfWeek")]
[JsonPropertyName("DayOfWeek")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_994a40086cd6e8196835f26327ddf330EntityRecord AttrDayOfWeek;

public JSONRC_b80982ac17cf476fb15d90ab7992f505() { }

public JSONRC_b80982ac17cf476fb15d90ab7992f505 (RC_b80982ac17cf476fb15d90ab7992f505 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDayOfWeek = ConvertToRestWithoutDefaults(s.ssENDayOfWeek, new EN_994a40086cd6e8196835f26327ddf330EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_994a40086cd6e8196835f26327ddf330EntityRecord.FromStructure, config);
  } else {
AttrDayOfWeek = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_994a40086cd6e8196835f26327ddf330EntityRecord.FromStructure(s.ssENDayOfWeek, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505, RC_b80982ac17cf476fb15d90ab7992f505> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505 s) => ToStructure(s, config);
}
public static RC_b80982ac17cf476fb15d90ab7992f505 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505 obj, IBehaviorsConfiguration config) { 
  RC_b80982ac17cf476fb15d90ab7992f505 s = new RC_b80982ac17cf476fb15d90ab7992f505();
  if(obj != null) {
  s.ssENDayOfWeek = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_994a40086cd6e8196835f26327ddf330EntityRecord.ToStructure(obj.AttrDayOfWeek, config);
  }
  return s;
}

public static Func<RC_b80982ac17cf476fb15d90ab7992f505, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b80982ac17cf476fb15d90ab7992f505 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505 FromStructure(RC_b80982ac17cf476fb15d90ab7992f505 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_b80982ac17cf476fb15d90ab7992f505(s, config);
}

}


