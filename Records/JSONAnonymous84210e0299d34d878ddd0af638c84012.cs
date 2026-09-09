using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryBlockDatesRecord
public class JSONRC_2cd8ef4429a3040401080390a43c2ddc : AbstractRESTStructure<RC_2cd8ef4429a3040401080390a43c2ddc> {
[JsonProperty("EntryBlockDates")]
[JsonPropertyName("EntryBlockDates")]
public ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord AttrEntryBlockDates;

public JSONRC_2cd8ef4429a3040401080390a43c2ddc() { }

public JSONRC_2cd8ef4429a3040401080390a43c2ddc (RC_2cd8ef4429a3040401080390a43c2ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntryBlockDates = ConvertToRestWithoutDefaults(s.ssENEntryBlockDates, new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure, config);
  } else {
AttrEntryBlockDates = ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure(s.ssENEntryBlockDates, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc, RC_2cd8ef4429a3040401080390a43c2ddc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc s) => ToStructure(s, config);
}
public static RC_2cd8ef4429a3040401080390a43c2ddc ToStructure(ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc obj, IBehaviorsConfiguration config) { 
  RC_2cd8ef4429a3040401080390a43c2ddc s = new RC_2cd8ef4429a3040401080390a43c2ddc();
  if(obj != null) {
  s.ssENEntryBlockDates = ssConectaProveedores.RestRecords.JSONEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.ToStructure(obj.AttrEntryBlockDates, config);
  }
  return s;
}

public static Func<RC_2cd8ef4429a3040401080390a43c2ddc, ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2cd8ef4429a3040401080390a43c2ddc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc FromStructure(RC_2cd8ef4429a3040401080390a43c2ddc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_2cd8ef4429a3040401080390a43c2ddc(s, config);
}

}


