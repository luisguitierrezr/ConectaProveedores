using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EntryBlockDatesRecord
public class RESTRC_2cd8ef4429a3040401080390a43c2ddc : AbstractRESTStructure<RC_2cd8ef4429a3040401080390a43c2ddc> {
[JsonProperty("EntryBlockDates")]
public ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord AttrEntryBlockDates;

public RESTRC_2cd8ef4429a3040401080390a43c2ddc() { }

public RESTRC_2cd8ef4429a3040401080390a43c2ddc (RC_2cd8ef4429a3040401080390a43c2ddc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEntryBlockDates = ConvertToRestWithoutDefaults(s.ssENEntryBlockDates, new EN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure, config);
  } else {
AttrEntryBlockDates = ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.FromStructure(s.ssENEntryBlockDates, config);
  }
}

public static RC_2cd8ef4429a3040401080390a43c2ddc ToStructure(ssConectaProveedores.RestRecords.RESTRC_2cd8ef4429a3040401080390a43c2ddc obj) { 
  RC_2cd8ef4429a3040401080390a43c2ddc s = new RC_2cd8ef4429a3040401080390a43c2ddc();
  if(obj != null) {
  s.ssENEntryBlockDates = ssConectaProveedores.RestRecords.RESTEN_ddfc3b52b2b791fec93dfe80e2bbdf54EntityRecord.ToStructure(obj.AttrEntryBlockDates);
  }
  return s;
}

public static Func<RC_2cd8ef4429a3040401080390a43c2ddc, ssConectaProveedores.RestRecords.RESTRC_2cd8ef4429a3040401080390a43c2ddc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2cd8ef4429a3040401080390a43c2ddc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2cd8ef4429a3040401080390a43c2ddc FromStructure(RC_2cd8ef4429a3040401080390a43c2ddc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2cd8ef4429a3040401080390a43c2ddc(s, config);
}

}


